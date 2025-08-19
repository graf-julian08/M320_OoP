using System.Windows;
using System.Windows.Threading;
using Luna.Core.Models;
using Luna.Core.Services;

namespace Luna.Desktop;

public partial class MainWindow : Window
{
    private readonly SettingsService _settingsService = new();
    private readonly GeoService _geo = new();
    private readonly WeatherService _weather = new();
    private readonly TimeService _time = new();
    private readonly AiService _ai = new();
    private readonly CommandRouter _router;

    private Settings _settings = new();
    private readonly DispatcherTimer _clockTimer = new();
    private int _lastUtcOffsetSec;

    public MainWindow()
    {
        InitializeComponent();
        _router = new CommandRouter(_weather, _time, _ai);
        Loaded += OnLoaded;
        _clockTimer.Interval = TimeSpan.FromSeconds(1);
        _clockTimer.Tick += (_, _) => UpdateClock();
    }

    private async void OnLoaded(object sender, RoutedEventArgs e)
    {
        _settings = await _settingsService.LoadAsync();
        if (_settings.Latitude == 0 && _settings.Longitude == 0)
        {
            _settings = await _geo.DetectLocationAsync(_settings);
            await _settingsService.SaveAsync(_settings);
        }

        BoxName.Text = _settings.Name ?? string.Empty;
        BoxCity.Text = _settings.City ?? string.Empty;

        await RefreshWeatherAndTime();
        _clockTimer.Start();

        // Wake-Word Listener starten
        SpeechService.Instance.StartWakeWordListening(OnWakeWord);
    }

    private async Task RefreshWeatherAndTime()
    {
        if (_settings.Latitude == 0 && _settings.Longitude == 0) return;
        var now = await _weather.GetCurrentAsync(_settings.Latitude, _settings.Longitude);
        _settings.Timezone = now.Timezone;
        await _settingsService.SaveAsync(_settings);

        TxtTemp.Text = $"{now.TemperatureC:F0} °C";
        TxtWind.Text = $"Wind {now.WindKmh:F0} km/h";
        TxtTimezone.Text = now.Timezone;
        UpdateClock(now.UtcOffsetSeconds);
    }

    private void UpdateClock(int utcOffset = int.MinValue)
    {
        if (utcOffset != int.MinValue) _lastUtcOffsetSec = utcOffset;
        var local = _time.LocalTimeFromUtcOffsetSeconds(_lastUtcOffsetSec);
        TxtClock.Text = local.ToString("HH:mm:ss");
    }

    private async void OnSearchCity(object sender, RoutedEventArgs e)
    {
        try
        {
            var (lat, lon, display, cc) = await _geo.SearchCityAsync(BoxCity.Text);
            _settings.Latitude = lat; _settings.Longitude = lon; _settings.City = display; _settings.CountryCode = cc;
            await RefreshWeatherAndTime();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    private async void OnSave(object sender, RoutedEventArgs e)
    {
        _settings.Name = string.IsNullOrWhiteSpace(BoxName.Text) ? null : BoxName.Text.Trim();
        await _settingsService.SaveAsync(_settings);
        MessageBox.Show("Gespeichert.");
    }

    private void OnTestWake(object sender, RoutedEventArgs e) => OnWakeWord();

    private void OnWakeWord()
    {
        var listen = new ListeningWindow(async recognizedText =>
        {
            if (string.IsNullOrWhiteSpace(recognizedText)) return;

            var tz = _settings.Timezone ?? "GMT";
            var response = await _router.HandleAsync(_settings.Latitude, _settings.Longitude, tz, _lastUtcOffsetSec, recognizedText);

            SpeechService.Instance.Speak(response);
            await RefreshWeatherAndTime();
        })
        { Owner = this };
        listen.ShowDialog();
    }
}

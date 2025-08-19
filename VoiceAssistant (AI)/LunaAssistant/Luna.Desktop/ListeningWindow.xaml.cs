using System.Windows;
using System.Windows.Media.Animation;

namespace Luna.Desktop;

public partial class ListeningWindow : Window
{
    private readonly Func<string, Task> _onFinal;

    public ListeningWindow(Func<string, Task> onFinal)
    {
        InitializeComponent();
        _onFinal = onFinal;
        Loaded += (_, _) => BeginPulse();

        // Start Diktat
        SpeechService.Instance.StartDictation(OnHeard, OnEnd);
    }

    private void BeginPulse()
    {
        var anim = new DoubleAnimation
        {
            From = 180,
            To = 240,
            AutoReverse = true,
            RepeatBehavior = RepeatBehavior.Forever,
            Duration = TimeSpan.FromMilliseconds(900)
        };
        Pulse.BeginAnimation(WidthProperty, anim);
        Pulse.BeginAnimation(HeightProperty, anim);
    }

    private void OnHeard(string partial)
    {
        // Optional Live-Text:
        // Title = partial;
    }

    private async void OnEnd(string finalText)
    {
        var shrink = new DoubleAnimation { To = 80, Duration = TimeSpan.FromMilliseconds(200) };
        Pulse.BeginAnimation(WidthProperty, shrink);
        Pulse.BeginAnimation(HeightProperty, shrink);

        await _onFinal(finalText);
        Close();
    }
}

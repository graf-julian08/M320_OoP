using System.Text.RegularExpressions;

namespace Luna.Core.Services;

public class CommandRouter
{
    private readonly WeatherService _weather;
    private readonly TimeService _time;
    private readonly AiService _ai;

    public CommandRouter(WeatherService w, TimeService t, AiService ai)
    { _weather = w; _time = t; _ai = ai; }

    public async Task<string> HandleAsync(double lat, double lon, string timezone, int utcOffsetSec, string utterance)
    {
        var q = utterance.Trim().ToLowerInvariant();

        if (Regex.IsMatch(q, @"\b(wetter|temperatur|regen)\b"))
        {
            var now = await _weather.GetCurrentAsync(lat, lon);
            return $"Aktuell {now.TemperatureC:F0}°C, Wind {now.WindKmh:F0} km/h in {timezone}.";
        }

        if (Regex.IsMatch(q, @"\b(uhr|uhrzeit|wie spät)\b"))
        {
            var local = _time.LocalTimeFromUtcOffsetSeconds(utcOffsetSec);
            return $"Es ist {local:HH:mm} Uhr ({timezone}).";
        }

        return await _ai.ChatAsync(utterance);
    }
}

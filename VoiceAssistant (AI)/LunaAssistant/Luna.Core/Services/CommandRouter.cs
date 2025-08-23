using System.Text.RegularExpressions;
using Luna.Core.Models;

namespace Luna.Core.Services;

public class CommandRouter
{
    private readonly WeatherService _weather;
    private readonly TimeService _time;
    private readonly AiService _ai;

    public CommandRouter(WeatherService w, TimeService t, AiService ai)
    { _weather = w; _time = t; _ai = ai; }

    public async Task<AssistantReply> HandleAsync(double lat, double lon, string timezone, int utcOffsetSec, string utterance)
    {
        var q = utterance.Trim().ToLowerInvariant();

        // 1) Wetter → terminal (kein weiteres Zuhören)
        if (Regex.IsMatch(q, @"\b(wetter|temperatur|regen)\b"))
        {
            var now = await _weather.GetCurrentAsync(lat, lon);
            return new AssistantReply
            {
                Text = $"Aktuell {now.TemperatureC:F0} \u00B0C, Wind {now.WindKmh:F0} km/h in {timezone}.",
                ContinueListening = false
            };
        }

        // 2) Uhrzeit → terminal
        if (Regex.IsMatch(q, @"\b(uhr|uhrzeit|wie spät)\b"))
        {
            var local = _time.LocalTimeFromUtcOffsetSeconds(utcOffsetSec);
            return new AssistantReply
            {
                Text = $"Es ist {local:HH:mm} Uhr ({timezone}).",
                ContinueListening = false
            };
        }

        // 3) Smalltalk / Allgemein → KI
        var aiText = await _ai.ChatAsync(utterance);

        return new AssistantReply
        {
            Text = aiText,
            ContinueListening = ShouldContinue(aiText)
        };
    }

    // Heuristik: Wenn die Assistenten-Antwort eine Rückfrage enthält, weiter zuhören.
    private static bool ShouldContinue(string text)
    {
        if (string.IsNullOrWhiteSpace(text)) return false;

        var t = text.ToLowerInvariant();

        // typische Rückfragen
        if (t.Contains("wie geht es dir") || t.Contains("wie geht's dir") || t.Contains("und dir"))
            return true;

        // Fragezeichen am Ende (oder insgesamt mehrere Fragen)
        // -> Nur dann weiter, wenn es wie eine Rückfrage an den Nutzer klingt.
        // (Vermeidet „Wetter morgen? Ich empfehle ...“ fälschlich zu verlängern.)
        if (t.Trim().EndsWith("?"))
            return true;

        return false;
    }
}

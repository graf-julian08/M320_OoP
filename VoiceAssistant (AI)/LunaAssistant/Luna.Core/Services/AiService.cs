using System.Net.Http.Json;
using System.Text.Json;

namespace Luna.Core.Services;

public class AiService
{
    private readonly HttpClient _http = new();

    // 1) Empfohlen: Key aus Umgebungsvariable lesen
    //    Name = GEMINI_API_KEY (Fallback: GOOGLE_API_KEY)
    private readonly string _apiKey =
        Environment.GetEnvironmentVariable("GEMINI_API_KEY")
        ?? Environment.GetEnvironmentVariable("GOOGLE_API_KEY")
        ?? string.Empty;

    // 2) Optional NUR ZUM TESTEN: direkt einbetten (unsicher; niemals committen!)
    // private const string _apiKey = "HIER_DEIN_SCHLUESSEL";

    private const string _model = "gemini-1.5-flash";
    private static string Endpoint(string apiKey) =>
        $"https://generativelanguage.googleapis.com/v1beta/models/{_model}:generateContent?key={apiKey}";

    public async Task<string> ChatAsync(string prompt)
    {
        if (string.IsNullOrWhiteSpace(_apiKey))
            return "Kein GEMINI_API_KEY/GOOGLE_API_KEY gesetzt. Bitte API-Key als Umgebungsvariable hinterlegen.";

        var url = Endpoint(_apiKey);

        var requestBody = new
        {
            contents = new[]
            {
                new
                {
                    parts = new[]
                    {
                        new { text = prompt }
                    }
                }
            },
            generationConfig = new
            {
                temperature = 0.7
            }
        };

        HttpResponseMessage httpRes;
        try
        {
            httpRes = await _http.PostAsJsonAsync(url, requestBody);
        }
        catch (Exception ex)
        {
            return $"Gemini-Fehler: Anfrage fehlgeschlagen ({ex.GetType().Name}): {ex.Message}";
        }

        if (!httpRes.IsSuccessStatusCode)
        {
            var body = await SafeReadAsync(httpRes);
            return $"Gemini-Fehler {(int)httpRes.StatusCode} {httpRes.StatusCode}: {body}";
        }

        try
        {
            var doc = await httpRes.Content.ReadFromJsonAsync<JsonElement>();
            // Erwartete Struktur:
            // { "candidates": [ { "content": { "parts": [ { "text": "..." } ] } } ] }
            if (doc.TryGetProperty("candidates", out var candidates)
                && candidates.ValueKind == JsonValueKind.Array
                && candidates.GetArrayLength() > 0)
            {
                var cand = candidates[0];
                if (cand.TryGetProperty("content", out var content)
                    && content.TryGetProperty("parts", out var parts)
                    && parts.ValueKind == JsonValueKind.Array
                    && parts.GetArrayLength() > 0)
                {
                    var text = parts[0].GetProperty("text").GetString();
                    return string.IsNullOrWhiteSpace(text) ? "(keine Antwort erhalten)" : text!;
                }
            }
            return "(unerwartete Antwortstruktur von Gemini)";
        }
        catch (Exception ex)
        {
            var body = await SafeReadAsync(httpRes);
            return $"Gemini-Parsingfehler ({ex.GetType().Name}): {ex.Message}\nRohantwort: {body}";
        }
    }

    private static async Task<string> SafeReadAsync(HttpResponseMessage res)
    {
        try
        {
            return await res.Content.ReadAsStringAsync();
        }
        catch
        {
            return "(Antworttext konnte nicht gelesen werden)";
        }
    }
}

using System.Net.Http.Json;
using System.Text.Json;

namespace Luna.Core.Services;

public class AiService
{
    private readonly HttpClient _http = new();
    private readonly string _apiKey = Environment.GetEnvironmentVariable("AIzaSyAptfFvjZnBNCufnj2NLU2TmeYG_wM4pXM") ?? string.Empty;
    private readonly string _model = "gemini-1.5-flash";

    public async Task<string> ChatAsync(string prompt)
    {
        if (string.IsNullOrWhiteSpace(_apiKey))
            return "Kein GEMINI_API_KEY gesetzt. Bitte API-Key konfigurieren.";

        var url = $"https://generativelanguage.googleapis.com/v1beta/models/{_model}:generateContent?key={_apiKey}";
        var req = new
        {
            contents = new[] { new { parts = new[] { new { text = prompt } } } },
            generationConfig = new { temperature = 0.7 }
        };

        var httpRes = await _http.PostAsJsonAsync(url, req);
        httpRes.EnsureSuccessStatusCode();
        var res = await httpRes.Content.ReadFromJsonAsync<JsonElement>();
        var text = res.GetProperty("candidates")[0].GetProperty("content").GetProperty("parts")[0].GetProperty("text").GetString();
        return string.IsNullOrWhiteSpace(text) ? "(keine Antwort erhalten)" : text!;
    }
}

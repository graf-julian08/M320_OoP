using System.Net.Http.Json;
using Luna.Core.Models;

namespace Luna.Core.Services;

public class GeoService
{
    private readonly HttpClient _http = new();

    // Auto-Ort über IP (ipapi.co)
    public async Task<Settings> DetectLocationAsync(Settings s)
    {
        try
        {
            var ip = await _http.GetFromJsonAsync<IpApiCo>("https://ipapi.co/json/");
            if (ip != null)
            {
                s.City = ip.city;
                s.CountryCode = ip.country_code;
                s.Latitude = ip.latitude;
                s.Longitude = ip.longitude;
            }
        }
        catch { /* offline? */ }
        return s;
    }

    // Manuelle Ortssuche (Open-Meteo Geocoding)
    public async Task<(double lat, double lon, string display, string? cc)> SearchCityAsync(string query, string lang = "de")
    {
        var url = $"https://geocoding-api.open-meteo.com/v1/search?name={Uri.EscapeDataString(query)}&count=1&language={lang}&format=json";
        var r = await _http.GetFromJsonAsync<GeoCoding>(url);
        var first = r?.results?.FirstOrDefault() ?? throw new Exception("Ort nicht gefunden");
        var display = first.name +
                      (string.IsNullOrWhiteSpace(first.admin1) ? string.Empty : $", {first.admin1}") +
                      (string.IsNullOrWhiteSpace(first.country_code) ? string.Empty : $" ({first.country_code})");
        return (first.latitude, first.longitude, display, first.country_code);
    }

    private record IpApiCo(string ip, string city, string region, string country_name, string country_code, double latitude, double longitude);

    private class GeoCoding
    {
        public List<Result>? results { get; set; }
        public class Result
        {
            public string id { get; set; } = string.Empty;
            public string name { get; set; } = string.Empty;
            public string? admin1 { get; set; }
            public string country_code { get; set; } = string.Empty;
            public double latitude { get; set; }
            public double longitude { get; set; }
        }
    }
}

using System.Net.Http.Json;

namespace Luna.Core.Services;

public class WeatherService
{
    private readonly HttpClient _http = new();

    public async Task<WeatherNow> GetCurrentAsync(double lat, double lon)
    {
        var url = $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&current_weather=true&timezone=auto";
        var data = await _http.GetFromJsonAsync<OpenMeteoResponse>(url) ?? throw new Exception("Wetterfehler");
        return new WeatherNow
        {
            TemperatureC = data.current_weather.temperature,
            WindKmh = data.current_weather.windspeed,
            WeatherCode = data.current_weather.weathercode,
            TimeIso = data.current_weather.time,
            Timezone = data.timezone,
            UtcOffsetSeconds = data.utc_offset_seconds
        };
    }

    public record WeatherNow
    {
        public double TemperatureC { get; set; }
        public double WindKmh { get; set; }
        public int WeatherCode { get; set; }
        public string TimeIso { get; set; } = string.Empty;
        public string Timezone { get; set; } = "GMT";
        public int UtcOffsetSeconds { get; set; }
    }

    private class OpenMeteoResponse
    {
        public string timezone { get; set; } = "GMT";
        public int utc_offset_seconds { get; set; }
        public Current current_weather { get; set; } = new();
        public class Current
        {
            public string time { get; set; } = string.Empty;
            public double temperature { get; set; }
            public double windspeed { get; set; }
            public int weathercode { get; set; }
        }
    }
}

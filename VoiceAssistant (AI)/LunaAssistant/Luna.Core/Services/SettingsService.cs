using System.Text.Json;
using Luna.Core.Models;

namespace Luna.Core.Services;

public class SettingsService
{
    private readonly string _path;
    public SettingsService()
    {
        var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        var dir = Path.Combine(appData, "LunaAssistant");
        Directory.CreateDirectory(dir);
        _path = Path.Combine(dir, "settings.json");
    }

    public async Task<Settings> LoadAsync()
    {
        if (!File.Exists(_path)) return new Settings();
        var json = await File.ReadAllTextAsync(_path);
        return JsonSerializer.Deserialize<Settings>(json) ?? new Settings();
    }

    public async Task SaveAsync(Settings s)
    {
        var json = JsonSerializer.Serialize(s, new JsonSerializerOptions { WriteIndented = true });
        await File.WriteAllTextAsync(_path, json);
    }
}

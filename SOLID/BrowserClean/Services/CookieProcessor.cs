using BrowserClean.Interfaces;

namespace BrowserClean.Services;

public class CookieProcessor : ISettingsProcessor
{
    private readonly ICookieStorage _storage;
    public string SettingType => "Cookies";

    public CookieProcessor(ICookieStorage storage) => _storage = storage;

    public void Process(string action)
    {
        var actions = new Dictionary<string, Action>
        {
            ["Load"] = () => _storage.Load(),
            ["Save"] = () => _storage.Save(),
            ["Clear"] = () => _storage.Clear(),
            ["Sync"] = () => _storage.Sync(),
            ["Validate"] = () => _storage.Validate(),
            ["Backup"] = () => _storage.Backup()
        };

        if (actions.TryGetValue(action, out var execute))
            execute();
        else
            Console.WriteLine($"[CookieProcessor] Unknown action: {action}");
    }
}
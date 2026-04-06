using BrowserClean.Interfaces;

namespace BrowserClean.Services;

public class CacheProcessor : ISettingsProcessor
{
    private readonly ICacheStorage _storage;
    public string SettingType => "Cache";

    public CacheProcessor(ICacheStorage storage) => _storage = storage;

    public void Process(string action)
    {
        var actions = new Dictionary<string, Action>
        {
            ["Load"] = () => _storage.Load(),
            ["Clear"] = () => _storage.Clear(),
            ["Validate"] = () => _storage.Validate()
        };

        if (actions.TryGetValue(action, out var execute))
            execute();
        else
            Console.WriteLine($"[CacheProcessor] Unknown action: {action}");
    }
}
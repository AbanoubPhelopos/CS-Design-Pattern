using BrowserClean.Interfaces;

namespace BrowserClean.Services;

public class PrintSettingsProcessor : ISettingsProcessor
{
    private readonly IPrintSettingsStorage _storage;
    public string SettingType => "PrintSettings";

    public PrintSettingsProcessor(IPrintSettingsStorage storage) => _storage = storage;

    public void Process(string action)
    {
        var actions = new Dictionary<string, Action>
        {
            ["Load"] = () => _storage.Load(),
            ["Save"] = () => _storage.Save(),
            ["Reset"] = () => _storage.Reset(),
            ["Validate"] = () => _storage.Validate(),
            ["Backup"] = () => _storage.Backup()
        };

        if (actions.TryGetValue(action, out var execute))
            execute();
        else
            Console.WriteLine($"[PrintSettingsProcessor] Unknown action: {action}");
    }
}
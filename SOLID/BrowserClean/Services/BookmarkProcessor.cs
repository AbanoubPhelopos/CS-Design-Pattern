using BrowserClean.Interfaces;

namespace BrowserClean.Services;

public class BookmarkProcessor : ISettingsProcessor
{
    private readonly IBookmarkStorage _storage;
    public string SettingType => "Bookmarks";

    public BookmarkProcessor(IBookmarkStorage storage) => _storage = storage;

    public void Process(string action)
    {
        var actions = new Dictionary<string, Action>
        {
            ["Load"] = () => _storage.Load(),
            ["Save"] = () => _storage.Save(),
            ["Clear"] = () => _storage.Clear(),
            ["Export"] = () => _storage.Export(),
            ["Sync"] = () => _storage.Sync(),
            ["Validate"] = () => _storage.Validate(),
            ["Backup"] = () => _storage.Backup()
        };

        if (actions.TryGetValue(action, out var execute))
            execute();
        else
            Console.WriteLine($"[BookmarkProcessor] Unknown action: {action}");
    }
}
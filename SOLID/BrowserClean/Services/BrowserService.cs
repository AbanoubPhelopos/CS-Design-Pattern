using BrowserClean.Interfaces;

namespace BrowserClean.Services;

public class BrowserService
{
    private readonly Dictionary<string, ISettingsProcessor> _processors;

    public BrowserService(
        ICookieStorage cookieStorage,
        ICacheStorage cacheStorage,
        IHistoryStorage historyStorage,
        IBookmarkStorage bookmarkStorage,
        IPrintSettingsStorage printSettingsStorage)
    {
        _processors = new Dictionary<string, ISettingsProcessor>
        {
            ["Cookies"] = new CookieProcessor(cookieStorage),
            ["Cache"] = new CacheProcessor(cacheStorage),
            ["History"] = new HistoryProcessor(historyStorage),
            ["Bookmarks"] = new BookmarkProcessor(bookmarkStorage),
            ["PrintSettings"] = new PrintSettingsProcessor(printSettingsStorage)
        };
    }

    public void ProcessSetting(string settingType, string action)
    {
        if (_processors.TryGetValue(settingType, out var processor))
            processor.Process(action);
        else
            Console.WriteLine($"[ERROR] Unknown setting type: {settingType}");
    }

    public void ProcessAllSettings(string action)
    {
        Console.WriteLine($"\n**** BATCH OPERATION: Processing ALL settings - {action} ****");
        foreach (var processor in _processors.Values)
            processor.Process(action);
        Console.WriteLine("** BATCH OPERATION COMPLETE **\n");
    }
}
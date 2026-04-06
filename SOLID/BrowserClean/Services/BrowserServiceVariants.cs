using BrowserClean.Interfaces;

namespace BrowserClean.Services;

public abstract class BrowserServiceBase
{
    protected readonly ICookieStorage CookieStorage;
    protected readonly ICacheStorage CacheStorage;
    protected readonly IHistoryStorage HistoryStorage;
    protected readonly IBookmarkStorage BookmarkStorage;
    protected readonly IPrintSettingsStorage PrintSettingsStorage;

    protected BrowserServiceBase(
        ICookieStorage cookieStorage,
        ICacheStorage cacheStorage,
        IHistoryStorage historyStorage,
        IBookmarkStorage bookmarkStorage,
        IPrintSettingsStorage printSettingsStorage)
    {
        CookieStorage = cookieStorage;
        CacheStorage = cacheStorage;
        HistoryStorage = historyStorage;
        BookmarkStorage = bookmarkStorage;
        PrintSettingsStorage = printSettingsStorage;
    }

    public virtual void ProcessSetting(string settingType, string action)
    {
        Console.WriteLine($"Processing: {settingType} | Action: {action}");
    }

    protected void LoadAll()
    {
        CookieStorage.Load();
        CacheStorage.Load();
        HistoryStorage.Load();
        BookmarkStorage.Load();
        PrintSettingsStorage.Load();
    }
}

public class LightBrowserService : BrowserServiceBase
{
    public LightBrowserService(
        ICookieStorage cookieStorage,
        ICacheStorage cacheStorage,
        IHistoryStorage historyStorage,
        IBookmarkStorage bookmarkStorage,
        IPrintSettingsStorage printSettingsStorage)
        : base(cookieStorage, cacheStorage, historyStorage, bookmarkStorage, printSettingsStorage)
    {
    }

    public override void ProcessSetting(string settingType, string action)
    {
        if (settingType == "Cache")
        {
            Console.WriteLine("[LIGHT] Cache processing not supported in light mode!");
            return;
        }
        base.ProcessSetting(settingType, action);
    }
}

public class SuperBrowserService : BrowserServiceBase
{
    public SuperBrowserService(
        ICookieStorage cookieStorage,
        ICacheStorage cacheStorage,
        IHistoryStorage historyStorage,
        IBookmarkStorage bookmarkStorage,
        IPrintSettingsStorage printSettingsStorage)
        : base(cookieStorage, cacheStorage, historyStorage, bookmarkStorage, printSettingsStorage)
    {
    }

    public override void ProcessSetting(string settingType, string action)
    {
        Console.WriteLine("[SUPER] Enhanced browser service processing...");
        base.ProcessSetting(settingType, action);
    }
}
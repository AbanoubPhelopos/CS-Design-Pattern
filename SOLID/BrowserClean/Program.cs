using BrowserClean.Interfaces;
using BrowserClean.Models;
using BrowserClean.Services;

namespace BrowserClean;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n╔══════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║  SOLID PRINCIPLES DEMONSTRATION - GOOGLE CHROME BROWSER SETTINGS  ║");
        Console.WriteLine("║  This code follows ALL 5 SOLID principles                        ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════════════════════╝\n");

        ICookieStorage cookieStorage = new ChromeCookieStorage();
        ICacheStorage cacheStorage = new ChromeCacheStorage();
        IHistoryStorage historyStorage = new ChromeHistoryStorage();
        IBookmarkStorage bookmarkStorage = new ChromeBookmarkStorage();
        IPrintSettingsStorage printStorage = new ChromePrintSettingsStorage();

        var browserService = new BrowserService(
            cookieStorage, cacheStorage, historyStorage, bookmarkStorage, printStorage);

        Console.WriteLine("--- ISP: Interfaces are small and focused ---");
        Console.WriteLine("Cache implements only: ILoadable, IClearable, IValidatable");
        Console.WriteLine("Cookies implement: ILoadable, ISavable, IClearable, ISyncable, IValidatable, IBackuppable\n");

        Console.WriteLine("--- DIP: Dependencies injected via constructor ---");
        Console.WriteLine("BrowserService depends on abstractions (interfaces), not concretions\n");

        Console.WriteLine("--- SRP: Each processor handles ONE setting type ---");
        browserService.ProcessSetting("Cookies", "Load");
        browserService.ProcessSetting("Cache", "Clear");
        browserService.ProcessSetting("History", "Export");
        browserService.ProcessSetting("Bookmarks", "Sync");
        browserService.ProcessSetting("PrintSettings", "Reset");

        browserService.ProcessAllSettings("Load");

        Console.WriteLine("\n--- LSP: Subclasses can substitute base class ---");
        var firefoxCookies = new FirefoxCookieStorage();
        ICookieStorage storage = firefoxCookies;
        storage.Load();

        Console.WriteLine("\n--- OCP: Extended without modification ---");
        var superService = new SuperBrowserService(
            cookieStorage, cacheStorage, historyStorage, bookmarkStorage, printStorage);
        superService.ProcessSetting("History", "Load");

        var lightService = new LightBrowserService(
            cookieStorage, cacheStorage, historyStorage, bookmarkStorage, printStorage);
        lightService.ProcessSetting("Cache", "Clear");
        lightService.ProcessSetting("Cookies", "Load");

        Console.WriteLine("\n[SUCCESS] All SOLID principles demonstrated successfully!\n");
    }
}
using BrowserViolation.Managers;
using BrowserViolation.Models;

namespace BrowserViolation;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n╔══════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║  SOLID VIOLATION DEMONSTRATION - GOOGLE CHROME BROWSER SETTINGS     ║");
        Console.WriteLine("║  This code violates ALL 5 SOLID principles                           ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════════════════════╝\n");
        
        var manager = new BrowserSettingsManager();
        
        manager.ProcessBrowserSetting(BrowserSettingType.Cookies, "Load");
        manager.ProcessBrowserSetting(BrowserSettingType.Cache, "Clear");
        manager.ProcessBrowserSetting(BrowserSettingType.History, "Export");
        manager.ProcessBrowserSetting(BrowserSettingType.Bookmarks, "Sync");
        manager.ProcessBrowserSetting(BrowserSettingType.PrintSettings, "Reset");
        
        manager.ProcessAllSettings("Load");
        
        manager.GenerateBrowserReport();
        
        Console.WriteLine("\n--- Testing Inheritance Violation (LSP) ---");
        var superManager = new SuperBrowserManager();
        superManager.ProcessBrowserSetting(BrowserSettingType.History, "Load");
        
        var lightManager = new LightBrowserManager();
        lightManager.ProcessBrowserSetting(BrowserSettingType.Cache, "Clear");
        lightManager.ProcessBrowserSetting(BrowserSettingType.Cookies, "Load");
        
        Console.WriteLine("\n[NOTE] Notice how LightBrowserManager skips cache processing.");
        Console.WriteLine("[NOTE] This violates LSP - subclasses cannot substitute base class behavior.\n");
    }
}

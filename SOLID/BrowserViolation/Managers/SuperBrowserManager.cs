using BrowserViolation.Models;

namespace BrowserViolation.Managers;

public class SuperBrowserManager : BrowserSettingsManager
{
    public new void ProcessBrowserSetting(BrowserSettingType settingType, string action)
    {
        Console.WriteLine("[SUPER] Enhanced browser manager processing...");
        base.ProcessBrowserSetting(settingType, action);
    }
}

using BrowserViolation.Models;

namespace BrowserViolation.Managers;

public class LightBrowserManager : BrowserSettingsManager
{
    public new void ProcessBrowserSetting(BrowserSettingType settingType, string action)
    {
        if (settingType == BrowserSettingType.Cache)
        {
            Console.WriteLine("[LIGHT] Cache processing not supported in light mode!");
            return;
        }
        base.ProcessBrowserSetting(settingType, action);
    }
}

using BrowserClean.Interfaces;

namespace BrowserClean.Services;

public interface ISettingsProcessor
{
    void Process(string action);
    string SettingType { get; }
}
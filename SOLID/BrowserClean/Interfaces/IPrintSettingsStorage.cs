namespace BrowserClean.Interfaces;

public interface IPrintSettingsStorage : ILoadable, ISavable, IResettable, IValidatable, IBackuppable
{
    string PrinterName { get; set; }
    int Copies { get; set; }
}
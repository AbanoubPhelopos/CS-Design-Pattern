namespace BrowserClean.Models;

public class ChromePrintSettingsStorage : Interfaces.IPrintSettingsStorage
{
    public string PrinterName { get; set; } = "";
    public int Copies { get; set; } = 1;

    public void Load() => Console.WriteLine("[ChromePrintSettingsStorage] Loading print settings...");
    public void Save() => Console.WriteLine("[ChromePrintSettingsStorage] Saving print settings...");
    public void Reset() => Console.WriteLine("[ChromePrintSettingsStorage] Resetting to default printer...");
    public void Validate() => Console.WriteLine("[ChromePrintSettingsStorage] Validating printer connectivity...");
    public void Backup() => Console.WriteLine("[ChromePrintSettingsStorage] Backing up print settings...");
}
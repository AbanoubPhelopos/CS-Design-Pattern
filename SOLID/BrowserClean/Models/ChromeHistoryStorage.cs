namespace BrowserClean.Models;

public class ChromeHistoryStorage : Interfaces.IHistoryStorage
{
    public List<string> VisitedUrls { get; set; } = new();

    public void Load() => Console.WriteLine("[ChromeHistoryStorage] Loading browsing history...");
    public void Save() => Console.WriteLine("[ChromeHistoryStorage] Saving history entries...");
    public void Clear() => Console.WriteLine("[ChromeHistoryStorage] Clearing all history...");
    public void Export() => Console.WriteLine("[ChromeHistoryStorage] Exporting history to JSON...");
    public void Import() => Console.WriteLine("[ChromeHistoryStorage] Importing history from JSON...");
    public void Sync() => Console.WriteLine("[ChromeHistoryStorage] Syncing history with Google Account...");
    public void Validate() => Console.WriteLine("[ChromeHistoryStorage] Validating history database...");
    public void Backup() => Console.WriteLine("[ChromeHistoryStorage] Backing up history database...");
    public void Restore() => Console.WriteLine("[ChromeHistoryStorage] Restoring history from backup...");
}
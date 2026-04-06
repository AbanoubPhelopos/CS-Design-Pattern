using BrowserViolation.Interfaces;

namespace BrowserViolation.Models;

public class ChromeHistory : IBrowserSettings
{
    public List<string> VisitedUrls { get; set; } = new();
    
    public void Load() => Console.WriteLine("[ChromeHistory] Loading browsing history...");
    public void Save() => Console.WriteLine("[ChromeHistory] Saving history entries...");
    public void Reset() => Console.WriteLine("[ChromeHistory] Clearing history...");
    public void Export() => Console.WriteLine("[ChromeHistory] Exporting history to JSON...");
    public void Import() => Console.WriteLine("[ChromeHistory] Importing history from JSON...");
    public void Clear() => Console.WriteLine("[ChromeHistory] Clearing all history...");
    public void Sync() => Console.WriteLine("[ChromeHistory] Syncing history with Google Account...");
    public void Validate() => Console.WriteLine("[ChromeHistory] Validating history database...");
    public void Backup() => Console.WriteLine("[ChromeHistory] Backing up history database...");
    public void Restore() => Console.WriteLine("[ChromeHistory] Restoring history from backup...");
}

namespace BrowserClean.Models;

public class ChromeCookieStorage : Interfaces.ICookieStorage
{
    public string CookieData { get; set; } = "";
    public int CookieCount => string.IsNullOrEmpty(CookieData) ? 0 : CookieData.Split(';').Length;

    public void Load() => Console.WriteLine("[ChromeCookieStorage] Loading cookies...");
    public void Save() => Console.WriteLine("[ChromeCookieStorage] Saving cookies...");
    public void Clear() => Console.WriteLine("[ChromeCookieStorage] Clearing cookies...");
    public void Sync() => Console.WriteLine("[ChromeCookieStorage] Syncing cookies with cloud...");
    public void Validate() => Console.WriteLine("[ChromeCookieStorage] Validating cookie integrity...");
    public void Backup() => Console.WriteLine("[ChromeCookieStorage] Backing up cookies...");
}
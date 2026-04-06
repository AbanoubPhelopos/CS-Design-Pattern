namespace BrowserClean.Models;

public class ChromeBookmarkStorage : Interfaces.IBookmarkStorage
{
    public List<Bookmark> Bookmarks { get; set; } = new();

    public void Load() => Console.WriteLine("[ChromeBookmarkStorage] Loading bookmarks...");
    public void Save() => Console.WriteLine("[ChromeBookmarkStorage] Saving bookmarks...");
    public void Clear() => Console.WriteLine("[ChromeBookmarkStorage] Clearing all bookmarks...");
    public void Export() => Console.WriteLine("[ChromeBookmarkStorage] Exporting bookmarks to HTML...");
    public void Import() => Console.WriteLine("[ChromeBookmarkStorage] Importing bookmarks from HTML...");
    public void Sync() => Console.WriteLine("[ChromeBookmarkStorage] Syncing bookmarks with Chrome Account...");
    public void Validate() => Console.WriteLine("[ChromeBookmarkStorage] Validating bookmark structure...");
    public void Backup() => Console.WriteLine("[ChromeBookmarkStorage] Creating bookmark backup...");
    public void Restore() => Console.WriteLine("[ChromeBookmarkStorage] Restoring bookmarks from backup...");
}
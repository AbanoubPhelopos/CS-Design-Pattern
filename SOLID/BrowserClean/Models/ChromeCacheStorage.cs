namespace BrowserClean.Models;

public class ChromeCacheStorage : Interfaces.ICacheStorage
{
    public long CacheSize { get; set; }
    public string CacheLocation { get; set; } = "";

    public void Load() => Console.WriteLine("[ChromeCacheStorage] Loading cache metadata...");
    public void Clear() => Console.WriteLine("[ChromeCacheStorage] Clearing disk cache...");
    public void Validate() => Console.WriteLine("[ChromeCacheStorage] Validating cache integrity...");
}
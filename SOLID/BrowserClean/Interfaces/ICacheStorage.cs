namespace BrowserClean.Interfaces;

public interface ICacheStorage : ILoadable, IClearable, IValidatable
{
    long CacheSize { get; }
    string CacheLocation { get; }
}
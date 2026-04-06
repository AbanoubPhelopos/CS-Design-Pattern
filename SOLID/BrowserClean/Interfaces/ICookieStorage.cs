namespace BrowserClean.Interfaces;

public interface ICookieStorage : ILoadable, ISavable, IClearable, ISyncable, IValidatable, IBackuppable
{
    string CookieData { get; set; }
    int CookieCount { get; }
}
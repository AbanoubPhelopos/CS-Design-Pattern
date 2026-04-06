using BrowserClean.Models;

namespace BrowserClean.Interfaces;

public interface IBookmarkStorage : ILoadable, ISavable, IClearable, IExportable, IImportable, ISyncable, IValidatable, IBackuppable, IRestorable
{
    List<Bookmark> Bookmarks { get; }
}
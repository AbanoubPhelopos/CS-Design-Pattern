using BrowserClean.Models;

namespace BrowserClean.Interfaces;

public interface IHistoryStorage : ILoadable, ISavable, IClearable, IExportable, IImportable, ISyncable, IValidatable, IBackuppable, IRestorable
{
    List<string> VisitedUrls { get; }
}
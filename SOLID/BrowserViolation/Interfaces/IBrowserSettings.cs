namespace BrowserViolation.Interfaces;

public interface IBrowserSettings
{
    void Load();
    void Save();
    void Reset();
    void Export();
    void Import();
    void Clear();
    void Sync();
    void Validate();
    void Backup();
    void Restore();
}


namespace BrowserClean.Models
{
    public class Bookmark
    {
        public string Title { get; set; } = "";
        public string Url { get; set; } = "";
        public DateTime CreatedAt { get; set; }
        public string Folder { get; set; } = "";
    }
}
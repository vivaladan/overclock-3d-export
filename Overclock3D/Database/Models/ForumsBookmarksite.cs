namespace Overclock3D.Database.Models
{
    public partial class ForumsBookmarksite
    {
        public uint Bookmarksiteid { get; set; }
        public string Title { get; set; } = null!;
        public string Iconpath { get; set; } = null!;
        public ushort Active { get; set; }
        public uint Displayorder { get; set; }
        public string Url { get; set; } = null!;
        public ushort Utf8encode { get; set; }
    }
}

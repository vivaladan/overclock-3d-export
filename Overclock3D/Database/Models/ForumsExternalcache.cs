namespace Overclock3D.Database.Models
{
    public partial class ForumsExternalcache
    {
        public string Cachehash { get; set; } = null!;
        public string? Text { get; set; }
        public string? Headers { get; set; }
        public uint Dateline { get; set; }
        public uint Forumid { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsPodcast
    {
        public uint Forumid { get; set; }
        public string Author { get; set; } = null!;
        public string Category { get; set; } = null!;
        public string Image { get; set; } = null!;
        public short Explicit { get; set; }
        public short Enabled { get; set; }
        public string Keywords { get; set; } = null!;
        public string Owneremail { get; set; } = null!;
        public string Ownername { get; set; } = null!;
        public string Subtitle { get; set; } = null!;
        public string? Summary { get; set; }
        public short Categoryid { get; set; }
    }
}

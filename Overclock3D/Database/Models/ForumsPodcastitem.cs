namespace Overclock3D.Database.Models
{
    public partial class ForumsPodcastitem
    {
        public uint Postid { get; set; }
        public string Url { get; set; } = null!;
        public uint Length { get; set; }
        public ushort Explicit { get; set; }
        public string Keywords { get; set; } = null!;
        public string Subtitle { get; set; } = null!;
        public string Author { get; set; } = null!;
    }
}

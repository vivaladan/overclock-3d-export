namespace Overclock3D.Database.Models
{
    public partial class ForumsSocialgroupicon
    {
        public uint Groupid { get; set; }
        public uint? Userid { get; set; }
        public byte[]? Filedata { get; set; }
        public string Extension { get; set; } = null!;
        public uint Dateline { get; set; }
        public uint Width { get; set; }
        public uint Height { get; set; }
        public byte[]? ThumbnailFiledata { get; set; }
        public uint ThumbnailWidth { get; set; }
        public uint ThumbnailHeight { get; set; }
    }
}

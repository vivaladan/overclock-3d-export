namespace Overclock3D.Database.Models
{
    public partial class ForumsPicture
    {
        public uint Pictureid { get; set; }
        public uint Userid { get; set; }
        public string? Caption { get; set; }
        public string Extension { get; set; } = null!;
        public byte[]? Filedata { get; set; }
        public uint Filesize { get; set; }
        public ushort Width { get; set; }
        public ushort Height { get; set; }
        public byte[]? Thumbnail { get; set; }
        public uint ThumbnailFilesize { get; set; }
        public ushort ThumbnailWidth { get; set; }
        public ushort ThumbnailHeight { get; set; }
        public uint ThumbnailDateline { get; set; }
        public string Idhash { get; set; } = null!;
        public uint Reportthreadid { get; set; }
        public string State { get; set; } = null!;
    }
}

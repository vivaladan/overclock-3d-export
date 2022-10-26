namespace Overclock3D.Database.Models
{
    public partial class ForumsAttachment
    {
        public uint Attachmentid { get; set; }
        public uint Userid { get; set; }
        public uint Dateline { get; set; }
        public uint ThumbnailDateline { get; set; }
        public string Filename { get; set; } = null!;
        public byte[]? Filedata { get; set; }
        public ushort Visible { get; set; }
        public uint Counter { get; set; }
        public uint Filesize { get; set; }
        public uint Postid { get; set; }
        public string Filehash { get; set; } = null!;
        public string Posthash { get; set; } = null!;
        public byte[]? Thumbnail { get; set; }
        public uint ThumbnailFilesize { get; set; }
        public string Extension { get; set; } = null!;
        public long Importattachmentid { get; set; }
    }
}

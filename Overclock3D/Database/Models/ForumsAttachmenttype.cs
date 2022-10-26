namespace Overclock3D.Database.Models
{
    public partial class ForumsAttachmenttype
    {
        public string Extension { get; set; } = null!;
        public string Mimetype { get; set; } = null!;
        public uint Size { get; set; }
        public ushort Width { get; set; }
        public ushort Height { get; set; }
        public ushort Enabled { get; set; }
        public ushort Display { get; set; }
        public ushort Thumbnail { get; set; }
        public ushort Newwindow { get; set; }
    }
}

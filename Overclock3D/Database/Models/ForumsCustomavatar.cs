namespace Overclock3D.Database.Models
{
    public partial class ForumsCustomavatar
    {
        public uint Userid { get; set; }
        public byte[]? Filedata { get; set; }
        public uint Dateline { get; set; }
        public string Filename { get; set; } = null!;
        public short Visible { get; set; }
        public uint Filesize { get; set; }
        public ushort Width { get; set; }
        public ushort Height { get; set; }
        public byte[]? FiledataThumb { get; set; }
        public uint WidthThumb { get; set; }
        public uint HeightThumb { get; set; }
        public long Importcustomavatarid { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsCustomprofilepic
    {
        public uint Userid { get; set; }
        public byte[]? Filedata { get; set; }
        public uint Dateline { get; set; }
        public string Filename { get; set; } = null!;
        public short Visible { get; set; }
        public uint Filesize { get; set; }
        public ushort Width { get; set; }
        public ushort Height { get; set; }
        public long Importcustomprofilepicid { get; set; }
    }
}

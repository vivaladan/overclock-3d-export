namespace Overclock3D.Database.Models
{
    public partial class ForumsInfractionlevel
    {
        public uint Infractionlevelid { get; set; }
        public uint Points { get; set; }
        public uint Expires { get; set; }
        public string Period { get; set; } = null!;
        public ushort Warning { get; set; }
        public ushort Extend { get; set; }
    }
}

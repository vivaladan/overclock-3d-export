namespace Overclock3D.Database.Models
{
    public partial class IpbbbcodeMediatag
    {
        public ushort MediatagId { get; set; }
        public string MediatagName { get; set; } = null!;
        public string? MediatagMatch { get; set; }
        public string? MediatagReplace { get; set; }
        public short MediatagPosition { get; set; }
    }
}

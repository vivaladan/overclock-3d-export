namespace Overclock3D.Database.Models
{
    public partial class IpbconvLink
    {
        public uint LinkId { get; set; }
        public int IpbId { get; set; }
        public string ForeignId { get; set; } = null!;
        public string? Type { get; set; }
        public bool Duplicate { get; set; }
        public int App { get; set; }
    }
}

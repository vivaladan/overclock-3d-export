namespace Overclock3D.Database.Models
{
    public partial class IpbtagsIndex
    {
        public ulong Id { get; set; }
        public string App { get; set; } = null!;
        public string Tag { get; set; } = null!;
        public string Type { get; set; } = null!;
        public ulong TypeId { get; set; }
        public string Type2 { get; set; } = null!;
        public ulong TypeId2 { get; set; }
        public uint Updated { get; set; }
        public uint MemberId { get; set; }
        public int TagHidden { get; set; }
    }
}

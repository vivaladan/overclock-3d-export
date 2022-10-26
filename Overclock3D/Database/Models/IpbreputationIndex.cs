namespace Overclock3D.Database.Models
{
    public partial class IpbreputationIndex
    {
        public ulong Id { get; set; }
        public uint MemberId { get; set; }
        public string App { get; set; } = null!;
        public string Type { get; set; } = null!;
        public uint TypeId { get; set; }
        public uint RepDate { get; set; }
        public string RepMsg { get; set; } = null!;
        public bool RepRating { get; set; }
    }
}

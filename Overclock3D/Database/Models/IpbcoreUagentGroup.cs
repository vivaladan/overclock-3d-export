namespace Overclock3D.Database.Models
{
    public partial class IpbcoreUagentGroup
    {
        public int UgroupId { get; set; }
        public string UgroupTitle { get; set; } = null!;
        public string? UgroupArray { get; set; }
    }
}

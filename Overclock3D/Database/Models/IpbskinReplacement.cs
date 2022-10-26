namespace Overclock3D.Database.Models
{
    public partial class IpbskinReplacement
    {
        public int ReplacementId { get; set; }
        public string ReplacementKey { get; set; } = null!;
        public string? ReplacementContent { get; set; }
        public int ReplacementSetId { get; set; }
        public int ReplacementAddedTo { get; set; }
        public string ReplacementMasterKey { get; set; } = null!;
    }
}

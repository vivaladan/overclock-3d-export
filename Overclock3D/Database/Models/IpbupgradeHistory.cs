namespace Overclock3D.Database.Models
{
    public partial class IpbupgradeHistory
    {
        public int UpgradeId { get; set; }
        public int UpgradeVersionId { get; set; }
        public string UpgradeVersionHuman { get; set; } = null!;
        public int UpgradeDate { get; set; }
        public int UpgradeMid { get; set; }
        public string? UpgradeNotes { get; set; }
        public string UpgradeApp { get; set; } = null!;
    }
}

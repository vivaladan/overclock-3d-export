namespace Overclock3D.Database.Models
{
    public partial class IpbskinCssPreviou
    {
        public int PCssId { get; set; }
        public string PCssGroup { get; set; } = null!;
        public string? PCssContent { get; set; }
        public string PCssApp { get; set; } = null!;
        public string? PCssAttributes { get; set; }
        public string PCssModules { get; set; } = null!;
        public string PCssMasterKey { get; set; } = null!;
        public string PCssLongVersion { get; set; } = null!;
        public string PCssHumanVersion { get; set; } = null!;
    }
}

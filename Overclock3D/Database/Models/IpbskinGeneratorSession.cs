namespace Overclock3D.Database.Models
{
    public partial class IpbskinGeneratorSession
    {
        public string SgSessionId { get; set; } = null!;
        public int SgMemberId { get; set; }
        public int SgSkinSetId { get; set; }
        public int SgDateStart { get; set; }
        public string? SgData { get; set; }
    }
}

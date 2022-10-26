namespace Overclock3D.Database.Models
{
    public partial class IpbcoreSoftDeleteLog
    {
        public int SdlId { get; set; }
        public int SdlObjId { get; set; }
        public string SdlObjKey { get; set; } = null!;
        public int SdlObjMemberId { get; set; }
        public int SdlObjDate { get; set; }
        public string? SdlObjReason { get; set; }
        public int SdlLocked { get; set; }
    }
}

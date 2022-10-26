namespace Overclock3D.Database.Models
{
    public partial class IpbcacheStore
    {
        public string CsKey { get; set; } = null!;
        public string? CsValue { get; set; }
        public bool CsArray { get; set; }
        public int CsUpdated { get; set; }
        public bool CsRebuild { get; set; }
    }
}

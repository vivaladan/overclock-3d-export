namespace Overclock3D.Database.Models
{
    public partial class IpbrssImported
    {
        public string RssImportedGuid { get; set; } = null!;
        public int RssImportedTid { get; set; }
        public int RssImportedImpid { get; set; }
    }
}

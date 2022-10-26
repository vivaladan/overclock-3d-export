namespace Overclock3D.Database.Models
{
    public partial class IpbattachmentsType
    {
        public int AtypeId { get; set; }
        public string AtypeExtension { get; set; } = null!;
        public string AtypeMimetype { get; set; } = null!;
        public bool? AtypePost { get; set; }
        public string? AtypeImg { get; set; }
    }
}

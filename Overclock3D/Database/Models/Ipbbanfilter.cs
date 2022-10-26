namespace Overclock3D.Database.Models
{
    public partial class Ipbbanfilter
    {
        public int BanId { get; set; }
        public string BanType { get; set; } = null!;
        public string? BanContent { get; set; }
        public int BanDate { get; set; }
        public string? BanReason { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class IpbconvergeLocal
    {
        public string ConvergeApiCode { get; set; } = null!;
        public int ConvergeProductId { get; set; }
        public int ConvergeAdded { get; set; }
        public string ConvergeIpAddress { get; set; } = null!;
        public string ConvergeUrl { get; set; } = null!;
        public int ConvergeActive { get; set; }
        public string ConvergeHttpUser { get; set; } = null!;
        public string ConvergeHttpPass { get; set; } = null!;
    }
}

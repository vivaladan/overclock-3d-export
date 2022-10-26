namespace Overclock3D.Database.Models
{
    public partial class IpbdnamesChange
    {
        public int DnameId { get; set; }
        public int DnameMemberId { get; set; }
        public int DnameDate { get; set; }
        public string DnameIpAddress { get; set; } = null!;
        public string DnamePrevious { get; set; } = null!;
        public string DnameCurrent { get; set; } = null!;
    }
}

namespace Overclock3D.Database.Models
{
    public partial class IpbadminLog
    {
        public long Id { get; set; }
        public int? MemberId { get; set; }
        public int? Ctime { get; set; }
        public string? Note { get; set; }
        public string? IpAddress { get; set; }
        public string Appcomponent { get; set; } = null!;
        public string Module { get; set; } = null!;
        public string Section { get; set; } = null!;
        public string Do { get; set; } = null!;
    }
}

namespace Overclock3D.Database.Models
{
    public partial class IpbspiderLog
    {
        public int Sid { get; set; }
        public string Bot { get; set; } = null!;
        public string? QueryString { get; set; }
        public int EntryDate { get; set; }
        public string IpAddress { get; set; } = null!;
        public string? RequestAddr { get; set; }
    }
}

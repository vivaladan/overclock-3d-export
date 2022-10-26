namespace Overclock3D.Database.Models
{
    public partial class IpbmailErrorLog
    {
        public int MlogId { get; set; }
        public int MlogDate { get; set; }
        public string MlogTo { get; set; } = null!;
        public string MlogFrom { get; set; } = null!;
        public string MlogSubject { get; set; } = null!;
        public string MlogContent { get; set; } = null!;
        public string? MlogMsg { get; set; }
        public string MlogCode { get; set; } = null!;
        public string? MlogSmtpMsg { get; set; }
    }
}

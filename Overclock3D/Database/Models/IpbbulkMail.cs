namespace Overclock3D.Database.Models
{
    public partial class IpbbulkMail
    {
        public int MailId { get; set; }
        public string MailSubject { get; set; } = null!;
        public string MailContent { get; set; } = null!;
        public string? MailGroups { get; set; }
        public string? MailOpts { get; set; }
        public int MailStart { get; set; }
        public int MailUpdated { get; set; }
        public int MailSentto { get; set; }
        public bool MailActive { get; set; }
        public short MailPergo { get; set; }
    }
}

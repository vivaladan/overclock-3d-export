namespace Overclock3D.Database.Models
{
    public partial class IpbmailQueue
    {
        public int MailId { get; set; }
        public int MailDate { get; set; }
        public string MailTo { get; set; } = null!;
        public string MailFrom { get; set; } = null!;
        public string? MailSubject { get; set; }
        public string? MailContent { get; set; }
        public int MailHtmlOn { get; set; }
        public string? MailCc { get; set; }
    }
}

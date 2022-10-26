namespace Overclock3D.Database.Models
{
    public partial class Ipbcaptcha
    {
        public string CaptchaUniqueId { get; set; } = null!;
        public string CaptchaString { get; set; } = null!;
        public string CaptchaIpaddress { get; set; } = null!;
        public int CaptchaDate { get; set; }
    }
}

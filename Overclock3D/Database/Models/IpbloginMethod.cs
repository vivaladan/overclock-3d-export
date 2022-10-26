namespace Overclock3D.Database.Models
{
    public partial class IpbloginMethod
    {
        public int LoginId { get; set; }
        public string LoginTitle { get; set; } = null!;
        public string LoginDescription { get; set; } = null!;
        public string LoginFolderName { get; set; } = null!;
        public string LoginMaintainUrl { get; set; } = null!;
        public string LoginRegisterUrl { get; set; } = null!;
        public string? LoginAltLoginHtml { get; set; }
        public string? LoginAltAcpHtml { get; set; }
        public int LoginSettings { get; set; }
        public int LoginEnabled { get; set; }
        public int LoginSafemode { get; set; }
        public int LoginReplaceForm { get; set; }
        public string LoginUserId { get; set; } = null!;
        public string LoginLoginUrl { get; set; } = null!;
        public string LoginLogoutUrl { get; set; } = null!;
        public short LoginOrder { get; set; }
        public string? LoginCustomConfig { get; set; }
    }
}

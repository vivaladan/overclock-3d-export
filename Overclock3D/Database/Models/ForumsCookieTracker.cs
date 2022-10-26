namespace Overclock3D.Database.Models
{
    public partial class ForumsCookieTracker
    {
        public int Id { get; set; }
        public string? CookieHash { get; set; }
        public string? Ipaddress { get; set; }
        public int? Userid { get; set; }
        public string? UserAgent { get; set; }
        public string? Browser { get; set; }
        public string? BrowserVersion { get; set; }
        public string? Platform { get; set; }
        public string? Os { get; set; }
        public string? Language { get; set; }
        public int? Dateline { get; set; }
        public string? Username { get; set; }
    }
}

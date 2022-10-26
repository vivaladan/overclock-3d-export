namespace Overclock3D.Database.Models
{
    public partial class ForumsMatchReport
    {
        public int Matchid { get; set; }
        public int? Userid { get; set; }
        public int? MatchUserid { get; set; }
        public string? CookieHash { get; set; }
        public string? Ipaddress { get; set; }
        public string? MatchUsername { get; set; }
        public string? Username { get; set; }
        public int? Dateline { get; set; }
    }
}

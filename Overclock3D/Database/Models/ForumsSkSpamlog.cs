namespace Overclock3D.Database.Models
{
    public partial class ForumsSkSpamlog
    {
        public int Id { get; set; }
        public int? Userid { get; set; }
        public int? Dateline { get; set; }
        public string? Ip { get; set; }
        public string? Useragent { get; set; }
        public string? Type { get; set; }
        public string? Evidence { get; set; }
    }
}

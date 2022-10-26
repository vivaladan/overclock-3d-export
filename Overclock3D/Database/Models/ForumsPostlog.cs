namespace Overclock3D.Database.Models
{
    public partial class ForumsPostlog
    {
        public uint Postid { get; set; }
        public string Useragent { get; set; } = null!;
        public uint Ip { get; set; }
        public uint Dateline { get; set; }
    }
}

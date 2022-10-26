namespace Overclock3D.Database.Models
{
    public partial class ForumsPostedithistory
    {
        public uint Postedithistoryid { get; set; }
        public uint Postid { get; set; }
        public uint Userid { get; set; }
        public string Username { get; set; } = null!;
        public string Title { get; set; } = null!;
        public uint Iconid { get; set; }
        public uint Dateline { get; set; }
        public string Reason { get; set; } = null!;
        public short Original { get; set; }
        public string? Pagetext { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsGroupmessage
    {
        public uint Gmid { get; set; }
        public uint Discussionid { get; set; }
        public uint Postuserid { get; set; }
        public string Postusername { get; set; } = null!;
        public uint Dateline { get; set; }
        public string State { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? Pagetext { get; set; }
        public uint Ipaddress { get; set; }
        public ushort Allowsmilie { get; set; }
        public uint Reportthreadid { get; set; }
    }
}

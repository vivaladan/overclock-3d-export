namespace Overclock3D.Database.Models
{
    public partial class ForumsModeratorlog
    {
        public uint Moderatorlogid { get; set; }
        public uint Dateline { get; set; }
        public uint Userid { get; set; }
        public ushort Forumid { get; set; }
        public uint Threadid { get; set; }
        public uint Postid { get; set; }
        public uint Pollid { get; set; }
        public uint Attachmentid { get; set; }
        public string Action { get; set; } = null!;
        public ushort Type { get; set; }
        public string Threadtitle { get; set; } = null!;
        public string? Ipaddress { get; set; }
        public string Product { get; set; } = null!;
        public uint Id1 { get; set; }
        public uint Id2 { get; set; }
        public uint Id3 { get; set; }
        public uint Id4 { get; set; }
        public uint Id5 { get; set; }
    }
}

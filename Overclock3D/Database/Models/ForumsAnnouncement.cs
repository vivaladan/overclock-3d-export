namespace Overclock3D.Database.Models
{
    public partial class ForumsAnnouncement
    {
        public ushort Announcementid { get; set; }
        public string Title { get; set; } = null!;
        public uint Userid { get; set; }
        public uint Startdate { get; set; }
        public uint Enddate { get; set; }
        public string? Pagetext { get; set; }
        public short Forumid { get; set; }
        public uint Views { get; set; }
        public uint Announcementoptions { get; set; }
    }
}

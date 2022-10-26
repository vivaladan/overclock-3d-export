namespace Overclock3D.Database.Models
{
    public partial class ForumsRssfeed
    {
        public uint Rssfeedid { get; set; }
        public string Title { get; set; } = null!;
        public string? Url { get; set; }
        public ushort Port { get; set; }
        public ushort Ttl { get; set; }
        public short Maxresults { get; set; }
        public uint Userid { get; set; }
        public ushort Forumid { get; set; }
        public string Prefixid { get; set; } = null!;
        public ushort Iconid { get; set; }
        public string? Titletemplate { get; set; }
        public string? Bodytemplate { get; set; }
        public string? Searchwords { get; set; }
        public string Itemtype { get; set; } = null!;
        public ushort Threadactiondelay { get; set; }
        public uint Endannouncement { get; set; }
        public uint Options { get; set; }
        public uint Lastrun { get; set; }
    }
}

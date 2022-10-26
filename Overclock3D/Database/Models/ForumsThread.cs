namespace Overclock3D.Database.Models
{
    public partial class ForumsThread
    {
        public uint Threadid { get; set; }
        public string Title { get; set; } = null!;
        public string Prefixid { get; set; } = null!;
        public uint Firstpostid { get; set; }
        public uint Lastpostid { get; set; }
        public uint Lastpost { get; set; }
        public ushort Forumid { get; set; }
        public uint Pollid { get; set; }
        public short Open { get; set; }
        public uint Replycount { get; set; }
        public uint Hiddencount { get; set; }
        public uint Deletedcount { get; set; }
        public string Postusername { get; set; } = null!;
        public uint Postuserid { get; set; }
        public string Lastposter { get; set; } = null!;
        public uint Dateline { get; set; }
        public uint Views { get; set; }
        public ushort Iconid { get; set; }
        public string Notes { get; set; } = null!;
        public short Visible { get; set; }
        public short Sticky { get; set; }
        public ushort Votenum { get; set; }
        public ushort Votetotal { get; set; }
        public ushort Attach { get; set; }
        public string Similar { get; set; } = null!;
        public string? Taglist { get; set; }
        public long Importthreadid { get; set; }
        public long Importforumid { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsForum
    {
        public ushort Forumid { get; set; }
        public ushort Styleid { get; set; }
        public string Title { get; set; } = null!;
        public string TitleClean { get; set; } = null!;
        public string? Description { get; set; }
        public string? DescriptionClean { get; set; }
        public uint Options { get; set; }
        public byte Showprivate { get; set; }
        public short Displayorder { get; set; }
        public uint Replycount { get; set; }
        public int Lastpost { get; set; }
        public string Lastposter { get; set; } = null!;
        public uint Lastpostid { get; set; }
        public string Lastthread { get; set; } = null!;
        public uint Lastthreadid { get; set; }
        public short Lasticonid { get; set; }
        public string Lastprefixid { get; set; } = null!;
        public uint Threadcount { get; set; }
        public short Daysprune { get; set; }
        public string? Newpostemail { get; set; }
        public string? Newthreademail { get; set; }
        public short Parentid { get; set; }
        public string Parentlist { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Link { get; set; } = null!;
        public string? Childlist { get; set; }
        public string Defaultsortfield { get; set; } = null!;
        public string Defaultsortorder { get; set; } = null!;
        public string Imageprefix { get; set; } = null!;
        public long Importforumid { get; set; }
        public long Importcategoryid { get; set; }
    }
}

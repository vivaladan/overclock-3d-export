namespace Overclock3D.Database.Models
{
    public partial class Ipbpost
    {
        public int Pid { get; set; }
        public bool? AppendEdit { get; set; }
        public int? EditTime { get; set; }
        public int AuthorId { get; set; }
        public string? AuthorName { get; set; }
        public bool UseSig { get; set; }
        public bool UseEmo { get; set; }
        public string IpAddress { get; set; } = null!;
        public int? PostDate { get; set; }
        public short? IconId { get; set; }
        public string? Post { get; set; }
        public bool Queued { get; set; }
        public int TopicId { get; set; }
        public string? PostTitle { get; set; }
        public bool? NewTopic { get; set; }
        public string? EditName { get; set; }
        public string PostKey { get; set; } = null!;
        public short PostHtmlstate { get; set; }
        public string PostEditReason { get; set; } = null!;
        public uint PostBwoptions { get; set; }
        public int PdeleteTime { get; set; }
        public int PostFieldInt { get; set; }
        public string? PostFieldT1 { get; set; }
        public string? PostFieldT2 { get; set; }
    }
}

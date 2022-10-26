namespace Overclock3D.Database.Models
{
    public partial class Ipbsession
    {
        public string Id { get; set; } = null!;
        public string? MemberName { get; set; }
        public string SeoName { get; set; } = null!;
        public int MemberId { get; set; }
        public string? IpAddress { get; set; }
        public string Browser { get; set; } = null!;
        public int? RunningTime { get; set; }
        public bool? LoginType { get; set; }
        public short? MemberGroup { get; set; }
        public bool InError { get; set; }
        public string Location1Type { get; set; } = null!;
        public int Location1Id { get; set; }
        public string Location2Type { get; set; } = null!;
        public int Location2Id { get; set; }
        public string Location3Type { get; set; } = null!;
        public int Location3Id { get; set; }
        public string CurrentAppcomponent { get; set; } = null!;
        public string CurrentModule { get; set; } = null!;
        public string CurrentSection { get; set; } = null!;
        public string UagentKey { get; set; } = null!;
        public string UagentVersion { get; set; } = null!;
        public string UagentType { get; set; } = null!;
        public int UagentBypass { get; set; }
        public int SearchThreadId { get; set; }
        public int SearchThreadTime { get; set; }
        public int SessionMsgId { get; set; }
    }
}

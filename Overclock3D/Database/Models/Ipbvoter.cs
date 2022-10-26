namespace Overclock3D.Database.Models
{
    public partial class Ipbvoter
    {
        public int Vid { get; set; }
        public string IpAddress { get; set; } = null!;
        public int VoteDate { get; set; }
        public int Tid { get; set; }
        public int MemberId { get; set; }
        public short ForumId { get; set; }
        public string? MemberChoices { get; set; }
    }
}

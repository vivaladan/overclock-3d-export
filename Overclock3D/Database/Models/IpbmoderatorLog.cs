namespace Overclock3D.Database.Models
{
    public partial class IpbmoderatorLog
    {
        public int Id { get; set; }
        public int? ForumId { get; set; }
        public int TopicId { get; set; }
        public int? PostId { get; set; }
        public int MemberId { get; set; }
        public string MemberName { get; set; } = null!;
        public string IpAddress { get; set; } = null!;
        public string? HttpReferer { get; set; }
        public int? Ctime { get; set; }
        public string? TopicTitle { get; set; }
        public string? Action { get; set; }
        public string? QueryString { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class Ipbpoll
    {
        public int Pid { get; set; }
        public int Tid { get; set; }
        public int? StartDate { get; set; }
        public string? Choices { get; set; }
        public int StarterId { get; set; }
        public short Votes { get; set; }
        public short ForumId { get; set; }
        public string? PollQuestion { get; set; }
        public bool PollOnly { get; set; }
        public int PollViewVoters { get; set; }
    }
}

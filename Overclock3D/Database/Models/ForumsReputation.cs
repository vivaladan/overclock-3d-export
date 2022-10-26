namespace Overclock3D.Database.Models
{
    public partial class ForumsReputation
    {
        public uint Reputationid { get; set; }
        public uint Postid { get; set; }
        public uint Userid { get; set; }
        public int Reputation { get; set; }
        public uint Whoadded { get; set; }
        public string? Reason { get; set; }
        public uint Dateline { get; set; }
    }
}

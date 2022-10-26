namespace Overclock3D.Database.Models
{
    public partial class ForumsGroupmessageHash
    {
        public uint Postuserid { get; set; }
        public uint Groupid { get; set; }
        public string Dupehash { get; set; } = null!;
        public uint Dateline { get; set; }
    }
}

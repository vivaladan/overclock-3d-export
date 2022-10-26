namespace Overclock3D.Database.Models
{
    public partial class ForumsVisitormessageHash
    {
        public uint Postuserid { get; set; }
        public uint Userid { get; set; }
        public string Dupehash { get; set; } = null!;
        public uint Dateline { get; set; }
    }
}

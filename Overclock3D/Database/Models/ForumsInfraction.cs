namespace Overclock3D.Database.Models
{
    public partial class ForumsInfraction
    {
        public uint Infractionid { get; set; }
        public uint Infractionlevelid { get; set; }
        public uint Postid { get; set; }
        public uint Userid { get; set; }
        public uint Whoadded { get; set; }
        public uint Points { get; set; }
        public uint Dateline { get; set; }
        public string Note { get; set; } = null!;
        public ushort Action { get; set; }
        public uint Actiondateline { get; set; }
        public uint Actionuserid { get; set; }
        public string Actionreason { get; set; } = null!;
        public uint Expires { get; set; }
        public uint Threadid { get; set; }
        public string Customreason { get; set; } = null!;
    }
}

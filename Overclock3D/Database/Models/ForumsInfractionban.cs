namespace Overclock3D.Database.Models
{
    public partial class ForumsInfractionban
    {
        public uint Infractionbanid { get; set; }
        public int Usergroupid { get; set; }
        public uint Banusergroupid { get; set; }
        public uint Amount { get; set; }
        public string Period { get; set; } = null!;
        public string Method { get; set; } = null!;
    }
}

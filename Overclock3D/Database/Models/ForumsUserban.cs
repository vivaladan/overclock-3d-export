namespace Overclock3D.Database.Models
{
    public partial class ForumsUserban
    {
        public uint Userid { get; set; }
        public ushort Usergroupid { get; set; }
        public ushort Displaygroupid { get; set; }
        public string Usertitle { get; set; } = null!;
        public short Customtitle { get; set; }
        public uint Adminid { get; set; }
        public uint Bandate { get; set; }
        public uint Liftdate { get; set; }
        public string Reason { get; set; } = null!;
    }
}

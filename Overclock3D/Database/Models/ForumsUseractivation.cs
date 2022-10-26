namespace Overclock3D.Database.Models
{
    public partial class ForumsUseractivation
    {
        public uint Useractivationid { get; set; }
        public uint Userid { get; set; }
        public uint Dateline { get; set; }
        public string Activationid { get; set; } = null!;
        public ushort Type { get; set; }
        public ushort Usergroupid { get; set; }
        public ushort Emailchange { get; set; }
    }
}

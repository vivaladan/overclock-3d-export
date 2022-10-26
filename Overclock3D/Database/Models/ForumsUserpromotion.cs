namespace Overclock3D.Database.Models
{
    public partial class ForumsUserpromotion
    {
        public uint Userpromotionid { get; set; }
        public uint Usergroupid { get; set; }
        public uint Joinusergroupid { get; set; }
        public int Reputation { get; set; }
        public uint Date { get; set; }
        public uint Posts { get; set; }
        public short Strategy { get; set; }
        public short Type { get; set; }
    }
}

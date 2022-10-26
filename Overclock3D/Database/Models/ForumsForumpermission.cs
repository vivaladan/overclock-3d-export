namespace Overclock3D.Database.Models
{
    public partial class ForumsForumpermission
    {
        public uint Forumpermissionid { get; set; }
        public ushort Forumid { get; set; }
        public ushort Usergroupid { get; set; }
        public uint Forumpermissions { get; set; }
    }
}

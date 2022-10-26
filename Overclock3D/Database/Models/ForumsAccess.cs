namespace Overclock3D.Database.Models
{
    public partial class ForumsAccess
    {
        public uint Userid { get; set; }
        public ushort Forumid { get; set; }
        public ushort Accessmask { get; set; }
    }
}

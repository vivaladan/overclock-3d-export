namespace Overclock3D.Database.Models
{
    public partial class ForumsModerator
    {
        public ushort Moderatorid { get; set; }
        public uint Userid { get; set; }
        public short Forumid { get; set; }
        public uint Permissions { get; set; }
        public uint Permissions2 { get; set; }
        public string Importmoderatorid { get; set; } = null!;
    }
}

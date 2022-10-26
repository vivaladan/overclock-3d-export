namespace Overclock3D.Database.Models
{
    public partial class ForumsSocialgroupmember
    {
        public uint Userid { get; set; }
        public uint Groupid { get; set; }
        public uint Dateline { get; set; }
        public string Type { get; set; } = null!;
    }
}

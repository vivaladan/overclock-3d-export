namespace Overclock3D.Database.Models
{
    public partial class ForumsAdminhelp
    {
        public uint Adminhelpid { get; set; }
        public string Script { get; set; } = null!;
        public string Action { get; set; } = null!;
        public string Optionname { get; set; } = null!;
        public ushort Displayorder { get; set; }
        public ushort Volatile { get; set; }
        public string Product { get; set; } = null!;
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsNotice
    {
        public uint Noticeid { get; set; }
        public string Title { get; set; } = null!;
        public uint Displayorder { get; set; }
        public ushort Persistent { get; set; }
        public ushort Active { get; set; }
        public ushort Dismissible { get; set; }
    }
}

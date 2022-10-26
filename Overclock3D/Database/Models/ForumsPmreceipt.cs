namespace Overclock3D.Database.Models
{
    public partial class ForumsPmreceipt
    {
        public uint Pmid { get; set; }
        public uint Userid { get; set; }
        public uint Touserid { get; set; }
        public string Tousername { get; set; } = null!;
        public string Title { get; set; } = null!;
        public uint Sendtime { get; set; }
        public uint Readtime { get; set; }
        public ushort Denied { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsPm
    {
        public uint Pmid { get; set; }
        public uint Pmtextid { get; set; }
        public uint Userid { get; set; }
        public short Folderid { get; set; }
        public ushort Messageread { get; set; }
        public uint Parentpmid { get; set; }
        public string Importpmid { get; set; } = null!;
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsPmtext
    {
        public uint Pmtextid { get; set; }
        public uint Fromuserid { get; set; }
        public string Fromusername { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? Message { get; set; }
        public string? Touserarray { get; set; }
        public ushort Iconid { get; set; }
        public uint Dateline { get; set; }
        public ushort Showsignature { get; set; }
        public ushort Allowsmilie { get; set; }
        public uint Reportthreadid { get; set; }
        public string Importpmid { get; set; } = null!;
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsPost
    {
        public uint Postid { get; set; }
        public uint Threadid { get; set; }
        public uint Parentid { get; set; }
        public string Username { get; set; } = null!;
        public uint Userid { get; set; }
        public string Title { get; set; } = null!;
        public uint Dateline { get; set; }
        public string? Pagetext { get; set; }
        public short Allowsmilie { get; set; }
        public short Showsignature { get; set; }
        public string? Ipaddress { get; set; }
        public ushort Iconid { get; set; }
        public short Visible { get; set; }
        public ushort Attach { get; set; }
        public ushort Infraction { get; set; }
        public uint Reportthreadid { get; set; }
        public long Importthreadid { get; set; }
        public long Importpostid { get; set; }
    }
}

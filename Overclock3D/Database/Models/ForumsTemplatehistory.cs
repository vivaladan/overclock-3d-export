namespace Overclock3D.Database.Models
{
    public partial class ForumsTemplatehistory
    {
        public uint Templatehistoryid { get; set; }
        public ushort Styleid { get; set; }
        public string Title { get; set; } = null!;
        public string? Template { get; set; }
        public uint Dateline { get; set; }
        public string Username { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string Comment { get; set; } = null!;
    }
}

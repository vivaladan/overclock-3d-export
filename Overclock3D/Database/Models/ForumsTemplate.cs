namespace Overclock3D.Database.Models
{
    public partial class ForumsTemplate
    {
        public uint Templateid { get; set; }
        public short Styleid { get; set; }
        public string Title { get; set; } = null!;
        public string? Template { get; set; }
        public string? TemplateUn { get; set; }
        public string Templatetype { get; set; } = null!;
        public uint Dateline { get; set; }
        public string Username { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string Product { get; set; } = null!;
    }
}

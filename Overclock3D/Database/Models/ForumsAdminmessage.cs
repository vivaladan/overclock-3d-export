namespace Overclock3D.Database.Models
{
    public partial class ForumsAdminmessage
    {
        public uint Adminmessageid { get; set; }
        public string Varname { get; set; } = null!;
        public ushort Dismissable { get; set; }
        public string Script { get; set; } = null!;
        public string Action { get; set; } = null!;
        public string? Execurl { get; set; }
        public string Method { get; set; } = null!;
        public uint Dateline { get; set; }
        public string Status { get; set; } = null!;
        public uint Statususerid { get; set; }
    }
}

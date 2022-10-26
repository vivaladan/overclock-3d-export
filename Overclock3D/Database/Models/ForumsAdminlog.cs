namespace Overclock3D.Database.Models
{
    public partial class ForumsAdminlog
    {
        public uint Adminlogid { get; set; }
        public uint Userid { get; set; }
        public uint Dateline { get; set; }
        public string Script { get; set; } = null!;
        public string Action { get; set; } = null!;
        public string Extrainfo { get; set; } = null!;
        public string? Ipaddress { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsAdministrator
    {
        public uint Userid { get; set; }
        public uint Adminpermissions { get; set; }
        public string? Navprefs { get; set; }
        public string Cssprefs { get; set; } = null!;
        public string? Notes { get; set; }
        public string? Dismissednews { get; set; }
        public ushort Languageid { get; set; }
        public uint? Dtogarageperms { get; set; }
    }
}

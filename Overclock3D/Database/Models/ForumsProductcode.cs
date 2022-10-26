namespace Overclock3D.Database.Models
{
    public partial class ForumsProductcode
    {
        public uint Productcodeid { get; set; }
        public string Productid { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string? Installcode { get; set; }
        public string? Uninstallcode { get; set; }
    }
}

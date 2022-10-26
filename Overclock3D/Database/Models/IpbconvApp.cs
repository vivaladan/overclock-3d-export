namespace Overclock3D.Database.Models
{
    public partial class IpbconvApp
    {
        public int AppId { get; set; }
        public string Sw { get; set; } = null!;
        public string AppKey { get; set; } = null!;
        public string Name { get; set; } = null!;
        public bool Login { get; set; }
        public int Parent { get; set; }
        public string DbDriver { get; set; } = null!;
        public string DbHost { get; set; } = null!;
        public string DbUser { get; set; } = null!;
        public string DbPass { get; set; } = null!;
        public string DbDb { get; set; } = null!;
        public string DbPrefix { get; set; } = null!;
        public string DbCharset { get; set; } = null!;
    }
}

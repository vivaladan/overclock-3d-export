namespace Overclock3D.Database.Models
{
    public partial class IpbspamServiceLog
    {
        public uint Id { get; set; }
        public uint LogDate { get; set; }
        public ushort LogCode { get; set; }
        public string LogMsg { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public string IpAddress { get; set; } = null!;
    }
}

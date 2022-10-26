namespace Overclock3D.Database.Models
{
    public partial class IpbapiLog
    {
        public uint ApiLogId { get; set; }
        public string ApiLogKey { get; set; } = null!;
        public string ApiLogIp { get; set; } = null!;
        public int ApiLogDate { get; set; }
        public string ApiLogQuery { get; set; } = null!;
        public byte ApiLogAllowed { get; set; }
    }
}

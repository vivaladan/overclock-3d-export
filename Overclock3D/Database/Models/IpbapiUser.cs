namespace Overclock3D.Database.Models
{
    public partial class IpbapiUser
    {
        public uint ApiUserId { get; set; }
        public string ApiUserKey { get; set; } = null!;
        public string ApiUserName { get; set; } = null!;
        public string ApiUserPerms { get; set; } = null!;
        public string ApiUserIp { get; set; } = null!;
    }
}

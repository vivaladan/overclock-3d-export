namespace Overclock3D.Database.Models
{
    public partial class IpbpermissionIndex
    {
        public uint PermId { get; set; }
        public string App { get; set; } = null!;
        public string PermType { get; set; } = null!;
        public uint PermTypeId { get; set; }
        public string PermView { get; set; } = null!;
        public string? Perm2 { get; set; }
        public string? Perm3 { get; set; }
        public string? Perm4 { get; set; }
        public string? Perm5 { get; set; }
        public string? Perm6 { get; set; }
        public string? Perm7 { get; set; }
        public bool OwnerOnly { get; set; }
        public bool FriendOnly { get; set; }
        public string? AuthorizedUsers { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class IpbcoreHook
    {
        public uint HookId { get; set; }
        public bool HookEnabled { get; set; }
        public string? HookName { get; set; }
        public string? HookDesc { get; set; }
        public string? HookAuthor { get; set; }
        public string? HookEmail { get; set; }
        public string? HookWebsite { get; set; }
        public string? HookUpdateCheck { get; set; }
        public string? HookRequirements { get; set; }
        public string? HookVersionHuman { get; set; }
        public string HookVersionLong { get; set; } = null!;
        public int HookInstalled { get; set; }
        public int HookUpdated { get; set; }
        public int HookPosition { get; set; }
        public string? HookExtraData { get; set; }
        public string? HookKey { get; set; }
        public string? HookGlobalCaches { get; set; }
    }
}

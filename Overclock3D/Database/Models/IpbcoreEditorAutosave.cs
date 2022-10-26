namespace Overclock3D.Database.Models
{
    public partial class IpbcoreEditorAutosave
    {
        public string EasKey { get; set; } = null!;
        public uint EasMemberId { get; set; }
        public string EasApp { get; set; } = null!;
        public string EasSection { get; set; } = null!;
        public uint EasUpdated { get; set; }
        public string? EasContent { get; set; }
    }
}

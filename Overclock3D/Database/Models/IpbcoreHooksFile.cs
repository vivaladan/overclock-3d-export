namespace Overclock3D.Database.Models
{
    public partial class IpbcoreHooksFile
    {
        public int HookFileId { get; set; }
        public int HookHookId { get; set; }
        public string? HookFileStored { get; set; }
        public string? HookFileReal { get; set; }
        public string? HookType { get; set; }
        public string? HookClassname { get; set; }
        public string? HookData { get; set; }
        public string? HooksSource { get; set; }
    }
}

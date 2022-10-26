namespace Overclock3D.Database.Models
{
    public partial class IpbskinCollection
    {
        public int SetId { get; set; }
        public string SetName { get; set; } = null!;
        public string SetKey { get; set; } = null!;
        public int SetParentId { get; set; }
        public string? SetParentArray { get; set; }
        public string? SetChildArray { get; set; }
        public string? SetPermissions { get; set; }
        public int SetIsDefault { get; set; }
        public string SetAuthorName { get; set; } = null!;
        public string SetAuthorUrl { get; set; } = null!;
        public string SetImageDir { get; set; } = null!;
        public string SetEmoDir { get; set; } = null!;
        public int SetCssInline { get; set; }
        public string? SetCssGroups { get; set; }
        public int SetAdded { get; set; }
        public int SetUpdated { get; set; }
        public string SetOutputFormat { get; set; } = null!;
        public string? SetLockedUagent { get; set; }
        public int SetHideFromList { get; set; }
        public int SetMinify { get; set; }
        public string SetMasterKey { get; set; } = null!;
        public int SetOrder { get; set; }
        public int SetBySkinGen { get; set; }
        public string? SetSkinGenData { get; set; }
    }
}

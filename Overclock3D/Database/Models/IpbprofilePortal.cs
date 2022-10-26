namespace Overclock3D.Database.Models
{
    public partial class IpbprofilePortal
    {
        public int PpMemberId { get; set; }
        public string? PpLastVisitors { get; set; }
        public uint PpRatingHits { get; set; }
        public uint PpRatingValue { get; set; }
        public uint PpRatingReal { get; set; }
        public string PpMainPhoto { get; set; } = null!;
        public uint PpMainWidth { get; set; }
        public uint PpMainHeight { get; set; }
        public string PpThumbPhoto { get; set; } = null!;
        public uint PpThumbWidth { get; set; }
        public uint PpThumbHeight { get; set; }
        public bool PpSettingModerateComments { get; set; }
        public bool PpSettingModerateFriends { get; set; }
        public int PpSettingCountFriends { get; set; }
        public int PpSettingCountComments { get; set; }
        public bool PpSettingCountVisitors { get; set; }
        public string? PpAboutMe { get; set; }
        public int PpReputationPoints { get; set; }
        public string PpGravatar { get; set; } = null!;
        public string PpPhotoType { get; set; } = null!;
        public string? Notes { get; set; }
        public string? Signature { get; set; }
        public string? AvatarLocation { get; set; }
        public string AvatarSize { get; set; } = null!;
        public string? AvatarType { get; set; }
        public string? PconversationFilters { get; set; }
        public string? FbPhoto { get; set; }
        public string? FbPhotoThumb { get; set; }
        public uint FbBwoptions { get; set; }
        public string? TcLastSidImport { get; set; }
        public string? TcPhoto { get; set; }
        public uint TcBwoptions { get; set; }
        public string? PpCustomization { get; set; }
    }
}

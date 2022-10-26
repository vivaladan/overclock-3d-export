namespace Overclock3D.Database.Models
{
    public partial class IpbpfieldsDatum
    {
        public short PfId { get; set; }
        public string PfTitle { get; set; } = null!;
        public string PfDesc { get; set; } = null!;
        public string? PfContent { get; set; }
        public string PfType { get; set; } = null!;
        public bool PfNotNull { get; set; }
        public bool PfMemberHide { get; set; }
        public short PfMaxInput { get; set; }
        public bool PfMemberEdit { get; set; }
        public short PfPosition { get; set; }
        public bool PfShowOnReg { get; set; }
        public string? PfInputFormat { get; set; }
        public bool PfAdminOnly { get; set; }
        public string? PfTopicFormat { get; set; }
        public uint PfGroupId { get; set; }
        public string? PfIcon { get; set; }
        public string? PfKey { get; set; }
        public string PfSearchType { get; set; } = null!;
        public bool PfFiltering { get; set; }
    }
}

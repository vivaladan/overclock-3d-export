namespace Overclock3D.Database.Models
{
    public partial class IpbcoreTag
    {
        public ulong TagId { get; set; }
        public string TagAaiLookup { get; set; } = null!;
        public string TagAapLookup { get; set; } = null!;
        public string TagMetaApp { get; set; } = null!;
        public string TagMetaArea { get; set; } = null!;
        public uint TagMetaId { get; set; }
        public uint TagMetaParentId { get; set; }
        public uint TagMemberId { get; set; }
        public uint TagAdded { get; set; }
        public uint TagPrefix { get; set; }
        public string? TagText { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class IpbcoreTagsPerm
    {
        public string TagPermAaiLookup { get; set; } = null!;
        public string TagPermAapLookup { get; set; } = null!;
        public string TagPermText { get; set; } = null!;
        public uint TagPermVisible { get; set; }
    }
}

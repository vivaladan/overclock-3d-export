namespace Overclock3D.Database.Models
{
    public partial class ForumsBbcode
    {
        public ushort Bbcodeid { get; set; }
        public string Bbcodetag { get; set; } = null!;
        public string? Bbcodereplacement { get; set; }
        public string Bbcodeexample { get; set; } = null!;
        public string? Bbcodeexplanation { get; set; }
        public short Twoparams { get; set; }
        public string Title { get; set; } = null!;
        public string Buttonimage { get; set; } = null!;
        public uint Options { get; set; }
    }
}

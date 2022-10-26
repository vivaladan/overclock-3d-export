namespace Overclock3D.Database.Models
{
    public partial class ForumsImpexerror
    {
        public ulong Errorid { get; set; }
        public string Errortype { get; set; } = null!;
        public string Classnumber { get; set; } = null!;
        public long Importid { get; set; }
        public string? Error { get; set; }
        public string? Remedy { get; set; }
    }
}

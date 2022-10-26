namespace Overclock3D.Database.Models
{
    public partial class ForumsUsernote
    {
        public uint Usernoteid { get; set; }
        public uint Userid { get; set; }
        public uint Posterid { get; set; }
        public string Username { get; set; } = null!;
        public uint Dateline { get; set; }
        public string? Message { get; set; }
        public string Title { get; set; } = null!;
        public short Allowsmilies { get; set; }
        public long Importusernoteid { get; set; }
    }
}

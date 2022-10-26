namespace Overclock3D.Database.Models
{
    public partial class ForumsUserchangelog
    {
        public uint Changeid { get; set; }
        public uint Userid { get; set; }
        public string Fieldname { get; set; } = null!;
        public string Newvalue { get; set; } = null!;
        public string Oldvalue { get; set; } = null!;
        public uint Adminid { get; set; }
        public uint ChangeTime { get; set; }
        public string ChangeUniq { get; set; } = null!;
    }
}

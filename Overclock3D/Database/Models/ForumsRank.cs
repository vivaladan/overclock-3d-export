namespace Overclock3D.Database.Models
{
    public partial class ForumsRank
    {
        public ushort Rankid { get; set; }
        public uint Minposts { get; set; }
        public ushort Ranklevel { get; set; }
        public string? Rankimg { get; set; }
        public ushort Usergroupid { get; set; }
        public ushort Type { get; set; }
        public ushort Stack { get; set; }
        public ushort Display { get; set; }
        public long Importrankid { get; set; }
    }
}

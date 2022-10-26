namespace Overclock3D.Database.Models
{
    public partial class ForumsRsslog
    {
        public uint Rssfeedid { get; set; }
        public uint Itemid { get; set; }
        public string Itemtype { get; set; } = null!;
        public string Uniquehash { get; set; } = null!;
        public string Contenthash { get; set; } = null!;
        public uint Dateline { get; set; }
        public uint Threadactiontime { get; set; }
        public byte Threadactioncomplete { get; set; }
    }
}

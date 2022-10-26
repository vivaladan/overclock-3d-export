namespace Overclock3D.Database.Models
{
    public partial class ForumsPoll
    {
        public uint Pollid { get; set; }
        public string Question { get; set; } = null!;
        public uint Dateline { get; set; }
        public string? Options { get; set; }
        public string? Votes { get; set; }
        public short Active { get; set; }
        public ushort Numberoptions { get; set; }
        public ushort Timeout { get; set; }
        public ushort Multiple { get; set; }
        public ushort Voters { get; set; }
        public short Public { get; set; }
        public uint Lastvote { get; set; }
        public long Importpollid { get; set; }
    }
}

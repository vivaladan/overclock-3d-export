namespace Overclock3D.Database.Models
{
    public partial class ForumsCron
    {
        public uint Cronid { get; set; }
        public uint Nextrun { get; set; }
        public short Weekday { get; set; }
        public short Day { get; set; }
        public short Hour { get; set; }
        public string Minute { get; set; } = null!;
        public string Filename { get; set; } = null!;
        public short Loglevel { get; set; }
        public short Active { get; set; }
        public string Varname { get; set; } = null!;
        public ushort Volatile { get; set; }
        public string Product { get; set; } = null!;
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsEvent
    {
        public uint Eventid { get; set; }
        public uint Userid { get; set; }
        public string? Event { get; set; }
        public string Title { get; set; } = null!;
        public short Allowsmilies { get; set; }
        public short Recurring { get; set; }
        public string Recuroption { get; set; } = null!;
        public uint Calendarid { get; set; }
        public string? Customfields { get; set; }
        public short Visible { get; set; }
        public uint Dateline { get; set; }
        public decimal Utc { get; set; }
        public short Dst { get; set; }
        public uint DatelineFrom { get; set; }
        public uint DatelineTo { get; set; }
    }
}

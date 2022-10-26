namespace Overclock3D.Database.Models
{
    public partial class ForumsCalendar
    {
        public uint Calendarid { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public short Displayorder { get; set; }
        public string? Neweventemail { get; set; }
        public short Moderatenew { get; set; }
        public short Startofweek { get; set; }
        public uint Options { get; set; }
        public ushort Cutoff { get; set; }
        public ushort Eventcount { get; set; }
        public ushort Birthdaycount { get; set; }
        public ushort Startyear { get; set; }
        public ushort Endyear { get; set; }
        public uint Holidays { get; set; }
    }
}

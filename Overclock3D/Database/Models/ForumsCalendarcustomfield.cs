namespace Overclock3D.Database.Models
{
    public partial class ForumsCalendarcustomfield
    {
        public uint Calendarcustomfieldid { get; set; }
        public uint Calendarid { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? Options { get; set; }
        public short Allowentry { get; set; }
        public short Required { get; set; }
        public ushort Length { get; set; }
    }
}

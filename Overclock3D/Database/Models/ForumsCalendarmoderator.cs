namespace Overclock3D.Database.Models
{
    public partial class ForumsCalendarmoderator
    {
        public uint Calendarmoderatorid { get; set; }
        public uint Userid { get; set; }
        public uint Calendarid { get; set; }
        public short Neweventemail { get; set; }
        public uint Permissions { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsReminder
    {
        public uint Reminderid { get; set; }
        public uint Userid { get; set; }
        public string Title { get; set; } = null!;
        public string? Text { get; set; }
        public uint Duedate { get; set; }
        public ushort Adminonly { get; set; }
        public uint Completedby { get; set; }
        public uint Completedtime { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class IpbtaskManager
    {
        public int TaskId { get; set; }
        public string TaskTitle { get; set; } = null!;
        public string TaskFile { get; set; } = null!;
        public int TaskNextRun { get; set; }
        public short TaskWeekDay { get; set; }
        public short TaskMonthDay { get; set; }
        public short TaskHour { get; set; }
        public short TaskMinute { get; set; }
        public string TaskCronkey { get; set; } = null!;
        public bool TaskLog { get; set; }
        public string? TaskDescription { get; set; }
        public bool? TaskEnabled { get; set; }
        public string TaskKey { get; set; } = null!;
        public bool TaskSafemode { get; set; }
        public int TaskLocked { get; set; }
        public string TaskApplication { get; set; } = null!;
    }
}

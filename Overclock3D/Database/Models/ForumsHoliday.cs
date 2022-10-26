namespace Overclock3D.Database.Models
{
    public partial class ForumsHoliday
    {
        public uint Holidayid { get; set; }
        public string Varname { get; set; } = null!;
        public ushort Recurring { get; set; }
        public string Recuroption { get; set; } = null!;
        public short Allowsmilies { get; set; }
    }
}

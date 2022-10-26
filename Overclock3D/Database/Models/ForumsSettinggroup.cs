namespace Overclock3D.Database.Models
{
    public partial class ForumsSettinggroup
    {
        public string Grouptitle { get; set; } = null!;
        public ushort Displayorder { get; set; }
        public ushort Volatile { get; set; }
        public string Product { get; set; } = null!;
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsAdvSetting
    {
        public string Varname { get; set; } = null!;
        public string Grouptitle { get; set; } = null!;
        public string Value { get; set; } = null!;
        public string Defaultvalue { get; set; } = null!;
        public string Optioncode { get; set; } = null!;
        public ushort Displayorder { get; set; }
        public ushort Serialize { get; set; }
    }
}

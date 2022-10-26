namespace Overclock3D.Database.Models
{
    public partial class ForumsSetting
    {
        public string Varname { get; set; } = null!;
        public string Grouptitle { get; set; } = null!;
        public string? Value { get; set; }
        public string? Defaultvalue { get; set; }
        public string? Optioncode { get; set; }
        public ushort Displayorder { get; set; }
        public short Advanced { get; set; }
        public ushort Volatile { get; set; }
        public string Datatype { get; set; } = null!;
        public string Product { get; set; } = null!;
        public string? Validationcode { get; set; }
        public short Blacklist { get; set; }
    }
}

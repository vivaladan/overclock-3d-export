namespace Overclock3D.Database.Models
{
    public partial class ForumsStyle
    {
        public ushort Styleid { get; set; }
        public string Title { get; set; } = null!;
        public short Parentid { get; set; }
        public string Parentlist { get; set; } = null!;
        public string? Templatelist { get; set; }
        public string? Csscolors { get; set; }
        public string? Css { get; set; }
        public string? Stylevars { get; set; }
        public string? Replacements { get; set; }
        public string? Editorstyles { get; set; }
        public ushort Userselect { get; set; }
        public ushort Displayorder { get; set; }
        public long Importstyleid { get; set; }
    }
}

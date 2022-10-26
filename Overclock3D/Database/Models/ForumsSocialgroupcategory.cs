namespace Overclock3D.Database.Models
{
    public partial class ForumsSocialgroupcategory
    {
        public uint Socialgroupcategoryid { get; set; }
        public uint Creatoruserid { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public uint Displayorder { get; set; }
        public uint Lastupdate { get; set; }
        public uint? Groups { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsSocialgroup
    {
        public uint Groupid { get; set; }
        public uint Socialgroupcategoryid { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public uint Creatoruserid { get; set; }
        public uint Dateline { get; set; }
        public uint Members { get; set; }
        public uint Picturecount { get; set; }
        public uint Lastpost { get; set; }
        public string Lastposter { get; set; } = null!;
        public uint Lastposterid { get; set; }
        public uint Lastgmid { get; set; }
        public uint Visible { get; set; }
        public uint Deleted { get; set; }
        public uint Moderation { get; set; }
        public string Type { get; set; } = null!;
        public uint Moderatedmembers { get; set; }
        public uint Options { get; set; }
        public uint Lastdiscussionid { get; set; }
        public uint? Discussions { get; set; }
        public string Lastdiscussion { get; set; } = null!;
        public uint Lastupdate { get; set; }
        public uint Transferowner { get; set; }
    }
}

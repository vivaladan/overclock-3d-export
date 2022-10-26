namespace Overclock3D.Database.Models
{
    public partial class IpbskinUrlMapping
    {
        public int MapId { get; set; }
        public string MapTitle { get; set; } = null!;
        public string MapMatchType { get; set; } = null!;
        public string MapUrl { get; set; } = null!;
        public uint MapSkinSetId { get; set; }
        public uint MapDateAdded { get; set; }
    }
}

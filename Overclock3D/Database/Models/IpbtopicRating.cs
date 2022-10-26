namespace Overclock3D.Database.Models
{
    public partial class IpbtopicRating
    {
        public int RatingId { get; set; }
        public int RatingTid { get; set; }
        public int RatingMemberId { get; set; }
        public short RatingValue { get; set; }
        public string RatingIpAddress { get; set; } = null!;
    }
}

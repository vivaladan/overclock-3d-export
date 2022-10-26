namespace Overclock3D.Database.Models
{
    public partial class IpbprofileRating
    {
        public int RatingId { get; set; }
        public int RatingForMemberId { get; set; }
        public int RatingByMemberId { get; set; }
        public string RatingIpAddress { get; set; } = null!;
        public int RatingValue { get; set; }
    }
}

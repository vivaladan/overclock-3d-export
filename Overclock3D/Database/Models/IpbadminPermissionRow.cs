namespace Overclock3D.Database.Models
{
    public partial class IpbadminPermissionRow
    {
        public int RowId { get; set; }
        public string RowIdType { get; set; } = null!;
        public string? RowPermCache { get; set; }
        public int RowUpdated { get; set; }
    }
}

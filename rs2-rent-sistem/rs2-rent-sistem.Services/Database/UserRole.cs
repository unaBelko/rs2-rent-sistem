namespace rs2_rent_sistem.Services.Database;

public partial class UserRole
{
    public int UserID { get; set; }

    public int RoleID { get; set; }

    public DateTime? DateChanged { get; set; }

    public virtual Role Role { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}

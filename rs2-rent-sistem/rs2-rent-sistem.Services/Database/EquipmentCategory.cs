namespace rs2_rent_sistem.Services.Database;

public partial class EquipmentCategory
{
    public int ID { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }
    public bool IsDeleted { get; set; } = false;
    public virtual ICollection<Equipment> Equipment { get; } = new List<Equipment>();
}

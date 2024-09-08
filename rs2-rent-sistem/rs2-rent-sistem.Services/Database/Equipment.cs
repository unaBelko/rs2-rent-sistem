namespace rs2_rent_sistem.Services.Database;

public partial class Equipment
{
    public int ID { get; set; }

    public string? ItemName { get; set; }

    public string? ImageUrl { get; set; }

    public int? StockQuantity { get; set; }

    public int? MinQuantity { get; set; }

    public int? MaxQuantity { get; set; }

    public string? Description { get; set; }

    public decimal? CostPerUse { get; set; }

    public DateTime? DateAdded { get; set; }

    public int? ManufacturerID { get; set; }

    public int? AddedByUserID { get; set; }

    public int? EquipmentCategoryId { get; set; }

    public bool? IsDeleted { get; set; }
    public byte[]? Photo { get; set; }

    public virtual User? AddedByUser { get; set; }

    public virtual ICollection<CartItem> CartItems { get; } = new List<CartItem>();

    public virtual EquipmentCategory? EquipmentCategory { get; set; }

    public virtual Manufacturer? Manufacturer { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; } = new List<OrderItem>();


}

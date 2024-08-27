namespace rs2_rent_sistem.Services.Database;

public partial class Cart
{
    public int ID { get; set; }

    public int? UserID { get; set; }

    public DateTime? DateAdded { get; set; }

    public decimal? TotalPrice { get; set; }

    public virtual ICollection<CartItem> CartItems { get; } = new List<CartItem>();

    public virtual User? User { get; set; }
}

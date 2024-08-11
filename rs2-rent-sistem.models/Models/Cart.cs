namespace rs2_rent_sistem.Models.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public DateTime? DateAdded { get; set; }
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    }
}

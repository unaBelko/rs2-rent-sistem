namespace rs2_rent_sistem.Models.Models
{
    public class CartItem
    {
        public int ID { get; set; }
        public int? Quantity { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public virtual Equipment? Equipment { get; set; }
    }
}

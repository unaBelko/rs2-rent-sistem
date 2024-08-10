namespace rs2_rent_sistem.models.Models
{
    public class OrderItem
    {
        public int ID { get; set; }
        public int? Quantity { get; set; }
        public decimal? CostPerUse { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public virtual Equipment? Equipment { get; set; }
        public virtual ICollection<Review> Reviews { get; } = new List<Review>();

    }
}

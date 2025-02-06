namespace rs2_rent_sistem.Model.Models
{
    public class Review
    {
        public int ID { get; set; }

        public DateTime? DateAdded { get; set; }

        public string? Description { get; set; }

        public decimal? NumberOfStars { get; set; }
        public int OrderItemID { get; set; }
        public virtual OrderItem OrderItem { get; set; }
    }
}

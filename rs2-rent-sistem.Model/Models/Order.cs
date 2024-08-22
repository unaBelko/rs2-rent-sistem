namespace rs2_rent_sistem.Model.Models
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime? DatePlaced { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; } = new List<OrderItem>();
    }
}

namespace rs2_rent_sistem.Model.Models
{
    public class Damage
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime DateAdded { get; set; }
        public OrderItem OrderItem { get; set; }
    }
}

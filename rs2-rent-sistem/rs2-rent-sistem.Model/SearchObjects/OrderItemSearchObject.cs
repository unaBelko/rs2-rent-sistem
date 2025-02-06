namespace rs2_rent_sistem.Model.SearchObjects
{
    public class OrderItemSearchObject : BaseSearchObject
    {
        public int UserId { get; set; }
        public int? OrderId { get; set; }
        public bool ReturnOnlyActiveReservations { get; set; }
    }
}

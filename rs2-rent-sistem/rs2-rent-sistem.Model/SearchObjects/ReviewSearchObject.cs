namespace rs2_rent_sistem.Model.SearchObjects
{
    public class ReviewSearchObject : BaseSearchObject
    {
        public int userId { get; set; }
        public int? searchForUserId { get; set; }
        public int? searchForEquipmentId { get; set; }

    }
}

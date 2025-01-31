namespace rs2_rent_sistem.Model.SearchObjects
{
    public class EquipmentSearchObject : BaseSearchObject
    {
        public string? Name { get; set; }
        public int? manufacturerID { get; set; }
        public int? equipmentCategoryID { get; set; }
        public bool sortDescending { get; set; }
    }
}

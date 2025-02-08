namespace rs2_rent_sistem.Model.Models
{
    public class Equipment
    {
        public int ID { get; set; }
        public string? ItemName { get; set; }
        public int? StockQuantity { get; set; }
        public int? MinQuantity { get; set; }
        public int? MaxQuantity { get; set; }
        public string? Description { get; set; }
        public decimal? CostPerUse { get; set; }
        public decimal AverageRating { get; set; }
        public DateTime? DateAdded { get; set; }
        public int? EquipmentCategoryID { get; set; }
        public String? EquipmentCategory { get; set; }
        public int? ManufacturerID { get; set; }
        public String? Manufacturer { get; set; }
        public string? Photo { get; set; }
        public List<AvailableDate>? AvailableDates { get; set; }
    }
}

﻿namespace rs2_rent_sistem.Model.Models
{
    public class CartItem
    {
        public int ID { get; set; }
        public int? Quantity { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int EquipmentID { get; set; }
        public Equipment Equipment { get; set; }
    }
}

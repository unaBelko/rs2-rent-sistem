﻿namespace rs2_rent_sistem.Models.Requests
{
    public class CartItemUpsertObject
    {
        public int? Quantity { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int EquipmentID { get; set; }
    }
}

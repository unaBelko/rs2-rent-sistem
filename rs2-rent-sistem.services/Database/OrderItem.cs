using System;
using System.Collections.Generic;

namespace rs2_rent_sistem.Services.Database;

public partial class OrderItem
{
    public int ID { get; set; }

    public int? OrderID { get; set; }

    public int? EquipmentID { get; set; }

    public int? Quantity { get; set; }

    public decimal? CostPerUse { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual Equipment? Equipment { get; set; }

    public virtual Order? Order { get; set; }

    public virtual ICollection<Review> Reviews { get; } = new List<Review>();
}

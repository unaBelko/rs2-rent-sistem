using System;
using System.Collections.Generic;

namespace rs2_rent_sistem.Services.Database;

public partial class CartItem
{
    public int ID { get; set; }

    public int? CartID { get; set; }

    public int? EquipmentID { get; set; }

    public int? Quantity { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual Cart? Cart { get; set; }

    public virtual Equipment? Equipment { get; set; }
}

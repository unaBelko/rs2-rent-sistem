using System;
using System.Collections.Generic;

namespace rs2_rent_sistem.Services.Database;
public partial class Order
{
    public int ID { get; set; }

    public int? UserID { get; set; }

    public DateTime? DatePlaced { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; } = new List<OrderItem>();

    public virtual User? User { get; set; }
}

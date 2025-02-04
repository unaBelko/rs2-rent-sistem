using System;
using System.Collections.Generic;

namespace rs2_rent_sistem.Services.Database;

public partial class Damage
{
    public int ID { get; set; }

    public string? Comment { get; set; }

    public DateTime DateAdded { get; set; }

    public int OrderItemID { get; set; }

    public virtual OrderItem OrderItem { get; set; }
}

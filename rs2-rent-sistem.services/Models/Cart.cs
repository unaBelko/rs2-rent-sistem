using System;
using System.Collections.Generic;

namespace rs2_rent_sistem.services.Models;

public partial class Cart
{
    public int ID { get; set; }

    public int? UserID { get; set; }

    public DateTime? DateAdded { get; set; }

    public virtual ICollection<CartItem> CartItems { get; } = new List<CartItem>();

    public virtual User? User { get; set; }
}

using System;
using System.Collections.Generic;

namespace rs2_rent_sistem.services.Models;

public partial class Role
{
    public int ID { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<User> Users { get; } = new List<User>();
}

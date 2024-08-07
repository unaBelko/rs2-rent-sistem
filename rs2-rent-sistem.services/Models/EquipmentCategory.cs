﻿using System;
using System.Collections.Generic;

namespace rs2_rent_sistem.services.Models;

public partial class EquipmentCategory
{
    public int ID { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Equipment> Equipment { get; } = new List<Equipment>();
}

﻿using System;
using System.Collections.Generic;

namespace rs2_rent_sistem.services.Models;

public partial class Review
{
    public int ID { get; set; }

    public DateTime? DateAdded { get; set; }

    public string? Description { get; set; }

    public decimal? NumberOfStars { get; set; }

    public int? AddedByUserID { get; set; }

    public int? OrderItemID { get; set; }

    public virtual User? AddedByUser { get; set; }

    public virtual OrderItem? OrderItem { get; set; }
}

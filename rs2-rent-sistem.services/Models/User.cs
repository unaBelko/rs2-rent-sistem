﻿using System;
using System.Collections.Generic;

namespace rs2_rent_sistem.services.Models;

public partial class User
{
    public int ID { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public bool? IsActive { get; set; }

    public byte[]? PasswordHash { get; set; }

    public byte[]? Salt { get; set; }

    public virtual ICollection<Cart> Carts { get; } = new List<Cart>();

    public virtual ICollection<Equipment> Equipment { get; } = new List<Equipment>();

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual ICollection<Review> Reviews { get; } = new List<Review>();

    public virtual ICollection<Role> Roles { get; } = new List<Role>();
}

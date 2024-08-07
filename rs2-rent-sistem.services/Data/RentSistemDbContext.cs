using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using rs2_rent_sistem.services.Models;

namespace rs2_rent_sistem.services.Data;

public partial class RentSistemDbContext : DbContext
{
    public RentSistemDbContext()
    {
    }

    public RentSistemDbContext(DbContextOptions<RentSistemDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<CartItem> CartItems { get; set; }

    public virtual DbSet<Equipment> Equipment { get; set; }

    public virtual DbSet<EquipmentCategory> EquipmentCategories { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=rentSistemDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cart>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Cart__3214EC27EA0C6239");

            entity.ToTable("Cart");

            entity.Property(e => e.DateAdded).HasColumnType("datetime");

            entity.HasOne(d => d.User).WithMany(p => p.Carts)
                .HasForeignKey(d => d.UserID)
                .HasConstraintName("FK__Cart__UserID__534D60F1");
        });

        modelBuilder.Entity<CartItem>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__CartItem__3214EC27B82CE2FC");

            entity.ToTable("CartItem");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.Cart).WithMany(p => p.CartItems)
                .HasForeignKey(d => d.CartID)
                .HasConstraintName("FK__CartItem__CartID__5629CD9C");

            entity.HasOne(d => d.Equipment).WithMany(p => p.CartItems)
                .HasForeignKey(d => d.EquipmentID)
                .HasConstraintName("FK__CartItem__Equipm__571DF1D5");
        });

        modelBuilder.Entity<Equipment>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Equipmen__3214EC27911FDFBA");

            entity.Property(e => e.CostPerUse).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.DateAdded).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ImageUrl).HasMaxLength(100);
            entity.Property(e => e.ItemName).HasMaxLength(100);

            entity.HasOne(d => d.AddedByUser).WithMany(p => p.Equipment)
                .HasForeignKey(d => d.AddedByUserID)
                .HasConstraintName("FK__Equipment__Added__44FF419A");

            entity.HasOne(d => d.EquipmentCategory).WithMany(p => p.Equipment)
                .HasForeignKey(d => d.EquipmentCategoryId)
                .HasConstraintName("FK__Equipment__Equip__45F365D3");

            entity.HasOne(d => d.Manufacturer).WithMany(p => p.Equipment)
                .HasForeignKey(d => d.ManufacturerID)
                .HasConstraintName("FK__Equipment__Manuf__440B1D61");
        });

        modelBuilder.Entity<EquipmentCategory>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Equipmen__3214EC27FBD853F2");

            entity.ToTable("EquipmentCategory");

            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Manufact__3214EC275D5D54E7");

            entity.ToTable("Manufacturer");

            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Order__3214EC2732F21B09");

            entity.ToTable("Order");

            entity.Property(e => e.DatePlaced).HasColumnType("datetime");

            entity.HasOne(d => d.User).WithMany(p => p.Orders)
                .HasForeignKey(d => d.UserID)
                .HasConstraintName("FK__Order__UserID__48CFD27E");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__OrderIte__3214EC27EC1D8DB5");

            entity.ToTable("OrderItem");

            entity.Property(e => e.CostPerUse).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.Equipment).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.EquipmentID)
                .HasConstraintName("FK__OrderItem__Equip__4CA06362");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.OrderID)
                .HasConstraintName("FK__OrderItem__Order__4BAC3F29");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Review__3214EC2785F82C02");

            entity.ToTable("Review");

            entity.Property(e => e.DateAdded).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.NumberOfStars).HasColumnType("decimal(1, 1)");

            entity.HasOne(d => d.AddedByUser).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.AddedByUserID)
                .HasConstraintName("FK__Review__AddedByU__4F7CD00D");

            entity.HasOne(d => d.OrderItem).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.OrderItemID)
                .HasConstraintName("FK__Review__OrderIte__5070F446");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Role__3214EC27E0A34F51");

            entity.ToTable("Role");

            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__User__3214EC278C4D66AC");

            entity.ToTable("User");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.PasswordHash).HasMaxLength(64);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.Salt).HasMaxLength(16);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "UserRole",
                    r => r.HasOne<Role>().WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__UserRole__RoleID__3D5E1FD2"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__UserRole__UserID__3C69FB99"),
                    j =>
                    {
                        j.HasKey("UserID", "RoleID").HasName("PK__UserRole__AF27604F3FD15EFF");
                        j.ToTable("UserRole");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

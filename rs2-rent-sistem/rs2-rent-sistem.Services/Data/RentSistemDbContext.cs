using Microsoft.EntityFrameworkCore;
using rs2_rent_sistem.Services.Database;

namespace rs2_rent_sistem.Services.Data;

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

    public virtual DbSet<UserRole> UserRoles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cart>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Cart__3214EC27F092848C");

            entity.ToTable("Cart");

            entity.Property(e => e.DateAdded).HasColumnType("datetime");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(12, 2)");

            entity.HasOne(d => d.User).WithMany(p => p.Carts)
                .HasForeignKey(d => d.UserID)
                .HasConstraintName("FK__Cart__UserID__5535A963");
        });

        modelBuilder.Entity<CartItem>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__CartItem__3214EC270170661E");

            entity.ToTable("CartItem");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.Cart).WithMany(p => p.CartItems)
                .HasForeignKey(d => d.CartID)
                .HasConstraintName("FK__CartItem__CartID__5812160E");

            entity.HasOne(d => d.Equipment).WithMany(p => p.CartItems)
                .HasForeignKey(d => d.EquipmentID)
                .HasConstraintName("FK__CartItem__Equipm__59063A47");
        });

        modelBuilder.Entity<Equipment>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Equipmen__3214EC27E5E8D640");

            entity.Property(e => e.CostPerUse).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.DateAdded).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ImageUrl).HasMaxLength(100);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("((1))");
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
            entity.HasKey(e => e.ID).HasName("PK__Equipmen__3214EC2767D63CD6");

            entity.ToTable("EquipmentCategory");

            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Manufact__3214EC279512E539");

            entity.ToTable("Manufacturer");

            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Order__3214EC27E334F241");

            entity.ToTable("Order");

            entity.Property(e => e.DatePlaced).HasColumnType("datetime");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(12, 2)");

            entity.HasOne(d => d.User).WithMany(p => p.Orders)
                .HasForeignKey(d => d.UserID)
                .HasConstraintName("FK__Order__UserID__49C3F6B7");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__OrderIte__3214EC27A60ECC1F");

            entity.ToTable("OrderItem");

            entity.Property(e => e.CostPerUse).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.Equipment).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.EquipmentID)
                .HasConstraintName("FK__OrderItem__Equip__4D94879B");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.OrderID)
                .HasConstraintName("FK__OrderItem__Order__4CA06362");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Review__3214EC273729A687");

            entity.ToTable("Review");

            entity.Property(e => e.DateAdded).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.NumberOfStars).HasColumnType("decimal(1, 1)");

            entity.HasOne(d => d.AddedByUser).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.AddedByUserID)
                .HasConstraintName("FK__Review__AddedByU__5070F446");

            entity.HasOne(d => d.OrderItem).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.OrderItemID)
                .HasConstraintName("FK__Review__OrderIte__5165187F");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Role__3214EC2778B20863");

            entity.ToTable("Role");

            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__User__3214EC278C534519");

            entity.ToTable("User");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.PasswordHash).HasMaxLength(300);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.Salt).HasMaxLength(300);
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => new { e.UserID, e.RoleID }).HasName("PK__UserRole__AF27604F8443E939");

            entity.ToTable("UserRole");

            entity.Property(e => e.DateChanged).HasColumnType("datetime");

            entity.HasOne(d => d.Role).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.RoleID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserRole__RoleID__3D5E1FD2");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.UserID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserRole__UserID__3C69FB99");
        });

        DatabaseSeed.SeedData(modelBuilder);
    }

}

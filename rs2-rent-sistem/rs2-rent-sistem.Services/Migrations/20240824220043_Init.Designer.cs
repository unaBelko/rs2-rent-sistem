﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using rs2_rent_sistem.Services.Data;

#nullable disable

namespace rs2_rent_sistem.Services.Migrations
{
    [DbContext(typeof(RentSistemDbContext))]
    [Migration("20240824220043_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UserRole", b =>
                {
                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.HasKey("UserID", "RoleID")
                        .HasName("PK__UserRole__AF27604F02E4AED9");

                    b.HasIndex("RoleID");

                    b.ToTable("UserRole", (string)null);
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.Cart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("DateAdded")
                        .HasColumnType("datetime");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID")
                        .HasName("PK__Cart__3214EC27E530335A");

                    b.HasIndex("UserID");

                    b.ToTable("Cart", (string)null);
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.CartItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("CartID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("EquipmentID")
                        .HasColumnType("int");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime");

                    b.HasKey("ID")
                        .HasName("PK__CartItem__3214EC277B613A20");

                    b.HasIndex("CartID");

                    b.HasIndex("EquipmentID");

                    b.ToTable("CartItem", (string)null);
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.Equipment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("AddedByUserID")
                        .HasColumnType("int");

                    b.Property<decimal?>("CostPerUse")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<DateTime?>("DateAdded")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("EquipmentCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool?>("IsDeleted")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("ItemName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ManufacturerID")
                        .HasColumnType("int");

                    b.Property<int?>("MaxQuantity")
                        .HasColumnType("int");

                    b.Property<int?>("MinQuantity")
                        .HasColumnType("int");

                    b.Property<int?>("StockQuantity")
                        .HasColumnType("int");

                    b.HasKey("ID")
                        .HasName("PK__Equipmen__3214EC27A9AE558D");

                    b.HasIndex("AddedByUserID");

                    b.HasIndex("EquipmentCategoryId");

                    b.HasIndex("ManufacturerID");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.EquipmentCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID")
                        .HasName("PK__Equipmen__3214EC273EB52989");

                    b.ToTable("EquipmentCategory", (string)null);
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.Manufacturer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID")
                        .HasName("PK__Manufact__3214EC27FD9A3042");

                    b.ToTable("Manufacturer", (string)null);
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("DatePlaced")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<decimal?>("TotalPrice")
                        .HasColumnType("decimal(12, 2)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID")
                        .HasName("PK__Order__3214EC271170F4B9");

                    b.HasIndex("UserID");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.OrderItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<decimal?>("CostPerUse")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("EquipmentID")
                        .HasColumnType("int");

                    b.Property<int?>("OrderID")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime");

                    b.HasKey("ID")
                        .HasName("PK__OrderIte__3214EC27CFF6BE76");

                    b.HasIndex("EquipmentID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderItem", (string)null);
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.Review", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("AddedByUserID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateAdded")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool?>("IsDeleted")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<decimal?>("NumberOfStars")
                        .HasColumnType("decimal(1, 1)");

                    b.Property<int?>("OrderItemID")
                        .HasColumnType("int");

                    b.HasKey("ID")
                        .HasName("PK__Review__3214EC2757F33F6D");

                    b.HasIndex("AddedByUserID");

                    b.HasIndex("OrderItemID");

                    b.ToTable("Review", (string)null);
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID")
                        .HasName("PK__Role__3214EC27AD29A22E");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("IsActive")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Salt")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("ID")
                        .HasName("PK__User__3214EC2751BB24A6");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("UserRole", b =>
                {
                    b.HasOne("rs2_rent_sistem.Services.Database.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .IsRequired()
                        .HasConstraintName("FK__UserRole__RoleID__3D5E1FD2");

                    b.HasOne("rs2_rent_sistem.Services.Database.User", null)
                        .WithMany()
                        .HasForeignKey("UserID")
                        .IsRequired()
                        .HasConstraintName("FK__UserRole__UserID__3C69FB99");
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.Cart", b =>
                {
                    b.HasOne("rs2_rent_sistem.Services.Database.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserID")
                        .HasConstraintName("FK__Cart__UserID__5535A963");

                    b.Navigation("User");
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.CartItem", b =>
                {
                    b.HasOne("rs2_rent_sistem.Services.Database.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartID")
                        .HasConstraintName("FK__CartItem__CartID__5812160E");

                    b.HasOne("rs2_rent_sistem.Services.Database.Equipment", "Equipment")
                        .WithMany("CartItems")
                        .HasForeignKey("EquipmentID")
                        .HasConstraintName("FK__CartItem__Equipm__59063A47");

                    b.Navigation("Cart");

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.Equipment", b =>
                {
                    b.HasOne("rs2_rent_sistem.Services.Database.User", "AddedByUser")
                        .WithMany("Equipment")
                        .HasForeignKey("AddedByUserID")
                        .HasConstraintName("FK__Equipment__Added__44FF419A");

                    b.HasOne("rs2_rent_sistem.Services.Database.EquipmentCategory", "EquipmentCategory")
                        .WithMany("Equipment")
                        .HasForeignKey("EquipmentCategoryId")
                        .HasConstraintName("FK__Equipment__Equip__45F365D3");

                    b.HasOne("rs2_rent_sistem.Services.Database.Manufacturer", "Manufacturer")
                        .WithMany("Equipment")
                        .HasForeignKey("ManufacturerID")
                        .HasConstraintName("FK__Equipment__Manuf__440B1D61");

                    b.Navigation("AddedByUser");

                    b.Navigation("EquipmentCategory");

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.Order", b =>
                {
                    b.HasOne("rs2_rent_sistem.Services.Database.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .HasConstraintName("FK__Order__UserID__49C3F6B7");

                    b.Navigation("User");
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.OrderItem", b =>
                {
                    b.HasOne("rs2_rent_sistem.Services.Database.Equipment", "Equipment")
                        .WithMany("OrderItems")
                        .HasForeignKey("EquipmentID")
                        .HasConstraintName("FK__OrderItem__Equip__4D94879B");

                    b.HasOne("rs2_rent_sistem.Services.Database.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderID")
                        .HasConstraintName("FK__OrderItem__Order__4CA06362");

                    b.Navigation("Equipment");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.Review", b =>
                {
                    b.HasOne("rs2_rent_sistem.Services.Database.User", "AddedByUser")
                        .WithMany("Reviews")
                        .HasForeignKey("AddedByUserID")
                        .HasConstraintName("FK__Review__AddedByU__5070F446");

                    b.HasOne("rs2_rent_sistem.Services.Database.OrderItem", "OrderItem")
                        .WithMany("Reviews")
                        .HasForeignKey("OrderItemID")
                        .HasConstraintName("FK__Review__OrderIte__5165187F");

                    b.Navigation("AddedByUser");

                    b.Navigation("OrderItem");
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.Equipment", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.EquipmentCategory", b =>
                {
                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.Manufacturer", b =>
                {
                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.OrderItem", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("rs2_rent_sistem.Services.Database.User", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Equipment");

                    b.Navigation("Orders");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}

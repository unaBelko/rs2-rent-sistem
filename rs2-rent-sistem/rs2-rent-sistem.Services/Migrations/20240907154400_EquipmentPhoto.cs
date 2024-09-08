using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rs2_rent_sistem.Services.Migrations
{
    /// <inheritdoc />
    public partial class EquipmentPhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EquipmentCategory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Equipmen__3214EC2767D63CD6", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Manufact__3214EC279512E539", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Role__3214EC2778B20863", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    PasswordHash = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Salt = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__User__3214EC278C534519", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(12,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Cart__3214EC27F092848C", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Cart__UserID__5535A963",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StockQuantity = table.Column<int>(type: "int", nullable: true),
                    MinQuantity = table.Column<int>(type: "int", nullable: true),
                    MaxQuantity = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CostPerUse = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime", nullable: true),
                    ManufacturerID = table.Column<int>(type: "int", nullable: true),
                    AddedByUserID = table.Column<int>(type: "int", nullable: true),
                    EquipmentCategoryId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Equipmen__3214EC27E5E8D640", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Equipment__Added__44FF419A",
                        column: x => x.AddedByUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__Equipment__Equip__45F365D3",
                        column: x => x.EquipmentCategoryId,
                        principalTable: "EquipmentCategory",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__Equipment__Manuf__440B1D61",
                        column: x => x.ManufacturerID,
                        principalTable: "Manufacturer",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    DatePlaced = table.Column<DateTime>(type: "datetime", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Order__3214EC27E334F241", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Order__UserID__49C3F6B7",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    DateChanged = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserRole__AF27604F8443E939", x => new { x.UserID, x.RoleID });
                    table.ForeignKey(
                        name: "FK__UserRole__RoleID__3D5E1FD2",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__UserRole__UserID__3C69FB99",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartID = table.Column<int>(type: "int", nullable: true),
                    EquipmentID = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CartItem__3214EC270170661E", x => x.ID);
                    table.ForeignKey(
                        name: "FK__CartItem__CartID__5812160E",
                        column: x => x.CartID,
                        principalTable: "Cart",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__CartItem__Equipm__59063A47",
                        column: x => x.EquipmentID,
                        principalTable: "Equipment",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    EquipmentID = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    CostPerUse = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OrderIte__3214EC27A60ECC1F", x => x.ID);
                    table.ForeignKey(
                        name: "FK__OrderItem__Equip__4D94879B",
                        column: x => x.EquipmentID,
                        principalTable: "Equipment",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__OrderItem__Order__4CA06362",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateAdded = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NumberOfStars = table.Column<decimal>(type: "decimal(1,1)", nullable: true),
                    AddedByUserID = table.Column<int>(type: "int", nullable: true),
                    OrderItemID = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Review__3214EC273729A687", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Review__AddedByU__5070F446",
                        column: x => x.AddedByUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__Review__OrderIte__5165187F",
                        column: x => x.OrderItemID,
                        principalTable: "OrderItem",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "EquipmentCategory",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Equipment for football and soccer", "Football" },
                    { 2, "Basketball equipment and accessories", "Basketball" },
                    { 3, "Tennis rackets and gear", "Tennis" },
                    { 4, "Baseball bats, gloves, and equipment", "Baseball" },
                    { 5, "Bikes and cycling gear", "Cycling" },
                    { 6, "Running shoes and accessories", "Running" },
                    { 7, "Swimming gear and equipment", "Swimming" },
                    { 8, "Golf clubs and accessories", "Golf" },
                    { 9, "Boxing gloves and equipment", "Boxing" },
                    { 10, "Fitness and gym equipment", "Fitness" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturer",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Sportswear and equipment manufacturer", "Nike" },
                    { 2, "Global sports equipment manufacturer", "Adidas" },
                    { 3, "Sporting goods and apparel manufacturer", "Puma" },
                    { 4, "Performance apparel and gear", "Under Armour" },
                    { 5, "Footwear and sports equipment", "Reebok" },
                    { 6, "Sports equipment, especially in tennis", "Wilson" },
                    { 7, "Basketball and sporting goods manufacturer", "Spalding" },
                    { 8, "Badminton and tennis equipment manufacturer", "Yonex" },
                    { 9, "Golf equipment and accessories", "Callaway" },
                    { 10, "Boxing equipment and apparel manufacturer", "Everlast" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Radnik u rent biznisu, koristi desktop app", "employee" },
                    { 2, "Krajnji korisnik, koristi mobilnu aplikaciju", "end-user" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Email", "FirstName", "IsActive", "LastName", "PasswordHash", "Phone", "Salt" },
                values: new object[,]
                {
                    { 1, "una.belko+radnik@edu.fit.ba", "Una", true, "Radnik", "sRTsGRjffsRw2K0G/9ZFN+EvoE2SEdabhHq55jmBq/k=", "0038763222111", "ktn9I29B0imKx0RhFtkt+A==" },
                    { 2, "una.belko+shopping@edu.fit.ba", "Una", true, "Shopping", "sRTsGRjffsRw2K0G/9ZFN+EvoE2SEdabhHq55jmBq/k=", "0038763222111", "ktn9I29B0imKx0RhFtkt+A==" },
                    { 3, "michael.johnson+user@rental.com", "Michael", true, "Johnson", "sRTsGRjffsRw2K0G/9ZFN+EvoE2SEdabhHq55jmBq/k=", "555-8765", "ktn9I29B0imKx0RhFtkt+A==" },
                    { 4, "emily.davis+user@rental.com", "Emily", true, "Davis", "sRTsGRjffsRw2K0G/9ZFN+EvoE2SEdabhHq55jmBq/k=", "555-4321", "ktn9I29B0imKx0RhFtkt+A==" },
                    { 5, "william.brown+user@rental.com", "William", true, "Brown", "sRTsGRjffsRw2K0G/9ZFN+EvoE2SEdabhHq55jmBq/k=", "555-6789", "ktn9I29B0imKx0RhFtkt+A==" },
                    { 6, "ava.wilson+user@rental.com", "Ava", true, "Wilson", "sRTsGRjffsRw2K0G/9ZFN+EvoE2SEdabhHq55jmBq/k=", "555-2345", "ktn9I29B0imKx0RhFtkt+A==" },
                    { 7, "james.taylor+user@rental.com", "James", true, "Taylor", "sRTsGRjffsRw2K0G/9ZFN+EvoE2SEdabhHq55jmBq/k=", "555-7890", "ktn9I29B0imKx0RhFtkt+A==" },
                    { 8, "olivia.anderson+user@rental.com", "Olivia", true, "Anderson", "sRTsGRjffsRw2K0G/9ZFN+EvoE2SEdabhHq55jmBq/k=", "555-3456", "ktn9I29B0imKx0RhFtkt+A==" },
                    { 9, "benjamin.thomas+user@rental.com", "Benjamin", true, "Thomas", "sRTsGRjffsRw2K0G/9ZFN+EvoE2SEdabhHq55jmBq/k=", "555-9012", "ktn9I29B0imKx0RhFtkt+A==" },
                    { 10, "sophia.moore+user@rental.com", "Sophia", true, "Moore", "sRTsGRjffsRw2K0G/9ZFN+EvoE2SEdabhHq55jmBq/k=", "555-6543", "ktn9I29B0imKx0RhFtkt+A==" }
                });

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "ID", "DateAdded", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 1, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(526), 45.75m, 2 },
                    { 2, new DateTime(2024, 9, 2, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(531), 120.00m, 3 },
                    { 3, new DateTime(2024, 9, 3, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(534), 65.30m, 4 },
                    { 4, new DateTime(2024, 9, 4, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(536), 78.40m, 5 },
                    { 5, new DateTime(2024, 9, 5, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(538), 52.10m, 6 },
                    { 6, new DateTime(2024, 9, 6, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(541), 98.25m, 7 },
                    { 7, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(543), 36.60m, 8 }
                });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "ID", "AddedByUserID", "CostPerUse", "DateAdded", "Description", "EquipmentCategoryId", "ImageUrl", "IsDeleted", "ItemName", "ManufacturerID", "MaxQuantity", "MinQuantity", "Photo", "StockQuantity" },
                values: new object[,]
                {
                    { 1, 1, 2.99m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9636), "Official size and weight.", 1, "soccerball.jpg", false, "Soccer Ball", 1, 50, 5, null, 30 },
                    { 2, 1, 3.49m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9684), "High-quality leather basketball.", 2, "basketball.jpg", false, "Basketball", 2, 40, 5, null, 20 },
                    { 3, 1, 4.99m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9688), "Lightweight racket for professional use.", 3, "tennisracket.jpg", false, "Tennis Racket", 3, 25, 2, null, 15 },
                    { 4, 1, 3.28m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9746), "Description for Equipment 4", 8, "equipment4.jpg", false, "Equipment 4", 7, 50, 5, null, 28 },
                    { 5, 1, 7.91m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9758), "Description for Equipment 5", 6, "equipment5.jpg", false, "Equipment 5", 8, 50, 5, null, 12 },
                    { 6, 1, 7.52m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9768), "Description for Equipment 6", 7, "equipment6.jpg", false, "Equipment 6", 5, 50, 5, null, 42 },
                    { 7, 1, 7.59m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9804), "Description for Equipment 7", 7, "equipment7.jpg", false, "Equipment 7", 5, 50, 5, null, 45 },
                    { 8, 1, 5.91m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9813), "Description for Equipment 8", 4, "equipment8.jpg", false, "Equipment 8", 2, 50, 5, null, 16 },
                    { 9, 1, 8.77m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9822), "Description for Equipment 9", 1, "equipment9.jpg", false, "Equipment 9", 6, 50, 5, null, 48 },
                    { 10, 1, 4.54m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9832), "Description for Equipment 10", 8, "equipment10.jpg", false, "Equipment 10", 1, 50, 5, null, 12 },
                    { 11, 1, 2.68m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9841), "Description for Equipment 11", 7, "equipment11.jpg", false, "Equipment 11", 7, 50, 5, null, 39 },
                    { 12, 1, 0.45m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9849), "Description for Equipment 12", 2, "equipment12.jpg", false, "Equipment 12", 7, 50, 5, null, 38 },
                    { 13, 1, 5.30m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9858), "Description for Equipment 13", 1, "equipment13.jpg", false, "Equipment 13", 3, 50, 5, null, 38 },
                    { 14, 1, 8.09m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9866), "Description for Equipment 14", 2, "equipment14.jpg", false, "Equipment 14", 9, 50, 5, null, 39 },
                    { 15, 1, 4.45m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9875), "Description for Equipment 15", 4, "equipment15.jpg", false, "Equipment 15", 3, 50, 5, null, 34 },
                    { 16, 1, 9.67m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9883), "Description for Equipment 16", 8, "equipment16.jpg", false, "Equipment 16", 9, 50, 5, null, 33 },
                    { 17, 1, 3.07m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9892), "Description for Equipment 17", 9, "equipment17.jpg", false, "Equipment 17", 7, 50, 5, null, 31 },
                    { 18, 1, 2.55m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9927), "Description for Equipment 18", 9, "equipment18.jpg", false, "Equipment 18", 3, 50, 5, null, 41 },
                    { 19, 1, 7.58m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9936), "Description for Equipment 19", 3, "equipment19.jpg", false, "Equipment 19", 6, 50, 5, null, 31 },
                    { 20, 1, 2.47m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9945), "Description for Equipment 20", 9, "equipment20.jpg", false, "Equipment 20", 6, 50, 5, null, 18 },
                    { 21, 1, 6.32m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9953), "Description for Equipment 21", 4, "equipment21.jpg", false, "Equipment 21", 9, 50, 5, null, 41 },
                    { 22, 1, 7.42m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9961), "Description for Equipment 22", 8, "equipment22.jpg", false, "Equipment 22", 7, 50, 5, null, 44 },
                    { 23, 1, 5.45m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9969), "Description for Equipment 23", 7, "equipment23.jpg", false, "Equipment 23", 7, 50, 5, null, 47 },
                    { 24, 1, 7.17m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9978), "Description for Equipment 24", 1, "equipment24.jpg", false, "Equipment 24", 7, 50, 5, null, 42 },
                    { 25, 1, 6.19m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9986), "Description for Equipment 25", 9, "equipment25.jpg", false, "Equipment 25", 1, 50, 5, null, 41 },
                    { 26, 1, 4.51m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9995), "Description for Equipment 26", 9, "equipment26.jpg", false, "Equipment 26", 3, 50, 5, null, 17 },
                    { 27, 1, 3.77m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(3), "Description for Equipment 27", 2, "equipment27.jpg", false, "Equipment 27", 6, 50, 5, null, 34 },
                    { 28, 1, 1.68m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(11), "Description for Equipment 28", 6, "equipment28.jpg", false, "Equipment 28", 7, 50, 5, null, 25 },
                    { 29, 1, 2.79m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(47), "Description for Equipment 29", 9, "equipment29.jpg", false, "Equipment 29", 3, 50, 5, null, 48 },
                    { 30, 1, 7.72m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(55), "Description for Equipment 30", 8, "equipment30.jpg", false, "Equipment 30", 3, 50, 5, null, 46 },
                    { 31, 1, 4.10m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(63), "Description for Equipment 31", 4, "equipment31.jpg", false, "Equipment 31", 7, 50, 5, null, 45 },
                    { 32, 1, 3.20m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(71), "Description for Equipment 32", 7, "equipment32.jpg", false, "Equipment 32", 4, 50, 5, null, 28 },
                    { 33, 1, 0.74m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(79), "Description for Equipment 33", 5, "equipment33.jpg", false, "Equipment 33", 2, 50, 5, null, 15 },
                    { 34, 1, 3.23m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(89), "Description for Equipment 34", 4, "equipment34.jpg", false, "Equipment 34", 2, 50, 5, null, 39 },
                    { 35, 1, 4.12m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(97), "Description for Equipment 35", 9, "equipment35.jpg", false, "Equipment 35", 9, 50, 5, null, 43 },
                    { 36, 1, 4.93m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(106), "Description for Equipment 36", 3, "equipment36.jpg", false, "Equipment 36", 9, 50, 5, null, 37 },
                    { 37, 1, 5.76m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(114), "Description for Equipment 37", 6, "equipment37.jpg", false, "Equipment 37", 5, 50, 5, null, 18 },
                    { 38, 1, 5.50m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(122), "Description for Equipment 38", 4, "equipment38.jpg", false, "Equipment 38", 7, 50, 5, null, 36 },
                    { 39, 1, 6.72m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(177), "Description for Equipment 39", 7, "equipment39.jpg", false, "Equipment 39", 9, 50, 5, null, 36 },
                    { 40, 1, 1.98m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(187), "Description for Equipment 40", 9, "equipment40.jpg", false, "Equipment 40", 5, 50, 5, null, 15 },
                    { 41, 1, 4.50m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(195), "Description for Equipment 41", 3, "equipment41.jpg", false, "Equipment 41", 2, 50, 5, null, 17 },
                    { 42, 1, 7.34m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(204), "Description for Equipment 42", 6, "equipment42.jpg", false, "Equipment 42", 8, 50, 5, null, 13 },
                    { 43, 1, 3.96m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(212), "Description for Equipment 43", 2, "equipment43.jpg", false, "Equipment 43", 7, 50, 5, null, 38 },
                    { 44, 1, 3.42m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(220), "Description for Equipment 44", 2, "equipment44.jpg", false, "Equipment 44", 9, 50, 5, null, 35 },
                    { 45, 1, 9.84m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(228), "Description for Equipment 45", 4, "equipment45.jpg", false, "Equipment 45", 7, 50, 5, null, 11 },
                    { 46, 1, 0.30m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(236), "Description for Equipment 46", 1, "equipment46.jpg", false, "Equipment 46", 2, 50, 5, null, 17 },
                    { 47, 1, 6.83m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(244), "Description for Equipment 47", 8, "equipment47.jpg", false, "Equipment 47", 5, 50, 5, null, 26 },
                    { 48, 1, 4.17m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(252), "Description for Equipment 48", 6, "equipment48.jpg", false, "Equipment 48", 6, 50, 5, null, 19 },
                    { 49, 1, 2.19m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(261), "Description for Equipment 49", 5, "equipment49.jpg", false, "Equipment 49", 5, 50, 5, null, 38 },
                    { 50, 1, 3.60m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(301), "Description for Equipment 50", 1, "equipment50.jpg", false, "Equipment 50", 6, 50, 5, null, 23 }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "ID", "DatePlaced", "IsActive", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 28, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(367), true, 59.94m, 3 },
                    { 2, new DateTime(2024, 8, 30, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(371), true, 89.85m, 4 },
                    { 3, new DateTime(2024, 9, 2, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(374), true, 29.97m, 4 },
                    { 4, new DateTime(2024, 8, 31, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(376), true, 19.98m, 5 },
                    { 5, new DateTime(2024, 9, 3, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(378), true, 99.90m, 5 },
                    { 6, new DateTime(2024, 9, 4, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(380), true, 49.95m, 6 },
                    { 7, new DateTime(2024, 9, 5, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(383), true, 69.93m, 7 },
                    { 8, new DateTime(2024, 9, 6, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(385), true, 39.96m, 8 },
                    { 9, new DateTime(2024, 9, 1, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(387), true, 149.85m, 9 },
                    { 10, new DateTime(2024, 8, 29, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(389), true, 29.97m, 10 }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleID", "UserID", "DateChanged" },
                values: new object[,]
                {
                    { 1, 1, null },
                    { 2, 2, null },
                    { 2, 3, null },
                    { 2, 4, null },
                    { 2, 5, null },
                    { 2, 6, null },
                    { 2, 7, null },
                    { 2, 8, null },
                    { 2, 9, null },
                    { 2, 10, null }
                });

            migrationBuilder.InsertData(
                table: "CartItem",
                columns: new[] { "ID", "CartID", "EndDate", "EquipmentID", "Quantity", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 2, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(590), 1, 2, new DateTime(2024, 9, 1, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(587) },
                    { 2, 1, new DateTime(2024, 9, 2, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(595), 2, 1, new DateTime(2024, 9, 1, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(593) },
                    { 3, 2, new DateTime(2024, 9, 3, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(598), 3, 1, new DateTime(2024, 9, 2, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(597) },
                    { 4, 3, new DateTime(2024, 9, 4, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(602), 1, 3, new DateTime(2024, 9, 3, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(600) },
                    { 5, 3, new DateTime(2024, 9, 4, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(605), 2, 2, new DateTime(2024, 9, 3, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(603) },
                    { 6, 4, new DateTime(2024, 9, 5, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(609), 2, 1, new DateTime(2024, 9, 4, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(607) },
                    { 7, 4, new DateTime(2024, 9, 5, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(612), 3, 1, new DateTime(2024, 9, 4, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(610) },
                    { 8, 5, new DateTime(2024, 9, 6, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(615), 1, 2, new DateTime(2024, 9, 5, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(614) },
                    { 9, 6, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(619), 3, 3, new DateTime(2024, 9, 6, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(617) },
                    { 10, 7, new DateTime(2024, 9, 8, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(622), 2, 1, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(621) }
                });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "ID", "CostPerUse", "EndDate", "EquipmentID", "OrderID", "Price", "Quantity", "StartDate" },
                values: new object[,]
                {
                    { 1, 2.99m, new DateTime(2024, 8, 29, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(446), 1, 1, 5.98m, 2, new DateTime(2024, 8, 28, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(441) },
                    { 2, 4.99m, new DateTime(2024, 8, 30, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(452), 3, 1, 4.99m, 1, new DateTime(2024, 8, 28, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(450) },
                    { 3, 3.49m, new DateTime(2024, 8, 31, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(456), 2, 2, 10.47m, 3, new DateTime(2024, 8, 30, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(455) },
                    { 4, 2.99m, new DateTime(2024, 9, 1, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(461), 1, 2, 11.96m, 4, new DateTime(2024, 8, 30, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(459) },
                    { 5, 4.99m, new DateTime(2024, 9, 3, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(465), 3, 3, 9.98m, 2, new DateTime(2024, 9, 2, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(463) },
                    { 6, 2.99m, new DateTime(2024, 9, 1, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(469), 1, 4, 2.99m, 1, new DateTime(2024, 8, 31, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(468) },
                    { 7, 3.49m, new DateTime(2024, 9, 5, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(474), 2, 5, 17.45m, 5, new DateTime(2024, 9, 3, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(472) },
                    { 8, 4.99m, new DateTime(2024, 9, 6, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(478), 3, 6, 14.97m, 3, new DateTime(2024, 9, 4, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(477) },
                    { 9, 2.99m, new DateTime(2024, 9, 8, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(482), 1, 7, 5.98m, 2, new DateTime(2024, 9, 5, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(480) },
                    { 10, 3.49m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(487), 2, 8, 10.47m, 3, new DateTime(2024, 9, 6, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(486) },
                    { 11, 4.99m, new DateTime(2024, 9, 3, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(491), 3, 9, 4.99m, 1, new DateTime(2024, 9, 1, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(490) },
                    { 12, 2.99m, new DateTime(2024, 9, 2, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(496), 1, 9, 14.95m, 5, new DateTime(2024, 9, 1, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(494) },
                    { 13, 3.49m, new DateTime(2024, 8, 30, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(500), 2, 10, 6.98m, 2, new DateTime(2024, 8, 29, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(498) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserID",
                table: "Cart",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_CartID",
                table: "CartItem",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_EquipmentID",
                table: "CartItem",
                column: "EquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_AddedByUserID",
                table: "Equipment",
                column: "AddedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_EquipmentCategoryId",
                table: "Equipment",
                column: "EquipmentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_ManufacturerID",
                table: "Equipment",
                column: "ManufacturerID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserID",
                table: "Order",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_EquipmentID",
                table: "OrderItem",
                column: "EquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Review_AddedByUserID",
                table: "Review",
                column: "AddedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Review_OrderItemID",
                table: "Review",
                column: "OrderItemID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleID",
                table: "UserRole",
                column: "RoleID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "EquipmentCategory");

            migrationBuilder.DropTable(
                name: "Manufacturer");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}

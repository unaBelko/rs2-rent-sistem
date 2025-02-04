using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rs2_rent_sistem.Services.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EquipmentCategories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentCategories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockQuantity = table.Column<int>(type: "int", nullable: true),
                    MinQuantity = table.Column<int>(type: "int", nullable: true),
                    MaxQuantity = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostPerUse = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ManufacturerID = table.Column<int>(type: "int", nullable: true),
                    AddedByUserID = table.Column<int>(type: "int", nullable: false),
                    EquipmentCategoryId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Equipment_EquipmentCategories_EquipmentCategoryId",
                        column: x => x.EquipmentCategoryId,
                        principalTable: "EquipmentCategories",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Equipment_Manufacturers_ManufacturerID",
                        column: x => x.ManufacturerID,
                        principalTable: "Manufacturers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Equipment_Users_AddedByUserID",
                        column: x => x.AddedByUserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    DatePlaced = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    DateChanged = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserID, x.RoleID });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartID = table.Column<int>(type: "int", nullable: false),
                    EquipmentID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EquipmentID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartID",
                        column: x => x.CartID,
                        principalTable: "Carts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Equipment_EquipmentID",
                        column: x => x.EquipmentID,
                        principalTable: "Equipment",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartItems_Equipment_EquipmentID1",
                        column: x => x.EquipmentID1,
                        principalTable: "Equipment",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    EquipmentID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    CostPerUse = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EquipmentID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderItems_Equipment_EquipmentID",
                        column: x => x.EquipmentID,
                        principalTable: "Equipment",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_Equipment_EquipmentID1",
                        column: x => x.EquipmentID1,
                        principalTable: "Equipment",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Damages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderItemID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Damages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Damages_OrderItems_OrderItemID",
                        column: x => x.OrderItemID,
                        principalTable: "OrderItems",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfStars = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OrderItemID = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Reviews_OrderItems_OrderItemID",
                        column: x => x.OrderItemID,
                        principalTable: "OrderItems",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EquipmentCategories",
                columns: new[] { "ID", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "Equipment for football and soccer", false, "Football" },
                    { 2, "Basketball equipment and accessories", false, "Basketball" },
                    { 3, "Tennis rackets and gear", false, "Tennis" },
                    { 4, "Baseball bats, gloves, and equipment", false, "Baseball" },
                    { 5, "Bikes and cycling gear", false, "Cycling" },
                    { 6, "Running shoes and accessories", false, "Running" },
                    { 7, "Swimming gear and equipment", false, "Swimming" },
                    { 8, "Golf clubs and accessories", false, "Golf" },
                    { 9, "Boxing gloves and equipment", false, "Boxing" },
                    { 10, "Fitness and gym equipment", false, "Fitness" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ID", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "Sportswear and equipment manufacturer", false, "Nike" },
                    { 2, "Global sports equipment manufacturer", false, "Adidas" },
                    { 3, "Sporting goods and apparel manufacturer", false, "Puma" },
                    { 4, "Performance apparel and gear", false, "Under Armour" },
                    { 5, "Footwear and sports equipment", false, "Reebok" },
                    { 6, "Sports equipment, especially in tennis", false, "Wilson" },
                    { 7, "Basketball and sporting goods manufacturer", false, "Spalding" },
                    { 8, "Badminton and tennis equipment manufacturer", false, "Yonex" },
                    { 9, "Golf equipment and accessories", false, "Callaway" },
                    { 10, "Boxing equipment and apparel manufacturer", false, "Everlast" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Radnik u rent biznisu, koristi desktop app", "employee" },
                    { 2, "Krajnji korisnik, koristi mobilnu aplikaciju", "end-user" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Email", "FirstName", "IsActive", "LastName", "PasswordHash", "Phone", "Salt" },
                values: new object[,]
                {
                    { 1, "una.belko+radnik@edu.fit.ba", "Una", true, "Radnik", "Ljzw8HnfiYwhMbO7vJnnfurD/X8Z3rZ9tDO+5IO+hH8=", "0038763222111", "gfemRTdJWjVykCcD25n+iw==" },
                    { 2, "una.belko+shopping@edu.fit.ba", "Una", true, "Shopping", "Ljzw8HnfiYwhMbO7vJnnfurD/X8Z3rZ9tDO+5IO+hH8=", "0038763222111", "gfemRTdJWjVykCcD25n+iw==" },
                    { 3, "michael.johnson+user@rental.com", "Michael", true, "Johnson", "Ljzw8HnfiYwhMbO7vJnnfurD/X8Z3rZ9tDO+5IO+hH8=", "555-8765", "gfemRTdJWjVykCcD25n+iw==" },
                    { 4, "emily.davis+user@rental.com", "Emily", true, "Davis", "Ljzw8HnfiYwhMbO7vJnnfurD/X8Z3rZ9tDO+5IO+hH8=", "555-4321", "gfemRTdJWjVykCcD25n+iw==" },
                    { 5, "william.brown+user@rental.com", "William", true, "Brown", "Ljzw8HnfiYwhMbO7vJnnfurD/X8Z3rZ9tDO+5IO+hH8=", "555-6789", "gfemRTdJWjVykCcD25n+iw==" },
                    { 6, "ava.wilson+user@rental.com", "Ava", true, "Wilson", "Ljzw8HnfiYwhMbO7vJnnfurD/X8Z3rZ9tDO+5IO+hH8=", "555-2345", "gfemRTdJWjVykCcD25n+iw==" },
                    { 7, "james.taylor+user@rental.com", "James", true, "Taylor", "Ljzw8HnfiYwhMbO7vJnnfurD/X8Z3rZ9tDO+5IO+hH8=", "555-7890", "gfemRTdJWjVykCcD25n+iw==" },
                    { 8, "olivia.anderson+user@rental.com", "Olivia", true, "Anderson", "Ljzw8HnfiYwhMbO7vJnnfurD/X8Z3rZ9tDO+5IO+hH8=", "555-3456", "gfemRTdJWjVykCcD25n+iw==" },
                    { 9, "benjamin.thomas+user@rental.com", "Benjamin", true, "Thomas", "Ljzw8HnfiYwhMbO7vJnnfurD/X8Z3rZ9tDO+5IO+hH8=", "555-9012", "gfemRTdJWjVykCcD25n+iw==" },
                    { 10, "sophia.moore+user@rental.com", "Sophia", true, "Moore", "Ljzw8HnfiYwhMbO7vJnnfurD/X8Z3rZ9tDO+5IO+hH8=", "555-6543", "gfemRTdJWjVykCcD25n+iw==" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "ID", "DateAdded", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 29, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2525), 45.75m, 2 },
                    { 2, new DateTime(2025, 1, 30, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2528), 120.00m, 3 },
                    { 3, new DateTime(2025, 1, 31, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2531), 65.30m, 4 },
                    { 4, new DateTime(2025, 2, 1, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2532), 78.40m, 5 },
                    { 5, new DateTime(2025, 2, 2, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2534), 52.10m, 6 },
                    { 6, new DateTime(2025, 2, 3, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2536), 98.25m, 7 },
                    { 7, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2538), 36.60m, 8 }
                });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "ID", "AddedByUserID", "CostPerUse", "DateAdded", "Description", "EquipmentCategoryId", "ImageUrl", "IsDeleted", "ItemName", "ManufacturerID", "MaxQuantity", "MinQuantity", "Photo", "StockQuantity" },
                values: new object[,]
                {
                    { 1, 1, 2.99m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1572), "Official size and weight.", 1, "soccerball.jpg", false, "Soccer Ball", 1, 50, 5, null, 30 },
                    { 2, 1, 3.49m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1610), "High-quality leather basketball.", 2, "basketball.jpg", false, "Basketball", 2, 40, 5, null, 20 },
                    { 3, 1, 4.99m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1613), "Lightweight racket for professional use.", 3, "tennisracket.jpg", false, "Tennis Racket", 3, 25, 2, null, 15 },
                    { 4, 1, 6.99m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1682), "Description for Equipment 4", 5, "equipment4.jpg", false, "Equipment 4", 3, 50, 5, null, 19 },
                    { 5, 1, 4.08m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1693), "Description for Equipment 5", 5, "equipment5.jpg", false, "Equipment 5", 3, 50, 5, null, 19 },
                    { 6, 1, 4.81m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1703), "Description for Equipment 6", 9, "equipment6.jpg", false, "Equipment 6", 2, 50, 5, null, 35 },
                    { 7, 1, 6.79m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1712), "Description for Equipment 7", 3, "equipment7.jpg", false, "Equipment 7", 8, 50, 5, null, 31 },
                    { 8, 1, 4.31m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1746), "Description for Equipment 8", 7, "equipment8.jpg", false, "Equipment 8", 7, 50, 5, null, 23 },
                    { 9, 1, 0.95m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1819), "Description for Equipment 9", 3, "equipment9.jpg", false, "Equipment 9", 9, 50, 5, null, 36 },
                    { 10, 1, 5.59m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1829), "Description for Equipment 10", 6, "equipment10.jpg", false, "Equipment 10", 4, 50, 5, null, 13 },
                    { 11, 1, 2.74m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1839), "Description for Equipment 11", 4, "equipment11.jpg", false, "Equipment 11", 4, 50, 5, null, 35 },
                    { 12, 1, 0.41m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1847), "Description for Equipment 12", 4, "equipment12.jpg", false, "Equipment 12", 7, 50, 5, null, 46 },
                    { 13, 1, 7.97m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1856), "Description for Equipment 13", 8, "equipment13.jpg", false, "Equipment 13", 8, 50, 5, null, 27 },
                    { 14, 1, 3.62m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1864), "Description for Equipment 14", 8, "equipment14.jpg", false, "Equipment 14", 2, 50, 5, null, 33 },
                    { 15, 1, 6.39m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1873), "Description for Equipment 15", 4, "equipment15.jpg", false, "Equipment 15", 4, 50, 5, null, 44 },
                    { 16, 1, 3.17m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1881), "Description for Equipment 16", 1, "equipment16.jpg", false, "Equipment 16", 7, 50, 5, null, 28 },
                    { 17, 1, 4.72m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1889), "Description for Equipment 17", 2, "equipment17.jpg", false, "Equipment 17", 4, 50, 5, null, 21 },
                    { 18, 1, 6.64m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1899), "Description for Equipment 18", 3, "equipment18.jpg", false, "Equipment 18", 3, 50, 5, null, 28 },
                    { 19, 1, 0.21m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1945), "Description for Equipment 19", 7, "equipment19.jpg", false, "Equipment 19", 9, 50, 5, null, 49 },
                    { 20, 1, 2.70m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1954), "Description for Equipment 20", 3, "equipment20.jpg", false, "Equipment 20", 6, 50, 5, null, 31 },
                    { 21, 1, 3.56m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1962), "Description for Equipment 21", 1, "equipment21.jpg", false, "Equipment 21", 1, 50, 5, null, 13 },
                    { 22, 1, 4.34m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1970), "Description for Equipment 22", 2, "equipment22.jpg", false, "Equipment 22", 9, 50, 5, null, 15 },
                    { 23, 1, 9.30m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1979), "Description for Equipment 23", 1, "equipment23.jpg", false, "Equipment 23", 4, 50, 5, null, 45 },
                    { 24, 1, 5.03m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1987), "Description for Equipment 24", 9, "equipment24.jpg", false, "Equipment 24", 9, 50, 5, null, 29 },
                    { 25, 1, 9.46m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(1995), "Description for Equipment 25", 1, "equipment25.jpg", false, "Equipment 25", 3, 50, 5, null, 20 },
                    { 26, 1, 6.88m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2003), "Description for Equipment 26", 1, "equipment26.jpg", false, "Equipment 26", 4, 50, 5, null, 36 },
                    { 27, 1, 3.01m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2011), "Description for Equipment 27", 4, "equipment27.jpg", false, "Equipment 27", 6, 50, 5, null, 14 },
                    { 28, 1, 7.71m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2019), "Description for Equipment 28", 7, "equipment28.jpg", false, "Equipment 28", 7, 50, 5, null, 13 },
                    { 29, 1, 4.38m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2027), "Description for Equipment 29", 4, "equipment29.jpg", false, "Equipment 29", 3, 50, 5, null, 15 },
                    { 30, 1, 0.91m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2036), "Description for Equipment 30", 5, "equipment30.jpg", false, "Equipment 30", 7, 50, 5, null, 16 },
                    { 31, 1, 4.26m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2075), "Description for Equipment 31", 8, "equipment31.jpg", false, "Equipment 31", 5, 50, 5, null, 32 },
                    { 32, 1, 6.04m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2084), "Description for Equipment 32", 9, "equipment32.jpg", false, "Equipment 32", 2, 50, 5, null, 10 },
                    { 33, 1, 8.41m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2092), "Description for Equipment 33", 7, "equipment33.jpg", false, "Equipment 33", 2, 50, 5, null, 11 },
                    { 34, 1, 6.54m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2102), "Description for Equipment 34", 5, "equipment34.jpg", false, "Equipment 34", 9, 50, 5, null, 27 },
                    { 35, 1, 0.62m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2110), "Description for Equipment 35", 2, "equipment35.jpg", false, "Equipment 35", 1, 50, 5, null, 20 },
                    { 36, 1, 6.17m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2118), "Description for Equipment 36", 9, "equipment36.jpg", false, "Equipment 36", 8, 50, 5, null, 28 },
                    { 37, 1, 5.40m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2126), "Description for Equipment 37", 7, "equipment37.jpg", false, "Equipment 37", 8, 50, 5, null, 18 },
                    { 38, 1, 5.53m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2133), "Description for Equipment 38", 3, "equipment38.jpg", false, "Equipment 38", 1, 50, 5, null, 15 },
                    { 39, 1, 3.34m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2142), "Description for Equipment 39", 5, "equipment39.jpg", false, "Equipment 39", 9, 50, 5, null, 22 },
                    { 40, 1, 7.31m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2150), "Description for Equipment 40", 6, "equipment40.jpg", false, "Equipment 40", 9, 50, 5, null, 33 },
                    { 41, 1, 4.62m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2184), "Description for Equipment 41", 5, "equipment41.jpg", false, "Equipment 41", 5, 50, 5, null, 11 },
                    { 42, 1, 1.69m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2192), "Description for Equipment 42", 7, "equipment42.jpg", false, "Equipment 42", 8, 50, 5, null, 38 },
                    { 43, 1, 7.49m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2200), "Description for Equipment 43", 7, "equipment43.jpg", false, "Equipment 43", 4, 50, 5, null, 10 },
                    { 44, 1, 8.86m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2208), "Description for Equipment 44", 9, "equipment44.jpg", false, "Equipment 44", 1, 50, 5, null, 27 },
                    { 45, 1, 7.98m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2216), "Description for Equipment 45", 3, "equipment45.jpg", false, "Equipment 45", 4, 50, 5, null, 39 },
                    { 46, 1, 0.06m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2224), "Description for Equipment 46", 5, "equipment46.jpg", false, "Equipment 46", 1, 50, 5, null, 33 },
                    { 47, 1, 5.26m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2232), "Description for Equipment 47", 8, "equipment47.jpg", false, "Equipment 47", 6, 50, 5, null, 27 },
                    { 48, 1, 5.34m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2240), "Description for Equipment 48", 4, "equipment48.jpg", false, "Equipment 48", 8, 50, 5, null, 45 },
                    { 49, 1, 4.35m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2248), "Description for Equipment 49", 3, "equipment49.jpg", false, "Equipment 49", 9, 50, 5, null, 14 },
                    { 50, 1, 0.77m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2256), "Description for Equipment 50", 3, "equipment50.jpg", false, "Equipment 50", 9, 50, 5, null, 44 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "DatePlaced", "IsActive", "Status", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 25, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2355), true, "returned", 59.94m, 3 },
                    { 2, new DateTime(2025, 1, 27, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2358), true, "paid", 89.85m, 4 },
                    { 3, new DateTime(2025, 1, 30, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2360), true, "rented", 29.97m, 4 },
                    { 4, new DateTime(2025, 1, 28, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2362), true, "rented", 19.98m, 5 },
                    { 5, new DateTime(2025, 1, 31, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2363), true, "returned", 99.90m, 5 },
                    { 6, new DateTime(2025, 2, 1, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2365), true, "rented", 49.95m, 6 },
                    { 7, new DateTime(2025, 2, 2, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2367), true, "returned", 69.93m, 7 },
                    { 8, new DateTime(2025, 2, 3, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2369), true, "paid", 39.96m, 8 },
                    { 9, new DateTime(2025, 1, 29, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2370), true, "returned", 149.85m, 9 },
                    { 10, new DateTime(2025, 1, 26, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2372), true, "returned", 29.97m, 10 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
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
                table: "CartItems",
                columns: new[] { "ID", "CartID", "EndDate", "EquipmentID", "EquipmentID1", "Quantity", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 1, 30, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2591), 1, null, 2, new DateTime(2025, 1, 29, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2589) },
                    { 2, 1, new DateTime(2025, 1, 30, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2595), 2, null, 1, new DateTime(2025, 1, 29, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2594) },
                    { 3, 2, new DateTime(2025, 1, 31, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2598), 3, null, 1, new DateTime(2025, 1, 30, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2596) },
                    { 4, 3, new DateTime(2025, 2, 1, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2600), 1, null, 3, new DateTime(2025, 1, 31, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2599) },
                    { 5, 3, new DateTime(2025, 2, 1, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2602), 2, null, 2, new DateTime(2025, 1, 31, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2601) },
                    { 6, 4, new DateTime(2025, 2, 2, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2606), 2, null, 1, new DateTime(2025, 2, 1, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2605) },
                    { 7, 4, new DateTime(2025, 2, 2, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2608), 3, null, 1, new DateTime(2025, 2, 1, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2607) },
                    { 8, 5, new DateTime(2025, 2, 3, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2610), 1, null, 2, new DateTime(2025, 2, 2, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2609) },
                    { 9, 6, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2613), 3, null, 3, new DateTime(2025, 2, 3, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2612) },
                    { 10, 7, new DateTime(2025, 2, 5, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2615), 2, null, 1, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2614) }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "ID", "CostPerUse", "EndDate", "EquipmentID", "EquipmentID1", "OrderID", "Price", "Quantity", "StartDate" },
                values: new object[,]
                {
                    { 1, 2.99m, new DateTime(2025, 1, 26, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2424), 1, null, 1, 5.98m, 2, new DateTime(2025, 1, 25, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2419) },
                    { 2, 4.99m, new DateTime(2025, 1, 27, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2429), 3, null, 1, 4.99m, 1, new DateTime(2025, 1, 25, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2427) },
                    { 3, 3.49m, new DateTime(2025, 1, 28, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2432), 2, null, 2, 10.47m, 3, new DateTime(2025, 1, 27, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2431) },
                    { 4, 2.99m, new DateTime(2025, 1, 29, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2435), 1, null, 2, 11.96m, 4, new DateTime(2025, 1, 27, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2434) },
                    { 5, 4.99m, new DateTime(2025, 1, 31, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2439), 3, null, 3, 9.98m, 2, new DateTime(2025, 1, 30, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2438) },
                    { 6, 2.99m, new DateTime(2025, 1, 29, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2443), 1, null, 4, 2.99m, 1, new DateTime(2025, 1, 28, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2442) },
                    { 7, 3.49m, new DateTime(2025, 2, 2, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2446), 2, null, 5, 17.45m, 5, new DateTime(2025, 1, 31, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2445) },
                    { 8, 4.99m, new DateTime(2025, 2, 3, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2449), 3, null, 6, 14.97m, 3, new DateTime(2025, 2, 1, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2448) },
                    { 9, 2.99m, new DateTime(2025, 2, 5, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2452), 1, null, 7, 5.98m, 2, new DateTime(2025, 2, 2, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2451) },
                    { 10, 3.49m, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2455), 2, null, 8, 10.47m, 3, new DateTime(2025, 2, 3, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2454) },
                    { 11, 4.99m, new DateTime(2025, 1, 31, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2458), 3, null, 9, 4.99m, 1, new DateTime(2025, 1, 29, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2457) },
                    { 12, 2.99m, new DateTime(2025, 1, 30, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2461), 1, null, 9, 14.95m, 5, new DateTime(2025, 1, 29, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2460) },
                    { 13, 3.49m, new DateTime(2025, 1, 27, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2464), 2, null, 10, 6.98m, 2, new DateTime(2025, 1, 26, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2463) }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ID", "DateAdded", "Description", "IsDeleted", "NumberOfStars", "OrderItemID" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 26, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2490), "Great quality and very durable!", false, 4.5m, 1 },
                    { 2, new DateTime(2025, 1, 27, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2494), "Not as expected, could be better.", false, 2.0m, 2 },
                    { 3, new DateTime(2025, 1, 28, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2496), "Perfect for my needs, highly recommended!", false, 5.0m, 3 },
                    { 4, new DateTime(2025, 1, 29, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2498), "Good value for the price.", false, 4.0m, 4 },
                    { 5, new DateTime(2025, 1, 30, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2500), "Satisfactory but delivery was delayed.", false, 3.0m, 5 },
                    { 6, new DateTime(2025, 1, 31, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2502), "Excellent performance and quality.", false, 5.0m, 6 },
                    { 7, new DateTime(2025, 2, 1, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2504), "Decent product but could use some improvements.", false, 3.5m, 7 },
                    { 8, new DateTime(2025, 2, 2, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2506), "Very satisfied with the purchase.", false, 4.5m, 8 },
                    { 9, new DateTime(2025, 2, 3, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2507), "The item was okay, nothing special.", false, 3.0m, 9 },
                    { 10, new DateTime(2025, 2, 4, 20, 1, 25, 285, DateTimeKind.Local).AddTicks(2510), "Amazing product! Will buy again.", false, 5.0m, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartID",
                table: "CartItems",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_EquipmentID",
                table: "CartItems",
                column: "EquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_EquipmentID1",
                table: "CartItems",
                column: "EquipmentID1");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserID",
                table: "Carts",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Damages_OrderItemID",
                table: "Damages",
                column: "OrderItemID");

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
                name: "IX_OrderItems_EquipmentID",
                table: "OrderItems",
                column: "EquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_EquipmentID1",
                table: "OrderItems",
                column: "EquipmentID1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderID",
                table: "OrderItems",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_OrderItemID",
                table: "Reviews",
                column: "OrderItemID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleID",
                table: "UserRoles",
                column: "RoleID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Damages");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "EquipmentCategories");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

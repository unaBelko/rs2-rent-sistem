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
                    EquipmentID1 = table.Column<int>(type: "int", nullable: true)//todo: delete
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
                    { 1, "una.belko+radnik@edu.fit.ba", "Una", true, "Radnik", "LN6gh3VQQyuhR3i4WgSqgkrNLNXTqZBCSa11ladbSNs=", "0038763222111", "ghyprCsz4gkzTGQhAQOzUw==" },
                    { 2, "una.belko+shopping@edu.fit.ba", "Una", true, "Shopping", "LN6gh3VQQyuhR3i4WgSqgkrNLNXTqZBCSa11ladbSNs=", "0038763222111", "ghyprCsz4gkzTGQhAQOzUw==" },
                    { 3, "michael.johnson+user@rental.com", "Michael", true, "Johnson", "LN6gh3VQQyuhR3i4WgSqgkrNLNXTqZBCSa11ladbSNs=", "555-8765", "ghyprCsz4gkzTGQhAQOzUw==" },
                    { 4, "emily.davis+user@rental.com", "Emily", true, "Davis", "LN6gh3VQQyuhR3i4WgSqgkrNLNXTqZBCSa11ladbSNs=", "555-4321", "ghyprCsz4gkzTGQhAQOzUw==" },
                    { 5, "william.brown+user@rental.com", "William", true, "Brown", "LN6gh3VQQyuhR3i4WgSqgkrNLNXTqZBCSa11ladbSNs=", "555-6789", "ghyprCsz4gkzTGQhAQOzUw==" },
                    { 6, "ava.wilson+user@rental.com", "Ava", true, "Wilson", "LN6gh3VQQyuhR3i4WgSqgkrNLNXTqZBCSa11ladbSNs=", "555-2345", "ghyprCsz4gkzTGQhAQOzUw==" },
                    { 7, "james.taylor+user@rental.com", "James", true, "Taylor", "LN6gh3VQQyuhR3i4WgSqgkrNLNXTqZBCSa11ladbSNs=", "555-7890", "ghyprCsz4gkzTGQhAQOzUw==" },
                    { 8, "olivia.anderson+user@rental.com", "Olivia", true, "Anderson", "LN6gh3VQQyuhR3i4WgSqgkrNLNXTqZBCSa11ladbSNs=", "555-3456", "ghyprCsz4gkzTGQhAQOzUw==" },
                    { 9, "benjamin.thomas+user@rental.com", "Benjamin", true, "Thomas", "LN6gh3VQQyuhR3i4WgSqgkrNLNXTqZBCSa11ladbSNs=", "555-9012", "ghyprCsz4gkzTGQhAQOzUw==" },
                    { 10, "sophia.moore+user@rental.com", "Sophia", true, "Moore", "LN6gh3VQQyuhR3i4WgSqgkrNLNXTqZBCSa11ladbSNs=", "555-6543", "ghyprCsz4gkzTGQhAQOzUw==" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "ID", "DateAdded", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 30, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4655), 45.75m, 2 },
                    { 2, new DateTime(2025, 1, 31, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4658), 120.00m, 3 },
                    { 3, new DateTime(2025, 2, 1, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4660), 65.30m, 4 },
                    { 4, new DateTime(2025, 2, 2, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4662), 78.40m, 5 },
                    { 5, new DateTime(2025, 2, 3, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4664), 52.10m, 6 },
                    { 6, new DateTime(2025, 2, 4, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4666), 98.25m, 7 },
                    { 7, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4667), 36.60m, 8 }
                });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "ID", "AddedByUserID", "CostPerUse", "DateAdded", "Description", "EquipmentCategoryId", "ImageUrl", "IsDeleted", "ItemName", "ManufacturerID", "MaxQuantity", "MinQuantity", "Photo", "StockQuantity" },
                values: new object[,]
                {
                    { 1, 1, 2.99m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(3681), "Official size and weight.", 1, "soccerball.jpg", false, "Soccer Ball", 1, 50, 5, null, 30 },
                    { 2, 1, 3.49m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(3732), "High-quality leather basketball.", 2, "basketball.jpg", false, "Basketball", 2, 40, 5, null, 20 },
                    { 3, 1, 4.99m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(3765), "Lightweight racket for professional use.", 3, "tennisracket.jpg", false, "Tennis Racket", 3, 25, 2, null, 15 },
                    { 4, 1, 0.74m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(3824), "Description for Equipment 4", 8, "equipment4.jpg", false, "Equipment 4", 2, 50, 5, null, 25 },
                    { 5, 1, 0.87m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(3841), "Description for Equipment 5", 1, "equipment5.jpg", false, "Equipment 5", 3, 50, 5, null, 27 },
                    { 6, 1, 1.72m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(3851), "Description for Equipment 6", 1, "equipment6.jpg", false, "Equipment 6", 8, 50, 5, null, 44 },
                    { 7, 1, 2.73m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(3859), "Description for Equipment 7", 3, "equipment7.jpg", false, "Equipment 7", 8, 50, 5, null, 44 },
                    { 8, 1, 1.32m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(3867), "Description for Equipment 8", 3, "equipment8.jpg", false, "Equipment 8", 1, 50, 5, null, 45 },
                    { 9, 1, 7.08m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(3875), "Description for Equipment 9", 8, "equipment9.jpg", false, "Equipment 9", 6, 50, 5, null, 13 },
                    { 10, 1, 9.68m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(3884), "Description for Equipment 10", 1, "equipment10.jpg", false, "Equipment 10", 9, 50, 5, null, 48 },
                    { 11, 1, 6.03m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(3893), "Description for Equipment 11", 9, "equipment11.jpg", false, "Equipment 11", 2, 50, 5, null, 47 },
                    { 12, 1, 8.97m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(3900), "Description for Equipment 12", 9, "equipment12.jpg", false, "Equipment 12", 3, 50, 5, null, 23 },
                    { 13, 1, 0.04m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(3910), "Description for Equipment 13", 4, "equipment13.jpg", false, "Equipment 13", 9, 50, 5, null, 28 },
                    { 14, 1, 1.88m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(3918), "Description for Equipment 14", 4, "equipment14.jpg", false, "Equipment 14", 7, 50, 5, null, 15 },
                    { 15, 1, 1.07m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(3959), "Description for Equipment 15", 2, "equipment15.jpg", false, "Equipment 15", 5, 50, 5, null, 23 },
                    { 16, 1, 0.20m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(3967), "Description for Equipment 16", 8, "equipment16.jpg", false, "Equipment 16", 7, 50, 5, null, 30 },
                    { 17, 1, 9.77m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(3975), "Description for Equipment 17", 6, "equipment17.jpg", false, "Equipment 17", 2, 50, 5, null, 14 },
                    { 18, 1, 9.30m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(3984), "Description for Equipment 18", 3, "equipment18.jpg", false, "Equipment 18", 4, 50, 5, null, 21 },
                    { 19, 1, 3.21m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(3992), "Description for Equipment 19", 7, "equipment19.jpg", false, "Equipment 19", 5, 50, 5, null, 34 },
                    { 20, 1, 0.64m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(3999), "Description for Equipment 20", 3, "equipment20.jpg", false, "Equipment 20", 4, 50, 5, null, 12 },
                    { 21, 1, 1.40m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4008), "Description for Equipment 21", 7, "equipment21.jpg", false, "Equipment 21", 1, 50, 5, null, 45 },
                    { 22, 1, 3.87m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4015), "Description for Equipment 22", 9, "equipment22.jpg", false, "Equipment 22", 6, 50, 5, null, 20 },
                    { 23, 1, 7.28m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4023), "Description for Equipment 23", 4, "equipment23.jpg", false, "Equipment 23", 7, 50, 5, null, 10 },
                    { 24, 1, 5.10m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4031), "Description for Equipment 24", 2, "equipment24.jpg", false, "Equipment 24", 1, 50, 5, null, 38 },
                    { 25, 1, 6.14m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4039), "Description for Equipment 25", 4, "equipment25.jpg", false, "Equipment 25", 2, 50, 5, null, 24 },
                    { 26, 1, 7.08m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4065), "Description for Equipment 26", 8, "equipment26.jpg", false, "Equipment 26", 7, 50, 5, null, 42 },
                    { 27, 1, 6.05m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4073), "Description for Equipment 27", 2, "equipment27.jpg", false, "Equipment 27", 7, 50, 5, null, 20 },
                    { 28, 1, 3.85m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4081), "Description for Equipment 28", 7, "equipment28.jpg", false, "Equipment 28", 6, 50, 5, null, 38 },
                    { 29, 1, 9.41m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4089), "Description for Equipment 29", 9, "equipment29.jpg", false, "Equipment 29", 2, 50, 5, null, 43 },
                    { 30, 1, 9.54m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4097), "Description for Equipment 30", 5, "equipment30.jpg", false, "Equipment 30", 3, 50, 5, null, 14 },
                    { 31, 1, 7.30m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4104), "Description for Equipment 31", 9, "equipment31.jpg", false, "Equipment 31", 4, 50, 5, null, 40 },
                    { 32, 1, 7.15m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4112), "Description for Equipment 32", 2, "equipment32.jpg", false, "Equipment 32", 7, 50, 5, null, 10 },
                    { 33, 1, 0.19m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4120), "Description for Equipment 33", 6, "equipment33.jpg", false, "Equipment 33", 2, 50, 5, null, 29 },
                    { 34, 1, 4.11m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4128), "Description for Equipment 34", 3, "equipment34.jpg", false, "Equipment 34", 1, 50, 5, null, 47 },
                    { 35, 1, 3.78m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4136), "Description for Equipment 35", 9, "equipment35.jpg", false, "Equipment 35", 4, 50, 5, null, 17 },
                    { 36, 1, 0.06m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4144), "Description for Equipment 36", 4, "equipment36.jpg", false, "Equipment 36", 8, 50, 5, null, 39 },
                    { 37, 1, 3.45m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4173), "Description for Equipment 37", 1, "equipment37.jpg", false, "Equipment 37", 3, 50, 5, null, 11 },
                    { 38, 1, 0.17m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4180), "Description for Equipment 38", 1, "equipment38.jpg", false, "Equipment 38", 7, 50, 5, null, 41 },
                    { 39, 1, 3.43m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4188), "Description for Equipment 39", 8, "equipment39.jpg", false, "Equipment 39", 1, 50, 5, null, 20 },
                    { 40, 1, 3.45m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4196), "Description for Equipment 40", 6, "equipment40.jpg", false, "Equipment 40", 4, 50, 5, null, 18 },
                    { 41, 1, 7.28m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4204), "Description for Equipment 41", 9, "equipment41.jpg", false, "Equipment 41", 1, 50, 5, null, 20 },
                    { 42, 1, 5.70m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4212), "Description for Equipment 42", 1, "equipment42.jpg", false, "Equipment 42", 2, 50, 5, null, 13 },
                    { 43, 1, 4.05m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4220), "Description for Equipment 43", 8, "equipment43.jpg", false, "Equipment 43", 7, 50, 5, null, 40 },
                    { 44, 1, 3.00m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4227), "Description for Equipment 44", 1, "equipment44.jpg", false, "Equipment 44", 8, 50, 5, null, 34 },
                    { 45, 1, 0.67m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4235), "Description for Equipment 45", 2, "equipment45.jpg", false, "Equipment 45", 2, 50, 5, null, 37 },
                    { 46, 1, 6.61m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4309), "Description for Equipment 46", 6, "equipment46.jpg", false, "Equipment 46", 7, 50, 5, null, 38 },
                    { 47, 1, 6.11m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4317), "Description for Equipment 47", 9, "equipment47.jpg", false, "Equipment 47", 6, 50, 5, null, 10 },
                    { 48, 1, 0.77m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4345), "Description for Equipment 48", 8, "equipment48.jpg", false, "Equipment 48", 2, 50, 5, null, 14 },
                    { 49, 1, 1.48m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4352), "Description for Equipment 49", 6, "equipment49.jpg", false, "Equipment 49", 6, 50, 5, null, 38 },
                    { 50, 1, 8.23m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4361), "Description for Equipment 50", 4, "equipment50.jpg", false, "Equipment 50", 6, 50, 5, null, 41 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "DatePlaced", "IsActive", "Status", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 26, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4423), true, "returned", 59.94m, 3 },
                    { 2, new DateTime(2025, 1, 28, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4427), true, "paid", 89.85m, 4 },
                    { 3, new DateTime(2025, 1, 31, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4428), true, "rented", 29.97m, 4 },
                    { 4, new DateTime(2025, 1, 29, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4430), true, "rented", 19.98m, 5 },
                    { 5, new DateTime(2025, 2, 1, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4432), true, "returned", 99.90m, 5 },
                    { 6, new DateTime(2025, 2, 2, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4433), true, "rented", 49.95m, 6 },
                    { 7, new DateTime(2025, 2, 3, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4435), true, "returned", 69.93m, 7 },
                    { 8, new DateTime(2025, 2, 4, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4437), true, "paid", 39.96m, 8 },
                    { 9, new DateTime(2025, 1, 30, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4438), true, "returned", 149.85m, 9 },
                    { 10, new DateTime(2025, 1, 27, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4440), true, "returned", 29.97m, 10 }
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
                    { 1, 1, new DateTime(2025, 1, 31, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4690), 1, null, 2, new DateTime(2025, 1, 30, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4683) },
                    { 2, 1, new DateTime(2025, 1, 31, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4694), 2, null, 1, new DateTime(2025, 1, 30, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4693) },
                    { 3, 2, new DateTime(2025, 2, 1, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4696), 3, null, 1, new DateTime(2025, 1, 31, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4695) },
                    { 4, 3, new DateTime(2025, 2, 2, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4699), 1, null, 3, new DateTime(2025, 2, 1, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4698) },
                    { 5, 3, new DateTime(2025, 2, 2, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4701), 2, null, 2, new DateTime(2025, 2, 1, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4700) },
                    { 6, 4, new DateTime(2025, 2, 3, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4704), 2, null, 1, new DateTime(2025, 2, 2, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4703) },
                    { 7, 4, new DateTime(2025, 2, 3, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4706), 3, null, 1, new DateTime(2025, 2, 2, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4705) },
                    { 8, 5, new DateTime(2025, 2, 4, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4709), 1, null, 2, new DateTime(2025, 2, 3, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4708) },
                    { 9, 6, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4711), 3, null, 3, new DateTime(2025, 2, 4, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4710) },
                    { 10, 7, new DateTime(2025, 2, 6, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4714), 2, null, 1, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4713) }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "ID", "CostPerUse", "EndDate", "EquipmentID", "EquipmentID1", "OrderID", "Price", "Quantity", "StartDate" },
                values: new object[,]
                {
                    { 1, 2.99m, new DateTime(2025, 1, 27, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4501), 1, null, 1, 5.98m, 2, new DateTime(2025, 1, 26, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4497) },
                    { 2, 4.99m, new DateTime(2025, 1, 28, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4506), 3, null, 1, 4.99m, 1, new DateTime(2025, 1, 26, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4505) },
                    { 3, 3.49m, new DateTime(2025, 1, 29, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4509), 2, null, 2, 10.47m, 3, new DateTime(2025, 1, 28, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4508) },
                    { 4, 2.99m, new DateTime(2025, 1, 30, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4513), 1, null, 2, 11.96m, 4, new DateTime(2025, 1, 28, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4511) },
                    { 5, 4.99m, new DateTime(2025, 2, 1, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4516), 3, null, 3, 9.98m, 2, new DateTime(2025, 1, 31, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4515) },
                    { 6, 2.99m, new DateTime(2025, 1, 30, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4520), 1, null, 4, 2.99m, 1, new DateTime(2025, 1, 29, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4519) },
                    { 7, 3.49m, new DateTime(2025, 2, 3, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4523), 2, null, 5, 17.45m, 5, new DateTime(2025, 2, 1, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4522) },
                    { 8, 4.99m, new DateTime(2025, 2, 4, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4526), 3, null, 6, 14.97m, 3, new DateTime(2025, 2, 2, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4525) },
                    { 9, 2.99m, new DateTime(2025, 2, 6, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4528), 1, null, 7, 5.98m, 2, new DateTime(2025, 2, 3, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4527) },
                    { 10, 3.49m, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4532), 2, null, 8, 10.47m, 3, new DateTime(2025, 2, 4, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4531) },
                    { 11, 4.99m, new DateTime(2025, 2, 1, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4539), 3, null, 9, 4.99m, 1, new DateTime(2025, 1, 30, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4537) },
                    { 12, 2.99m, new DateTime(2025, 1, 31, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4542), 1, null, 9, 14.95m, 5, new DateTime(2025, 1, 30, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4541) },
                    { 13, 3.49m, new DateTime(2025, 1, 28, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4544), 2, null, 10, 6.98m, 2, new DateTime(2025, 1, 27, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4543) }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ID", "DateAdded", "Description", "IsDeleted", "NumberOfStars", "OrderItemID" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 27, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4601), "Great quality and very durable!", false, 4.5m, 1 },
                    { 2, new DateTime(2025, 1, 28, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4619), "Not as expected, could be better.", false, 2.0m, 2 },
                    { 3, new DateTime(2025, 1, 29, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4622), "Perfect for my needs, highly recommended!", false, 5.0m, 3 },
                    { 4, new DateTime(2025, 1, 30, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4623), "Good value for the price.", false, 4.0m, 4 },
                    { 5, new DateTime(2025, 1, 31, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4625), "Satisfactory but delivery was delayed.", false, 3.0m, 5 },
                    { 6, new DateTime(2025, 2, 1, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4627), "Excellent performance and quality.", false, 5.0m, 6 },
                    { 7, new DateTime(2025, 2, 2, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4630), "Decent product but could use some improvements.", false, 3.5m, 7 },
                    { 8, new DateTime(2025, 2, 3, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4631), "Very satisfied with the purchase.", false, 4.5m, 8 },
                    { 9, new DateTime(2025, 2, 4, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4633), "The item was okay, nothing special.", false, 3.0m, 9 },
                    { 10, new DateTime(2025, 2, 5, 21, 4, 58, 307, DateTimeKind.Local).AddTicks(4635), "Amazing product! Will buy again.", false, 5.0m, 10 }
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
                column: "OrderItemID",
                unique: true);

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

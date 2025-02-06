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
                    CostPerUse = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsReviewedByUser = table.Column<bool>(type: "bit", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
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
                    { 1, "una.belko+radnik@edu.fit.ba", "Una", true, "Radnik", "Ft0sPfpCpbi3lC5nJe7nCpp2aVBxCUUVyWGi5EiDY20=", "0038763222111", "cLrsheOFupkD6F42+n+UuA==" },
                    { 2, "una.belko+shopping@edu.fit.ba", "Una", true, "Shopping", "Ft0sPfpCpbi3lC5nJe7nCpp2aVBxCUUVyWGi5EiDY20=", "0038763222111", "cLrsheOFupkD6F42+n+UuA==" },
                    { 3, "michael.johnson+user@rental.com", "Michael", true, "Johnson", "Ft0sPfpCpbi3lC5nJe7nCpp2aVBxCUUVyWGi5EiDY20=", "555-8765", "cLrsheOFupkD6F42+n+UuA==" },
                    { 4, "emily.davis+user@rental.com", "Emily", true, "Davis", "Ft0sPfpCpbi3lC5nJe7nCpp2aVBxCUUVyWGi5EiDY20=", "555-4321", "cLrsheOFupkD6F42+n+UuA==" },
                    { 5, "william.brown+user@rental.com", "William", true, "Brown", "Ft0sPfpCpbi3lC5nJe7nCpp2aVBxCUUVyWGi5EiDY20=", "555-6789", "cLrsheOFupkD6F42+n+UuA==" },
                    { 6, "ava.wilson+user@rental.com", "Ava", true, "Wilson", "Ft0sPfpCpbi3lC5nJe7nCpp2aVBxCUUVyWGi5EiDY20=", "555-2345", "cLrsheOFupkD6F42+n+UuA==" },
                    { 7, "james.taylor+user@rental.com", "James", true, "Taylor", "Ft0sPfpCpbi3lC5nJe7nCpp2aVBxCUUVyWGi5EiDY20=", "555-7890", "cLrsheOFupkD6F42+n+UuA==" },
                    { 8, "olivia.anderson+user@rental.com", "Olivia", true, "Anderson", "Ft0sPfpCpbi3lC5nJe7nCpp2aVBxCUUVyWGi5EiDY20=", "555-3456", "cLrsheOFupkD6F42+n+UuA==" },
                    { 9, "benjamin.thomas+user@rental.com", "Benjamin", true, "Thomas", "Ft0sPfpCpbi3lC5nJe7nCpp2aVBxCUUVyWGi5EiDY20=", "555-9012", "cLrsheOFupkD6F42+n+UuA==" },
                    { 10, "sophia.moore+user@rental.com", "Sophia", true, "Moore", "Ft0sPfpCpbi3lC5nJe7nCpp2aVBxCUUVyWGi5EiDY20=", "555-6543", "cLrsheOFupkD6F42+n+UuA==" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "ID", "DateAdded", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 31, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2623), 45.75m, 2 },
                    { 2, new DateTime(2025, 2, 1, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2627), 120.00m, 3 },
                    { 3, new DateTime(2025, 2, 2, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2629), 65.30m, 4 },
                    { 4, new DateTime(2025, 2, 3, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2631), 78.40m, 5 },
                    { 5, new DateTime(2025, 2, 4, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2633), 52.10m, 6 },
                    { 6, new DateTime(2025, 2, 5, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2635), 98.25m, 7 },
                    { 7, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2637), 36.60m, 8 }
                });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "ID", "AddedByUserID", "CostPerUse", "DateAdded", "Description", "EquipmentCategoryId", "ImageUrl", "IsDeleted", "ItemName", "ManufacturerID", "MaxQuantity", "MinQuantity", "Photo", "StockQuantity" },
                values: new object[,]
                {
                    { 1, 1, 2.99m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1624), "Official size and weight.", 1, "soccerball.jpg", false, "Soccer Ball", 1, 50, 5, null, 30 },
                    { 2, 1, 3.49m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1671), "High-quality leather basketball.", 2, "basketball.jpg", false, "Basketball", 2, 40, 5, null, 20 },
                    { 3, 1, 4.99m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1673), "Lightweight racket for professional use.", 3, "tennisracket.jpg", false, "Tennis Racket", 3, 25, 2, null, 15 },
                    { 4, 1, 9.98m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1773), "Description for Equipment 4", 7, "equipment4.jpg", false, "Equipment 4", 1, 50, 5, null, 27 },
                    { 5, 1, 6.04m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1789), "Description for Equipment 5", 9, "equipment5.jpg", false, "Equipment 5", 7, 50, 5, null, 13 },
                    { 6, 1, 4.65m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1799), "Description for Equipment 6", 9, "equipment6.jpg", false, "Equipment 6", 4, 50, 5, null, 25 },
                    { 7, 1, 4.48m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1807), "Description for Equipment 7", 7, "equipment7.jpg", false, "Equipment 7", 2, 50, 5, null, 15 },
                    { 8, 1, 5.55m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1816), "Description for Equipment 8", 4, "equipment8.jpg", false, "Equipment 8", 8, 50, 5, null, 39 },
                    { 9, 1, 0.40m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1824), "Description for Equipment 9", 5, "equipment9.jpg", false, "Equipment 9", 6, 50, 5, null, 26 },
                    { 10, 1, 2.22m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1834), "Description for Equipment 10", 4, "equipment10.jpg", false, "Equipment 10", 6, 50, 5, null, 36 },
                    { 11, 1, 5.14m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1842), "Description for Equipment 11", 8, "equipment11.jpg", false, "Equipment 11", 2, 50, 5, null, 15 },
                    { 12, 1, 6.59m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1851), "Description for Equipment 12", 9, "equipment12.jpg", false, "Equipment 12", 4, 50, 5, null, 22 },
                    { 13, 1, 8.03m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1904), "Description for Equipment 13", 8, "equipment13.jpg", false, "Equipment 13", 4, 50, 5, null, 14 },
                    { 14, 1, 1.42m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1913), "Description for Equipment 14", 2, "equipment14.jpg", false, "Equipment 14", 8, 50, 5, null, 41 },
                    { 15, 1, 0.58m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1922), "Description for Equipment 15", 1, "equipment15.jpg", false, "Equipment 15", 4, 50, 5, null, 26 },
                    { 16, 1, 3.25m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1930), "Description for Equipment 16", 7, "equipment16.jpg", false, "Equipment 16", 8, 50, 5, null, 27 },
                    { 17, 1, 6.73m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1939), "Description for Equipment 17", 7, "equipment17.jpg", false, "Equipment 17", 9, 50, 5, null, 36 },
                    { 18, 1, 1.61m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1949), "Description for Equipment 18", 7, "equipment18.jpg", false, "Equipment 18", 5, 50, 5, null, 17 },
                    { 19, 1, 5.87m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1958), "Description for Equipment 19", 6, "equipment19.jpg", false, "Equipment 19", 3, 50, 5, null, 22 },
                    { 20, 1, 6.63m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1966), "Description for Equipment 20", 1, "equipment20.jpg", false, "Equipment 20", 3, 50, 5, null, 36 },
                    { 21, 1, 2.87m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1974), "Description for Equipment 21", 7, "equipment21.jpg", false, "Equipment 21", 7, 50, 5, null, 48 },
                    { 22, 1, 2.14m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1982), "Description for Equipment 22", 4, "equipment22.jpg", false, "Equipment 22", 8, 50, 5, null, 14 },
                    { 23, 1, 8.08m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(1991), "Description for Equipment 23", 6, "equipment23.jpg", false, "Equipment 23", 5, 50, 5, null, 12 },
                    { 24, 1, 1.19m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2017), "Description for Equipment 24", 3, "equipment24.jpg", false, "Equipment 24", 5, 50, 5, null, 18 },
                    { 25, 1, 5.54m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2025), "Description for Equipment 25", 7, "equipment25.jpg", false, "Equipment 25", 6, 50, 5, null, 26 },
                    { 26, 1, 0.79m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2033), "Description for Equipment 26", 4, "equipment26.jpg", false, "Equipment 26", 2, 50, 5, null, 11 },
                    { 27, 1, 9.21m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2041), "Description for Equipment 27", 7, "equipment27.jpg", false, "Equipment 27", 7, 50, 5, null, 42 },
                    { 28, 1, 7.02m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2049), "Description for Equipment 28", 5, "equipment28.jpg", false, "Equipment 28", 9, 50, 5, null, 13 },
                    { 29, 1, 5.40m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2057), "Description for Equipment 29", 8, "equipment29.jpg", false, "Equipment 29", 7, 50, 5, null, 47 },
                    { 30, 1, 9.00m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2065), "Description for Equipment 30", 9, "equipment30.jpg", false, "Equipment 30", 8, 50, 5, null, 22 },
                    { 31, 1, 8.68m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2073), "Description for Equipment 31", 9, "equipment31.jpg", false, "Equipment 31", 8, 50, 5, null, 30 },
                    { 32, 1, 7.34m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2081), "Description for Equipment 32", 7, "equipment32.jpg", false, "Equipment 32", 8, 50, 5, null, 48 },
                    { 33, 1, 2.16m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2089), "Description for Equipment 33", 6, "equipment33.jpg", false, "Equipment 33", 9, 50, 5, null, 14 },
                    { 34, 1, 9.53m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2098), "Description for Equipment 34", 2, "equipment34.jpg", false, "Equipment 34", 2, 50, 5, null, 33 },
                    { 35, 1, 6.04m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2128), "Description for Equipment 35", 5, "equipment35.jpg", false, "Equipment 35", 2, 50, 5, null, 32 },
                    { 36, 1, 8.82m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2213), "Description for Equipment 36", 6, "equipment36.jpg", false, "Equipment 36", 1, 50, 5, null, 33 },
                    { 37, 1, 6.98m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2222), "Description for Equipment 37", 6, "equipment37.jpg", false, "Equipment 37", 2, 50, 5, null, 46 },
                    { 38, 1, 6.44m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2230), "Description for Equipment 38", 3, "equipment38.jpg", false, "Equipment 38", 6, 50, 5, null, 21 },
                    { 39, 1, 6.71m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2238), "Description for Equipment 39", 6, "equipment39.jpg", false, "Equipment 39", 3, 50, 5, null, 33 },
                    { 40, 1, 3.09m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2246), "Description for Equipment 40", 3, "equipment40.jpg", false, "Equipment 40", 4, 50, 5, null, 35 },
                    { 41, 1, 1.85m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2254), "Description for Equipment 41", 5, "equipment41.jpg", false, "Equipment 41", 1, 50, 5, null, 13 },
                    { 42, 1, 9.14m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2262), "Description for Equipment 42", 4, "equipment42.jpg", false, "Equipment 42", 5, 50, 5, null, 12 },
                    { 43, 1, 4.33m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2270), "Description for Equipment 43", 4, "equipment43.jpg", false, "Equipment 43", 6, 50, 5, null, 41 },
                    { 44, 1, 5.70m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2278), "Description for Equipment 44", 9, "equipment44.jpg", false, "Equipment 44", 9, 50, 5, null, 37 },
                    { 45, 1, 4.58m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2286), "Description for Equipment 45", 4, "equipment45.jpg", false, "Equipment 45", 1, 50, 5, null, 30 },
                    { 46, 1, 1.09m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2315), "Description for Equipment 46", 2, "equipment46.jpg", false, "Equipment 46", 8, 50, 5, null, 35 },
                    { 47, 1, 2.58m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2323), "Description for Equipment 47", 8, "equipment47.jpg", false, "Equipment 47", 7, 50, 5, null, 34 },
                    { 48, 1, 8.34m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2331), "Description for Equipment 48", 5, "equipment48.jpg", false, "Equipment 48", 3, 50, 5, null, 37 },
                    { 49, 1, 7.81m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2339), "Description for Equipment 49", 3, "equipment49.jpg", false, "Equipment 49", 3, 50, 5, null, 48 },
                    { 50, 1, 7.68m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2347), "Description for Equipment 50", 4, "equipment50.jpg", false, "Equipment 50", 7, 50, 5, null, 25 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "DatePlaced", "IsActive", "Status", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 27, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2421), true, "returned", 59.94m, 3 },
                    { 2, new DateTime(2025, 1, 29, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2425), true, "paid", 89.85m, 4 },
                    { 3, new DateTime(2025, 2, 1, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2427), true, "rented", 29.97m, 4 },
                    { 4, new DateTime(2025, 1, 30, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2428), true, "rented", 19.98m, 5 },
                    { 5, new DateTime(2025, 2, 2, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2430), true, "returned", 99.90m, 5 },
                    { 6, new DateTime(2025, 2, 3, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2432), true, "rented", 49.95m, 6 },
                    { 7, new DateTime(2025, 2, 4, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2433), true, "returned", 69.93m, 7 },
                    { 8, new DateTime(2025, 2, 5, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2436), true, "paid", 39.96m, 2 },
                    { 9, new DateTime(2025, 1, 31, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2437), true, "rented", 149.85m, 2 },
                    { 10, new DateTime(2025, 1, 28, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2439), true, "returned", 29.97m, 2 }
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
                    { 1, 1, new DateTime(2025, 2, 1, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2660), 1, null, 2, new DateTime(2025, 1, 31, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2658) },
                    { 2, 1, new DateTime(2025, 2, 1, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2664), 2, null, 1, new DateTime(2025, 1, 31, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2663) },
                    { 3, 2, new DateTime(2025, 2, 2, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2667), 3, null, 1, new DateTime(2025, 2, 1, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2666) },
                    { 4, 3, new DateTime(2025, 2, 3, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2669), 1, null, 3, new DateTime(2025, 2, 2, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2668) },
                    { 5, 3, new DateTime(2025, 2, 3, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2671), 2, null, 2, new DateTime(2025, 2, 2, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2670) },
                    { 6, 4, new DateTime(2025, 2, 4, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2674), 2, null, 1, new DateTime(2025, 2, 3, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2673) },
                    { 7, 4, new DateTime(2025, 2, 4, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2677), 3, null, 1, new DateTime(2025, 2, 3, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2676) },
                    { 8, 5, new DateTime(2025, 2, 5, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2679), 1, null, 2, new DateTime(2025, 2, 4, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2678) },
                    { 9, 6, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2681), 3, null, 3, new DateTime(2025, 2, 5, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2680) },
                    { 10, 7, new DateTime(2025, 2, 7, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2684), 2, null, 1, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2683) }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "ID", "CostPerUse", "EndDate", "EquipmentID", "EquipmentID1", "IsReviewedByUser", "OrderID", "Price", "Quantity", "StartDate" },
                values: new object[,]
                {
                    { 1, 2.99m, new DateTime(2025, 1, 28, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2495), 1, null, false, 1, 5.98m, 2, new DateTime(2025, 1, 27, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2486) },
                    { 2, 4.99m, new DateTime(2025, 1, 29, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2500), 3, null, false, 1, 4.99m, 1, new DateTime(2025, 1, 27, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2499) },
                    { 3, 3.49m, new DateTime(2025, 1, 30, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2505), 2, null, false, 2, 10.47m, 3, new DateTime(2025, 1, 29, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2504) },
                    { 4, 2.99m, new DateTime(2025, 1, 31, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2508), 1, null, false, 2, 11.96m, 4, new DateTime(2025, 1, 29, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2507) },
                    { 5, 4.99m, new DateTime(2025, 2, 2, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2511), 3, null, false, 3, 9.98m, 2, new DateTime(2025, 2, 1, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2509) },
                    { 6, 2.99m, new DateTime(2025, 1, 31, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2514), 1, null, false, 4, 2.99m, 1, new DateTime(2025, 1, 30, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2513) },
                    { 7, 3.49m, new DateTime(2025, 2, 4, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2517), 2, null, false, 5, 17.45m, 5, new DateTime(2025, 2, 2, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2516) },
                    { 8, 4.99m, new DateTime(2025, 2, 5, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2522), 3, null, false, 6, 14.97m, 3, new DateTime(2025, 2, 3, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2521) },
                    { 9, 2.99m, new DateTime(2025, 2, 7, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2544), 1, null, false, 7, 5.98m, 2, new DateTime(2025, 2, 4, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2543) },
                    { 10, 3.49m, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2548), 2, null, false, 8, 10.47m, 3, new DateTime(2025, 2, 5, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2547) },
                    { 11, 4.99m, new DateTime(2025, 2, 2, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2551), 3, null, false, 9, 4.99m, 1, new DateTime(2025, 1, 31, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2550) },
                    { 12, 2.99m, new DateTime(2025, 2, 1, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2554), 1, null, false, 9, 14.95m, 5, new DateTime(2025, 1, 31, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2553) },
                    { 13, 3.49m, new DateTime(2025, 1, 29, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2557), 2, null, false, 10, 6.98m, 2, new DateTime(2025, 1, 28, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2556) },
                    { 14, 3.49m, new DateTime(2025, 1, 29, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2560), 4, null, true, 10, 6.98m, 2, new DateTime(2025, 1, 28, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2559) }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ID", "DateAdded", "Description", "IsDeleted", "NumberOfStars", "OrderItemID" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 28, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2581), "Great quality and very durable!", false, 4.5m, 1 },
                    { 2, new DateTime(2025, 1, 29, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2588), "Not as expected, could be better.", false, 2.0m, 2 },
                    { 3, new DateTime(2025, 1, 30, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2590), "Perfect for my needs, highly recommended!", false, 5.0m, 3 },
                    { 4, new DateTime(2025, 1, 31, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2592), "Good value for the price.", false, 4.0m, 4 },
                    { 5, new DateTime(2025, 2, 1, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2593), "Satisfactory but delivery was delayed.", false, 3.0m, 5 },
                    { 6, new DateTime(2025, 2, 2, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2596), "Excellent performance and quality.", false, 5.0m, 6 },
                    { 7, new DateTime(2025, 2, 3, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2598), "Decent product but could use some improvements.", false, 3.5m, 7 },
                    { 8, new DateTime(2025, 2, 4, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2599), "Very satisfied with the purchase.", false, 4.5m, 8 },
                    { 9, new DateTime(2025, 2, 5, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2601), "The item was okay, nothing special.", false, 3.0m, 9 },
                    { 10, new DateTime(2025, 2, 6, 22, 44, 50, 117, DateTimeKind.Local).AddTicks(2603), "Amazing product! Will buy again.", false, 5.0m, 14 }
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

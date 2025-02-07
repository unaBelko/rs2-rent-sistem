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
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AverageRating = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
                    { 1, "una.belko+radnik@edu.fit.ba", "Una", true, "Radnik", "BTipVo0Ggceex4ZoHa97/6eHxZ7u4ml8XBoIN3vnhgo=", "0038763222111", "Q3jRl1B5J45ytORAfnfj+Q==" },
                    { 2, "una.belko+shopping@edu.fit.ba", "Una", true, "Shopping", "BTipVo0Ggceex4ZoHa97/6eHxZ7u4ml8XBoIN3vnhgo=", "0038763222111", "Q3jRl1B5J45ytORAfnfj+Q==" },
                    { 3, "michael.johnson+user@rental.com", "Michael", true, "Johnson", "BTipVo0Ggceex4ZoHa97/6eHxZ7u4ml8XBoIN3vnhgo=", "555-8765", "Q3jRl1B5J45ytORAfnfj+Q==" },
                    { 4, "emily.davis+user@rental.com", "Emily", true, "Davis", "BTipVo0Ggceex4ZoHa97/6eHxZ7u4ml8XBoIN3vnhgo=", "555-4321", "Q3jRl1B5J45ytORAfnfj+Q==" },
                    { 5, "william.brown+user@rental.com", "William", true, "Brown", "BTipVo0Ggceex4ZoHa97/6eHxZ7u4ml8XBoIN3vnhgo=", "555-6789", "Q3jRl1B5J45ytORAfnfj+Q==" },
                    { 6, "ava.wilson+user@rental.com", "Ava", true, "Wilson", "BTipVo0Ggceex4ZoHa97/6eHxZ7u4ml8XBoIN3vnhgo=", "555-2345", "Q3jRl1B5J45ytORAfnfj+Q==" },
                    { 7, "james.taylor+user@rental.com", "James", true, "Taylor", "BTipVo0Ggceex4ZoHa97/6eHxZ7u4ml8XBoIN3vnhgo=", "555-7890", "Q3jRl1B5J45ytORAfnfj+Q==" },
                    { 8, "olivia.anderson+user@rental.com", "Olivia", true, "Anderson", "BTipVo0Ggceex4ZoHa97/6eHxZ7u4ml8XBoIN3vnhgo=", "555-3456", "Q3jRl1B5J45ytORAfnfj+Q==" },
                    { 9, "benjamin.thomas+user@rental.com", "Benjamin", true, "Thomas", "BTipVo0Ggceex4ZoHa97/6eHxZ7u4ml8XBoIN3vnhgo=", "555-9012", "Q3jRl1B5J45ytORAfnfj+Q==" },
                    { 10, "sophia.moore+user@rental.com", "Sophia", true, "Moore", "BTipVo0Ggceex4ZoHa97/6eHxZ7u4ml8XBoIN3vnhgo=", "555-6543", "Q3jRl1B5J45ytORAfnfj+Q==" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "ID", "DateAdded", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 1, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2925), 45.75m, 2 },
                    { 2, new DateTime(2025, 2, 2, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2930), 120.00m, 3 },
                    { 3, new DateTime(2025, 2, 3, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2931), 65.30m, 4 },
                    { 4, new DateTime(2025, 2, 4, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2933), 78.40m, 5 },
                    { 5, new DateTime(2025, 2, 5, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2935), 52.10m, 6 },
                    { 6, new DateTime(2025, 2, 6, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2937), 98.25m, 7 },
                    { 7, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2939), 36.60m, 8 }
                });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "ID", "AddedByUserID", "AverageRating", "CostPerUse", "DateAdded", "Description", "EquipmentCategoryId", "ImageUrl", "IsDeleted", "ItemName", "ManufacturerID", "MaxQuantity", "MinQuantity", "Photo", "StockQuantity" },
                values: new object[,]
                {
                    { 1, 1, 0m, 2.99m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2010), "Official size and weight.", 1, "soccerball.jpg", false, "Soccer Ball", 1, 50, 5, null, 30 },
                    { 2, 1, 0m, 3.49m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2055), "High-quality leather basketball.", 2, "basketball.jpg", false, "Basketball", 2, 40, 5, null, 20 },
                    { 3, 1, 0m, 4.99m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2058), "Lightweight racket for professional use.", 3, "tennisracket.jpg", false, "Tennis Racket", 3, 25, 2, null, 15 },
                    { 4, 1, 0m, 9.39m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2134), "Description for Equipment 4", 7, "equipment4.jpg", false, "Equipment 4", 5, 50, 5, null, 19 },
                    { 5, 1, 0m, 7.60m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2146), "Description for Equipment 5", 8, "equipment5.jpg", false, "Equipment 5", 2, 50, 5, null, 10 },
                    { 6, 1, 0m, 8.13m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2156), "Description for Equipment 6", 5, "equipment6.jpg", false, "Equipment 6", 4, 50, 5, null, 37 },
                    { 7, 1, 0m, 2.09m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2166), "Description for Equipment 7", 8, "equipment7.jpg", false, "Equipment 7", 2, 50, 5, null, 45 },
                    { 8, 1, 0m, 8.47m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2175), "Description for Equipment 8", 5, "equipment8.jpg", false, "Equipment 8", 4, 50, 5, null, 34 },
                    { 9, 1, 0m, 4.47m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2184), "Description for Equipment 9", 2, "equipment9.jpg", false, "Equipment 9", 1, 50, 5, null, 49 },
                    { 10, 1, 0m, 6.90m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2214), "Description for Equipment 10", 4, "equipment10.jpg", false, "Equipment 10", 5, 50, 5, null, 48 },
                    { 11, 1, 0m, 8.48m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2224), "Description for Equipment 11", 5, "equipment11.jpg", false, "Equipment 11", 1, 50, 5, null, 23 },
                    { 12, 1, 0m, 2.54m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2233), "Description for Equipment 12", 6, "equipment12.jpg", false, "Equipment 12", 3, 50, 5, null, 11 },
                    { 13, 1, 0m, 9.97m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2241), "Description for Equipment 13", 4, "equipment13.jpg", false, "Equipment 13", 7, 50, 5, null, 42 },
                    { 14, 1, 0m, 4.46m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2250), "Description for Equipment 14", 5, "equipment14.jpg", false, "Equipment 14", 6, 50, 5, null, 23 },
                    { 15, 1, 0m, 1.22m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2259), "Description for Equipment 15", 8, "equipment15.jpg", false, "Equipment 15", 5, 50, 5, null, 25 },
                    { 16, 1, 0m, 6.46m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2268), "Description for Equipment 16", 8, "equipment16.jpg", false, "Equipment 16", 2, 50, 5, null, 33 },
                    { 17, 1, 0m, 7.63m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2277), "Description for Equipment 17", 1, "equipment17.jpg", false, "Equipment 17", 4, 50, 5, null, 47 },
                    { 18, 1, 0m, 8.72m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2287), "Description for Equipment 18", 9, "equipment18.jpg", false, "Equipment 18", 4, 50, 5, null, 48 },
                    { 19, 1, 0m, 7.73m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2296), "Description for Equipment 19", 5, "equipment19.jpg", false, "Equipment 19", 5, 50, 5, null, 36 },
                    { 20, 1, 0m, 5.09m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2327), "Description for Equipment 20", 2, "equipment20.jpg", false, "Equipment 20", 4, 50, 5, null, 49 },
                    { 21, 1, 0m, 4.23m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2336), "Description for Equipment 21", 3, "equipment21.jpg", false, "Equipment 21", 6, 50, 5, null, 22 },
                    { 22, 1, 0m, 9.95m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2345), "Description for Equipment 22", 6, "equipment22.jpg", false, "Equipment 22", 8, 50, 5, null, 24 },
                    { 23, 1, 0m, 5.27m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2354), "Description for Equipment 23", 8, "equipment23.jpg", false, "Equipment 23", 1, 50, 5, null, 47 },
                    { 24, 1, 0m, 4.92m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2363), "Description for Equipment 24", 4, "equipment24.jpg", false, "Equipment 24", 9, 50, 5, null, 39 },
                    { 25, 1, 0m, 5.43m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2372), "Description for Equipment 25", 7, "equipment25.jpg", false, "Equipment 25", 5, 50, 5, null, 24 },
                    { 26, 1, 0m, 5.89m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2380), "Description for Equipment 26", 1, "equipment26.jpg", false, "Equipment 26", 9, 50, 5, null, 14 },
                    { 27, 1, 0m, 2.09m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2389), "Description for Equipment 27", 4, "equipment27.jpg", false, "Equipment 27", 7, 50, 5, null, 34 },
                    { 28, 1, 0m, 8.27m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2398), "Description for Equipment 28", 2, "equipment28.jpg", false, "Equipment 28", 2, 50, 5, null, 24 },
                    { 29, 1, 0m, 7.72m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2407), "Description for Equipment 29", 7, "equipment29.jpg", false, "Equipment 29", 4, 50, 5, null, 21 },
                    { 30, 1, 0m, 6.44m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2416), "Description for Equipment 30", 3, "equipment30.jpg", false, "Equipment 30", 8, 50, 5, null, 44 },
                    { 31, 1, 0m, 7.33m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2444), "Description for Equipment 31", 8, "equipment31.jpg", false, "Equipment 31", 1, 50, 5, null, 17 },
                    { 32, 1, 0m, 3.22m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2453), "Description for Equipment 32", 8, "equipment32.jpg", false, "Equipment 32", 5, 50, 5, null, 44 },
                    { 33, 1, 0m, 4.34m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2462), "Description for Equipment 33", 6, "equipment33.jpg", false, "Equipment 33", 6, 50, 5, null, 16 },
                    { 34, 1, 0m, 8.09m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2472), "Description for Equipment 34", 7, "equipment34.jpg", false, "Equipment 34", 1, 50, 5, null, 32 },
                    { 35, 1, 0m, 6.52m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2481), "Description for Equipment 35", 6, "equipment35.jpg", false, "Equipment 35", 3, 50, 5, null, 35 },
                    { 36, 1, 0m, 5.81m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2490), "Description for Equipment 36", 7, "equipment36.jpg", false, "Equipment 36", 4, 50, 5, null, 42 },
                    { 37, 1, 0m, 7.58m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2500), "Description for Equipment 37", 9, "equipment37.jpg", false, "Equipment 37", 8, 50, 5, null, 26 },
                    { 38, 1, 0m, 5.47m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2508), "Description for Equipment 38", 5, "equipment38.jpg", false, "Equipment 38", 6, 50, 5, null, 35 },
                    { 39, 1, 0m, 1.45m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2517), "Description for Equipment 39", 7, "equipment39.jpg", false, "Equipment 39", 1, 50, 5, null, 49 },
                    { 40, 1, 0m, 1.22m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2526), "Description for Equipment 40", 2, "equipment40.jpg", false, "Equipment 40", 1, 50, 5, null, 32 },
                    { 41, 1, 0m, 7.37m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2534), "Description for Equipment 41", 5, "equipment41.jpg", false, "Equipment 41", 4, 50, 5, null, 24 },
                    { 42, 1, 0m, 7.22m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2562), "Description for Equipment 42", 4, "equipment42.jpg", false, "Equipment 42", 8, 50, 5, null, 48 },
                    { 43, 1, 0m, 4.01m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2571), "Description for Equipment 43", 4, "equipment43.jpg", false, "Equipment 43", 2, 50, 5, null, 25 },
                    { 44, 1, 0m, 4.79m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2580), "Description for Equipment 44", 4, "equipment44.jpg", false, "Equipment 44", 7, 50, 5, null, 37 },
                    { 45, 1, 0m, 0.65m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2589), "Description for Equipment 45", 2, "equipment45.jpg", false, "Equipment 45", 5, 50, 5, null, 15 },
                    { 46, 1, 0m, 6.39m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2598), "Description for Equipment 46", 6, "equipment46.jpg", false, "Equipment 46", 9, 50, 5, null, 45 },
                    { 47, 1, 0m, 5.87m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2607), "Description for Equipment 47", 1, "equipment47.jpg", false, "Equipment 47", 5, 50, 5, null, 37 },
                    { 48, 1, 0m, 6.03m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2615), "Description for Equipment 48", 9, "equipment48.jpg", false, "Equipment 48", 1, 50, 5, null, 12 },
                    { 49, 1, 0m, 2.23m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2624), "Description for Equipment 49", 4, "equipment49.jpg", false, "Equipment 49", 3, 50, 5, null, 33 },
                    { 50, 1, 0m, 2.83m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2633), "Description for Equipment 50", 2, "equipment50.jpg", false, "Equipment 50", 7, 50, 5, null, 35 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "DatePlaced", "IsActive", "Status", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 28, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2698), true, "returned", 59.94m, 3 },
                    { 2, new DateTime(2025, 1, 30, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2735), true, "paid", 89.85m, 4 },
                    { 3, new DateTime(2025, 2, 2, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2737), true, "rented", 29.97m, 4 },
                    { 4, new DateTime(2025, 1, 31, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2739), true, "rented", 19.98m, 5 },
                    { 5, new DateTime(2025, 2, 3, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2741), true, "returned", 99.90m, 5 },
                    { 6, new DateTime(2025, 2, 4, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2742), true, "rented", 49.95m, 6 },
                    { 7, new DateTime(2025, 2, 5, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2744), true, "returned", 69.93m, 7 },
                    { 8, new DateTime(2025, 2, 6, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2745), true, "paid", 39.96m, 2 },
                    { 9, new DateTime(2025, 2, 1, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2747), true, "rented", 149.85m, 2 },
                    { 10, new DateTime(2025, 1, 29, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2749), true, "returned", 29.97m, 2 }
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
                    { 1, 1, new DateTime(2025, 2, 2, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2954), 1, null, 2, new DateTime(2025, 2, 1, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2953) },
                    { 2, 1, new DateTime(2025, 2, 2, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2958), 2, null, 1, new DateTime(2025, 2, 1, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2957) },
                    { 3, 2, new DateTime(2025, 2, 3, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2961), 3, null, 1, new DateTime(2025, 2, 2, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2960) },
                    { 4, 3, new DateTime(2025, 2, 4, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2983), 1, null, 3, new DateTime(2025, 2, 3, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2981) },
                    { 5, 3, new DateTime(2025, 2, 4, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2986), 2, null, 2, new DateTime(2025, 2, 3, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2985) },
                    { 6, 4, new DateTime(2025, 2, 5, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2989), 2, null, 1, new DateTime(2025, 2, 4, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2988) },
                    { 7, 4, new DateTime(2025, 2, 5, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2991), 3, null, 1, new DateTime(2025, 2, 4, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2990) },
                    { 8, 5, new DateTime(2025, 2, 6, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2994), 1, null, 2, new DateTime(2025, 2, 5, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2993) },
                    { 9, 6, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2996), 3, null, 3, new DateTime(2025, 2, 6, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2995) },
                    { 10, 7, new DateTime(2025, 2, 8, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2999), 2, null, 1, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2998) }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "ID", "CostPerUse", "EndDate", "EquipmentID", "EquipmentID1", "IsReviewedByUser", "OrderID", "Price", "Quantity", "StartDate" },
                values: new object[,]
                {
                    { 1, 2.99m, new DateTime(2025, 1, 29, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2815), 1, null, false, 1, 5.98m, 2, new DateTime(2025, 1, 28, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2811) },
                    { 2, 4.99m, new DateTime(2025, 1, 30, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2820), 3, null, false, 1, 4.99m, 1, new DateTime(2025, 1, 28, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2819) },
                    { 3, 3.49m, new DateTime(2025, 1, 31, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2824), 2, null, false, 2, 10.47m, 3, new DateTime(2025, 1, 30, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2822) },
                    { 4, 2.99m, new DateTime(2025, 2, 1, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2828), 1, null, false, 2, 11.96m, 4, new DateTime(2025, 1, 30, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2827) },
                    { 5, 4.99m, new DateTime(2025, 2, 3, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2831), 3, null, false, 3, 9.98m, 2, new DateTime(2025, 2, 2, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2830) },
                    { 6, 2.99m, new DateTime(2025, 2, 1, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2835), 1, null, false, 4, 2.99m, 1, new DateTime(2025, 1, 31, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2833) },
                    { 7, 3.49m, new DateTime(2025, 2, 5, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2837), 2, null, false, 5, 17.45m, 5, new DateTime(2025, 2, 3, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2836) },
                    { 8, 4.99m, new DateTime(2025, 2, 6, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2840), 3, null, false, 6, 14.97m, 3, new DateTime(2025, 2, 4, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2839) },
                    { 9, 2.99m, new DateTime(2025, 2, 8, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2844), 1, null, false, 7, 5.98m, 2, new DateTime(2025, 2, 5, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2843) },
                    { 10, 3.49m, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2848), 2, null, false, 8, 10.47m, 3, new DateTime(2025, 2, 6, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2847) },
                    { 11, 4.99m, new DateTime(2025, 2, 3, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2851), 3, null, false, 9, 4.99m, 1, new DateTime(2025, 2, 1, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2850) },
                    { 12, 2.99m, new DateTime(2025, 2, 2, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2853), 1, null, false, 9, 14.95m, 5, new DateTime(2025, 2, 1, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2852) },
                    { 13, 3.49m, new DateTime(2025, 1, 30, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2857), 2, null, false, 10, 6.98m, 2, new DateTime(2025, 1, 29, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2856) },
                    { 14, 3.49m, new DateTime(2025, 1, 30, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2859), 4, null, true, 10, 6.98m, 2, new DateTime(2025, 1, 29, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2859) }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ID", "DateAdded", "Description", "IsDeleted", "NumberOfStars", "OrderItemID" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 29, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2887), "Great quality and very durable!", false, 4.5m, 1 },
                    { 2, new DateTime(2025, 1, 30, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2893), "Not as expected, could be better.", false, 2.0m, 2 },
                    { 3, new DateTime(2025, 1, 31, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2895), "Perfect for my needs, highly recommended!", false, 5.0m, 3 },
                    { 4, new DateTime(2025, 2, 1, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2896), "Good value for the price.", false, 4.0m, 4 },
                    { 5, new DateTime(2025, 2, 2, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2898), "Satisfactory but delivery was delayed.", false, 3.0m, 5 },
                    { 6, new DateTime(2025, 2, 3, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2900), "Excellent performance and quality.", false, 5.0m, 6 },
                    { 7, new DateTime(2025, 2, 4, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2903), "Decent product but could use some improvements.", false, 3.5m, 7 },
                    { 8, new DateTime(2025, 2, 5, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2904), "Very satisfied with the purchase.", false, 4.5m, 8 },
                    { 9, new DateTime(2025, 2, 6, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2906), "The item was okay, nothing special.", false, 3.0m, 9 },
                    { 10, new DateTime(2025, 2, 7, 22, 54, 15, 52, DateTimeKind.Local).AddTicks(2908), "Amazing product! Will buy again.", false, 5.0m, 14 }
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

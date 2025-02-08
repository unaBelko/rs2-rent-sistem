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
                    HasDamageReportedByUser = table.Column<bool>(type: "bit", nullable: false),
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
                    { 1, "una.belko+radnik@edu.fit.ba", "Una", true, "Radnik", "FMYt39xct6cZc9nKv9qrc+zO4wx/q2mvWVtJ32ekuZI=", "0038763222111", "y8PLIcF40l5TKX7zLboY0w==" },
                    { 2, "una.belko+shopping@edu.fit.ba", "Una", true, "Shopping", "FMYt39xct6cZc9nKv9qrc+zO4wx/q2mvWVtJ32ekuZI=", "0038763222111", "y8PLIcF40l5TKX7zLboY0w==" },
                    { 3, "michael.johnson+user@rental.com", "Michael", true, "Johnson", "FMYt39xct6cZc9nKv9qrc+zO4wx/q2mvWVtJ32ekuZI=", "555-8765", "y8PLIcF40l5TKX7zLboY0w==" },
                    { 4, "emily.davis+user@rental.com", "Emily", true, "Davis", "FMYt39xct6cZc9nKv9qrc+zO4wx/q2mvWVtJ32ekuZI=", "555-4321", "y8PLIcF40l5TKX7zLboY0w==" },
                    { 5, "william.brown+user@rental.com", "William", true, "Brown", "FMYt39xct6cZc9nKv9qrc+zO4wx/q2mvWVtJ32ekuZI=", "555-6789", "y8PLIcF40l5TKX7zLboY0w==" },
                    { 6, "ava.wilson+user@rental.com", "Ava", true, "Wilson", "FMYt39xct6cZc9nKv9qrc+zO4wx/q2mvWVtJ32ekuZI=", "555-2345", "y8PLIcF40l5TKX7zLboY0w==" },
                    { 7, "james.taylor+user@rental.com", "James", true, "Taylor", "FMYt39xct6cZc9nKv9qrc+zO4wx/q2mvWVtJ32ekuZI=", "555-7890", "y8PLIcF40l5TKX7zLboY0w==" },
                    { 8, "olivia.anderson+user@rental.com", "Olivia", true, "Anderson", "FMYt39xct6cZc9nKv9qrc+zO4wx/q2mvWVtJ32ekuZI=", "555-3456", "y8PLIcF40l5TKX7zLboY0w==" },
                    { 9, "benjamin.thomas+user@rental.com", "Benjamin", true, "Thomas", "FMYt39xct6cZc9nKv9qrc+zO4wx/q2mvWVtJ32ekuZI=", "555-9012", "y8PLIcF40l5TKX7zLboY0w==" },
                    { 10, "sophia.moore+user@rental.com", "Sophia", true, "Moore", "FMYt39xct6cZc9nKv9qrc+zO4wx/q2mvWVtJ32ekuZI=", "555-6543", "y8PLIcF40l5TKX7zLboY0w==" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "ID", "DateAdded", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5379), 45.75m, 2 },
                    { 2, new DateTime(2025, 2, 3, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5382), 120.00m, 3 },
                    { 3, new DateTime(2025, 2, 4, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5384), 65.30m, 4 },
                    { 4, new DateTime(2025, 2, 5, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5386), 78.40m, 5 },
                    { 5, new DateTime(2025, 2, 6, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5388), 52.10m, 6 },
                    { 6, new DateTime(2025, 2, 7, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5390), 98.25m, 7 },
                    { 7, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5391), 36.60m, 8 }
                });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "ID", "AddedByUserID", "AverageRating", "CostPerUse", "DateAdded", "Description", "EquipmentCategoryId", "ImageUrl", "IsDeleted", "ItemName", "ManufacturerID", "MaxQuantity", "MinQuantity", "Photo", "StockQuantity" },
                values: new object[,]
                {
                    { 1, 1, 0m, 2.99m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4371), "Official size and weight.", 1, "soccerball.jpg", false, "Soccer Ball", 1, 50, 5, null, 30 },
                    { 2, 1, 0m, 3.49m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4417), "High-quality leather basketball.", 2, "basketball.jpg", false, "Basketball", 2, 40, 5, null, 20 },
                    { 3, 1, 0m, 4.99m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4419), "Lightweight racket for professional use.", 3, "tennisracket.jpg", false, "Tennis Racket", 3, 25, 2, null, 15 },
                    { 4, 1, 0m, 7.56m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4532), "Description for Equipment 4", 2, "equipment4.jpg", false, "Equipment 4", 4, 50, 5, null, 11 },
                    { 5, 1, 0m, 6.67m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4562), "Description for Equipment 5", 9, "equipment5.jpg", false, "Equipment 5", 8, 50, 5, null, 34 },
                    { 6, 1, 0m, 1.40m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4572), "Description for Equipment 6", 2, "equipment6.jpg", false, "Equipment 6", 8, 50, 5, null, 45 },
                    { 7, 1, 0m, 1.88m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4581), "Description for Equipment 7", 5, "equipment7.jpg", false, "Equipment 7", 9, 50, 5, null, 16 },
                    { 8, 1, 0m, 1.74m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4589), "Description for Equipment 8", 8, "equipment8.jpg", false, "Equipment 8", 6, 50, 5, null, 47 },
                    { 9, 1, 0m, 1.29m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4597), "Description for Equipment 9", 2, "equipment9.jpg", false, "Equipment 9", 4, 50, 5, null, 37 },
                    { 10, 1, 0m, 9.49m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4607), "Description for Equipment 10", 6, "equipment10.jpg", false, "Equipment 10", 7, 50, 5, null, 11 },
                    { 11, 1, 0m, 6.88m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4615), "Description for Equipment 11", 3, "equipment11.jpg", false, "Equipment 11", 3, 50, 5, null, 40 },
                    { 12, 1, 0m, 1.51m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4623), "Description for Equipment 12", 6, "equipment12.jpg", false, "Equipment 12", 5, 50, 5, null, 23 },
                    { 13, 1, 0m, 1.09m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4632), "Description for Equipment 13", 3, "equipment13.jpg", false, "Equipment 13", 1, 50, 5, null, 10 },
                    { 14, 1, 0m, 5.68m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4640), "Description for Equipment 14", 9, "equipment14.jpg", false, "Equipment 14", 1, 50, 5, null, 38 },
                    { 15, 1, 0m, 6.81m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4674), "Description for Equipment 15", 4, "equipment15.jpg", false, "Equipment 15", 9, 50, 5, null, 19 },
                    { 16, 1, 0m, 4.66m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4682), "Description for Equipment 16", 6, "equipment16.jpg", false, "Equipment 16", 5, 50, 5, null, 47 },
                    { 17, 1, 0m, 2.57m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4690), "Description for Equipment 17", 5, "equipment17.jpg", false, "Equipment 17", 1, 50, 5, null, 29 },
                    { 18, 1, 0m, 9.82m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4699), "Description for Equipment 18", 5, "equipment18.jpg", false, "Equipment 18", 8, 50, 5, null, 24 },
                    { 19, 1, 0m, 0.26m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4707), "Description for Equipment 19", 9, "equipment19.jpg", false, "Equipment 19", 4, 50, 5, null, 28 },
                    { 20, 1, 0m, 6.99m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4715), "Description for Equipment 20", 3, "equipment20.jpg", false, "Equipment 20", 3, 50, 5, null, 10 },
                    { 21, 1, 0m, 0.59m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4723), "Description for Equipment 21", 9, "equipment21.jpg", false, "Equipment 21", 4, 50, 5, null, 35 },
                    { 22, 1, 0m, 3.13m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4732), "Description for Equipment 22", 4, "equipment22.jpg", false, "Equipment 22", 8, 50, 5, null, 15 },
                    { 23, 1, 0m, 6.21m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4739), "Description for Equipment 23", 6, "equipment23.jpg", false, "Equipment 23", 3, 50, 5, null, 21 },
                    { 24, 1, 0m, 9.55m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4748), "Description for Equipment 24", 8, "equipment24.jpg", false, "Equipment 24", 1, 50, 5, null, 46 },
                    { 25, 1, 0m, 3.57m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4756), "Description for Equipment 25", 7, "equipment25.jpg", false, "Equipment 25", 1, 50, 5, null, 10 },
                    { 26, 1, 0m, 8.48m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4790), "Description for Equipment 26", 7, "equipment26.jpg", false, "Equipment 26", 7, 50, 5, null, 46 },
                    { 27, 1, 0m, 7.69m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4799), "Description for Equipment 27", 5, "equipment27.jpg", false, "Equipment 27", 9, 50, 5, null, 40 },
                    { 28, 1, 0m, 2.04m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4806), "Description for Equipment 28", 8, "equipment28.jpg", false, "Equipment 28", 4, 50, 5, null, 13 },
                    { 29, 1, 0m, 0.98m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4815), "Description for Equipment 29", 1, "equipment29.jpg", false, "Equipment 29", 6, 50, 5, null, 25 },
                    { 30, 1, 0m, 6.12m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4823), "Description for Equipment 30", 3, "equipment30.jpg", false, "Equipment 30", 2, 50, 5, null, 24 },
                    { 31, 1, 0m, 2.11m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4830), "Description for Equipment 31", 4, "equipment31.jpg", false, "Equipment 31", 6, 50, 5, null, 11 },
                    { 32, 1, 0m, 1.52m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4838), "Description for Equipment 32", 5, "equipment32.jpg", false, "Equipment 32", 8, 50, 5, null, 36 },
                    { 33, 1, 0m, 2.01m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4846), "Description for Equipment 33", 6, "equipment33.jpg", false, "Equipment 33", 5, 50, 5, null, 26 },
                    { 34, 1, 0m, 2.64m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4855), "Description for Equipment 34", 4, "equipment34.jpg", false, "Equipment 34", 3, 50, 5, null, 43 },
                    { 35, 1, 0m, 9.31m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4863), "Description for Equipment 35", 7, "equipment35.jpg", false, "Equipment 35", 2, 50, 5, null, 23 },
                    { 36, 1, 0m, 1.37m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4896), "Description for Equipment 36", 8, "equipment36.jpg", false, "Equipment 36", 4, 50, 5, null, 11 },
                    { 37, 1, 0m, 6.98m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4904), "Description for Equipment 37", 9, "equipment37.jpg", false, "Equipment 37", 1, 50, 5, null, 38 },
                    { 38, 1, 0m, 3.98m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4912), "Description for Equipment 38", 7, "equipment38.jpg", false, "Equipment 38", 5, 50, 5, null, 27 },
                    { 39, 1, 0m, 0.41m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4920), "Description for Equipment 39", 5, "equipment39.jpg", false, "Equipment 39", 1, 50, 5, null, 31 },
                    { 40, 1, 0m, 10.00m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4928), "Description for Equipment 40", 9, "equipment40.jpg", false, "Equipment 40", 8, 50, 5, null, 31 },
                    { 41, 1, 0m, 2.43m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4936), "Description for Equipment 41", 6, "equipment41.jpg", false, "Equipment 41", 6, 50, 5, null, 18 },
                    { 42, 1, 0m, 7.29m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4945), "Description for Equipment 42", 2, "equipment42.jpg", false, "Equipment 42", 5, 50, 5, null, 16 },
                    { 43, 1, 0m, 9.50m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4953), "Description for Equipment 43", 2, "equipment43.jpg", false, "Equipment 43", 5, 50, 5, null, 49 },
                    { 44, 1, 0m, 9.90m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4961), "Description for Equipment 44", 8, "equipment44.jpg", false, "Equipment 44", 7, 50, 5, null, 38 },
                    { 45, 1, 0m, 4.34m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4969), "Description for Equipment 45", 5, "equipment45.jpg", false, "Equipment 45", 2, 50, 5, null, 18 },
                    { 46, 1, 0m, 3.60m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4977), "Description for Equipment 46", 4, "equipment46.jpg", false, "Equipment 46", 2, 50, 5, null, 34 },
                    { 47, 1, 0m, 9.05m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(4985), "Description for Equipment 47", 4, "equipment47.jpg", false, "Equipment 47", 2, 50, 5, null, 19 },
                    { 48, 1, 0m, 6.36m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5024), "Description for Equipment 48", 7, "equipment48.jpg", false, "Equipment 48", 5, 50, 5, null, 25 },
                    { 49, 1, 0m, 3.16m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5032), "Description for Equipment 49", 4, "equipment49.jpg", false, "Equipment 49", 7, 50, 5, null, 46 },
                    { 50, 1, 0m, 5.11m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5041), "Description for Equipment 50", 3, "equipment50.jpg", false, "Equipment 50", 9, 50, 5, null, 43 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "DatePlaced", "IsActive", "Status", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 29, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5105), true, "returned", 59.94m, 3 },
                    { 2, new DateTime(2025, 1, 31, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5109), true, "paid", 89.85m, 4 },
                    { 3, new DateTime(2025, 2, 3, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5111), true, "rented", 29.97m, 4 },
                    { 4, new DateTime(2025, 2, 1, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5113), true, "rented", 19.98m, 5 },
                    { 5, new DateTime(2025, 2, 4, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5114), true, "returned", 99.90m, 5 },
                    { 6, new DateTime(2025, 2, 5, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5116), true, "rented", 49.95m, 6 },
                    { 7, new DateTime(2025, 2, 6, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5185), true, "returned", 69.93m, 7 },
                    { 8, new DateTime(2025, 2, 7, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5187), true, "paid", 39.96m, 2 },
                    { 9, new DateTime(2025, 2, 2, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5189), true, "rented", 149.85m, 2 },
                    { 10, new DateTime(2025, 1, 30, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5191), true, "returned", 29.97m, 2 }
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
                    { 1, 1, new DateTime(2025, 2, 3, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5413), 1, null, 2, new DateTime(2025, 2, 2, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5411) },
                    { 2, 1, new DateTime(2025, 2, 3, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5418), 2, null, 1, new DateTime(2025, 2, 2, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5416) },
                    { 3, 2, new DateTime(2025, 2, 4, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5420), 3, null, 1, new DateTime(2025, 2, 3, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5419) },
                    { 4, 3, new DateTime(2025, 2, 5, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5423), 1, null, 3, new DateTime(2025, 2, 4, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5422) },
                    { 5, 3, new DateTime(2025, 2, 5, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5425), 2, null, 2, new DateTime(2025, 2, 4, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5424) },
                    { 6, 4, new DateTime(2025, 2, 6, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5428), 2, null, 1, new DateTime(2025, 2, 5, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5427) },
                    { 7, 4, new DateTime(2025, 2, 6, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5431), 3, null, 1, new DateTime(2025, 2, 5, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5430) },
                    { 8, 5, new DateTime(2025, 2, 7, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5433), 1, null, 2, new DateTime(2025, 2, 6, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5432) },
                    { 9, 6, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5436), 3, null, 3, new DateTime(2025, 2, 7, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5435) },
                    { 10, 7, new DateTime(2025, 2, 9, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5438), 2, null, 1, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5438) }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "ID", "CostPerUse", "EndDate", "EquipmentID", "EquipmentID1", "HasDamageReportedByUser", "IsReviewedByUser", "OrderID", "Price", "Quantity", "StartDate" },
                values: new object[,]
                {
                    { 1, 2.99m, new DateTime(2025, 1, 30, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5235), 1, null, false, false, 1, 5.98m, 2, new DateTime(2025, 1, 29, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5232) },
                    { 2, 4.99m, new DateTime(2025, 1, 31, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5241), 3, null, false, false, 1, 4.99m, 1, new DateTime(2025, 1, 29, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5240) },
                    { 3, 3.49m, new DateTime(2025, 2, 1, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5248), 2, null, false, false, 2, 10.47m, 3, new DateTime(2025, 1, 31, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5247) },
                    { 4, 2.99m, new DateTime(2025, 2, 2, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5251), 1, null, false, false, 2, 11.96m, 4, new DateTime(2025, 1, 31, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5250) },
                    { 5, 4.99m, new DateTime(2025, 2, 4, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5254), 3, null, false, false, 3, 9.98m, 2, new DateTime(2025, 2, 3, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5253) },
                    { 6, 2.99m, new DateTime(2025, 2, 2, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5258), 1, null, false, false, 4, 2.99m, 1, new DateTime(2025, 2, 1, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5257) },
                    { 7, 3.49m, new DateTime(2025, 2, 6, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5262), 2, null, false, false, 5, 17.45m, 5, new DateTime(2025, 2, 4, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5261) },
                    { 8, 4.99m, new DateTime(2025, 2, 7, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5264), 3, null, false, false, 6, 14.97m, 3, new DateTime(2025, 2, 5, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5263) },
                    { 9, 2.99m, new DateTime(2025, 2, 9, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5267), 1, null, false, false, 7, 5.98m, 2, new DateTime(2025, 2, 6, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5266) },
                    { 10, 3.49m, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5271), 2, null, false, false, 8, 10.47m, 3, new DateTime(2025, 2, 7, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5270) },
                    { 11, 4.99m, new DateTime(2025, 2, 4, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5274), 3, null, false, false, 9, 4.99m, 1, new DateTime(2025, 2, 2, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5273) },
                    { 12, 2.99m, new DateTime(2025, 2, 3, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5276), 1, null, false, false, 9, 14.95m, 5, new DateTime(2025, 2, 2, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5275) },
                    { 13, 3.49m, new DateTime(2025, 1, 31, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5279), 2, null, false, false, 10, 6.98m, 2, new DateTime(2025, 1, 30, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5278) },
                    { 14, 3.49m, new DateTime(2025, 1, 31, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5282), 4, null, true, true, 10, 6.98m, 2, new DateTime(2025, 1, 30, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5281) }
                });

            migrationBuilder.InsertData(
                table: "Damages",
                columns: new[] { "ID", "Comment", "DateAdded", "OrderItemID" },
                values: new object[] { 1, "This got some scratches while we were using it.", new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5455), 14 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ID", "DateAdded", "Description", "IsDeleted", "NumberOfStars", "OrderItemID" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 30, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5338), "Great quality and very durable!", false, 4.5m, 1 },
                    { 2, new DateTime(2025, 1, 31, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5345), "Not as expected, could be better.", false, 2.0m, 2 },
                    { 3, new DateTime(2025, 2, 1, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5347), "Perfect for my needs, highly recommended!", false, 5.0m, 3 },
                    { 4, new DateTime(2025, 2, 2, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5349), "Good value for the price.", false, 4.0m, 4 },
                    { 5, new DateTime(2025, 2, 3, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5350), "Satisfactory but delivery was delayed.", false, 3.0m, 5 },
                    { 6, new DateTime(2025, 2, 4, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5353), "Excellent performance and quality.", false, 5.0m, 6 },
                    { 7, new DateTime(2025, 2, 5, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5354), "Decent product but could use some improvements.", false, 3.5m, 7 },
                    { 8, new DateTime(2025, 2, 6, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5356), "Very satisfied with the purchase.", false, 4.5m, 8 },
                    { 9, new DateTime(2025, 2, 7, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5358), "The item was okay, nothing special.", false, 3.0m, 9 },
                    { 10, new DateTime(2025, 2, 8, 12, 46, 36, 879, DateTimeKind.Local).AddTicks(5360), "Amazing product! Will buy again.", false, 5.0m, 14 }
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
                column: "OrderItemID",
                unique: true);

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

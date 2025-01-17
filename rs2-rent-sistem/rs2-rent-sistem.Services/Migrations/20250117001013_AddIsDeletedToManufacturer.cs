using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rs2_rent_sistem.Services.Migrations
{
    /// <inheritdoc />
    public partial class AddIsDeletedToManufacturer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Manufacturer",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2025, 1, 11, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2025, 1, 12, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2025, 1, 13, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2025, 1, 14, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2025, 1, 15, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "ID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2025, 1, 16, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "ID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 12, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4556), new DateTime(2025, 1, 11, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4553) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 12, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4561), new DateTime(2025, 1, 11, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 13, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4565), new DateTime(2025, 1, 12, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 14, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4568), new DateTime(2025, 1, 13, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 14, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4571), new DateTime(2025, 1, 13, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 15, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4575), new DateTime(2025, 1, 14, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 15, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4578), new DateTime(2025, 1, 14, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 16, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4581), new DateTime(2025, 1, 15, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4585), new DateTime(2025, 1, 16, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 18, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4588), new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4587) });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CostPerUse", "DateAdded", "StockQuantity" },
                values: new object[] { 8.19m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3720), 37 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 1.99m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3732), 2, 5, 32 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 3.86m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3742), 2, 2, 33 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 1.96m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3751), 1, 19 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "StockQuantity" },
                values: new object[] { 5.58m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3760), 8, 36 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 6.84m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3769), 3, 8, 45 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 1.19m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3778), 5, 16 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 1.15m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3787), 9, 2, 20 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 7.77m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3795), 4, 1, 39 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "StockQuantity" },
                values: new object[] { 5.92m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3860), 7, 40 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID" },
                values: new object[] { 8.13m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3869), 8, 3 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 4.32m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3878), 8, 1, 38 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 4.04m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3886), 6, 7, 32 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 9.29m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3895), 5, 9, 12 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 2.42m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3904), 7, 4, 34 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 1.24m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3913), 1, 5, 10 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 4.30m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3921), 4, 1, 13 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 4.18m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3929), 8, 2, 33 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 4.37m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3937), 7, 3, 37 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 8.63m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3945), 8, 8, 30 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 3.62m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3981), 5, 6, 20 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 7.67m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3990), 1, 2, 49 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 6.30m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3999), 7, 8, 27 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 3.13m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4008), 6, 2, 48 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 5.44m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4016), 9, 3, 44 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 7.09m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4025), 7, 8, 43 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 5.54m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4033), 3, 8, 34 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID" },
                values: new object[] { 8.04m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4042), 5, 3 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 1.88m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4050), 3, 2, 47 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 5.97m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4059), 4, 4, 19 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 8.36m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4068), 1, 24 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 0.66m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4104), 5, 5, 29 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 2.67m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4113), 7, 4, 32 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 0.21m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4121), 3, 9, 47 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 8.80m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4130), 1, 20 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 2.83m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4138), 4, 2, 37 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 6.46m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4147), 3, 9, 27 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 2.74m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4155), 4, 3, 44 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 1.42m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4163), 4, 3, 34 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "StockQuantity" },
                values: new object[] { 8.13m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4173), 4, 40 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 6.86m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4181), 4, 6, 20 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 6.22m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4190), 9, 1, 36 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 9.61m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4225), 5, 44 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 9.96m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4233), 2, 1, 30 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 8.31m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4241), 2, 7, 22 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID" },
                values: new object[] { 6.28m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4250), 6, 6 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId" },
                values: new object[] { 0.82m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4258), 8 });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "ID",
                keyValue: 1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "ID",
                keyValue: 2,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "ID",
                keyValue: 3,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "ID",
                keyValue: 4,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "ID",
                keyValue: 5,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "ID",
                keyValue: 6,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "ID",
                keyValue: 7,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "ID",
                keyValue: 8,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "ID",
                keyValue: 9,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "ID",
                keyValue: 10,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatePlaced",
                value: new DateTime(2025, 1, 7, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 2,
                column: "DatePlaced",
                value: new DateTime(2025, 1, 9, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 3,
                column: "DatePlaced",
                value: new DateTime(2025, 1, 12, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 4,
                column: "DatePlaced",
                value: new DateTime(2025, 1, 10, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 5,
                column: "DatePlaced",
                value: new DateTime(2025, 1, 13, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 6,
                column: "DatePlaced",
                value: new DateTime(2025, 1, 14, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 7,
                column: "DatePlaced",
                value: new DateTime(2025, 1, 15, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 8,
                column: "DatePlaced",
                value: new DateTime(2025, 1, 16, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 9,
                column: "DatePlaced",
                value: new DateTime(2025, 1, 11, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 10,
                column: "DatePlaced",
                value: new DateTime(2025, 1, 8, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 8, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4409), new DateTime(2025, 1, 7, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 9, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4416), new DateTime(2025, 1, 7, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 10, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4420), new DateTime(2025, 1, 9, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4419) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 11, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4425), new DateTime(2025, 1, 9, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4423) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 13, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4428), new DateTime(2025, 1, 12, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 11, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4434), new DateTime(2025, 1, 10, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4433) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 15, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4465), new DateTime(2025, 1, 13, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 16, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4469), new DateTime(2025, 1, 14, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 18, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4475), new DateTime(2025, 1, 15, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4480), new DateTime(2025, 1, 16, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 13, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4484), new DateTime(2025, 1, 11, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 12, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4488), new DateTime(2025, 1, 11, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 9, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4492), new DateTime(2025, 1, 8, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "Xy15y1hYepVg+ZP/YwZos14rgc/ph1Yde9BX6ExAVHk=", "2N07XEIzN4iKL7TpSz54QQ==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "Xy15y1hYepVg+ZP/YwZos14rgc/ph1Yde9BX6ExAVHk=", "2N07XEIzN4iKL7TpSz54QQ==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "Xy15y1hYepVg+ZP/YwZos14rgc/ph1Yde9BX6ExAVHk=", "2N07XEIzN4iKL7TpSz54QQ==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "Xy15y1hYepVg+ZP/YwZos14rgc/ph1Yde9BX6ExAVHk=", "2N07XEIzN4iKL7TpSz54QQ==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "Xy15y1hYepVg+ZP/YwZos14rgc/ph1Yde9BX6ExAVHk=", "2N07XEIzN4iKL7TpSz54QQ==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "Xy15y1hYepVg+ZP/YwZos14rgc/ph1Yde9BX6ExAVHk=", "2N07XEIzN4iKL7TpSz54QQ==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "Xy15y1hYepVg+ZP/YwZos14rgc/ph1Yde9BX6ExAVHk=", "2N07XEIzN4iKL7TpSz54QQ==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "Xy15y1hYepVg+ZP/YwZos14rgc/ph1Yde9BX6ExAVHk=", "2N07XEIzN4iKL7TpSz54QQ==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "Xy15y1hYepVg+ZP/YwZos14rgc/ph1Yde9BX6ExAVHk=", "2N07XEIzN4iKL7TpSz54QQ==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "Xy15y1hYepVg+ZP/YwZos14rgc/ph1Yde9BX6ExAVHk=", "2N07XEIzN4iKL7TpSz54QQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Manufacturer");

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 9, 1, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 9, 2, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 9, 3, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 9, 4, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 9, 5, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "ID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 9, 6, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "ID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(590), new DateTime(2024, 9, 1, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(595), new DateTime(2024, 9, 1, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(598), new DateTime(2024, 9, 2, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 4, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(602), new DateTime(2024, 9, 3, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 4, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(605), new DateTime(2024, 9, 3, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 5, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(609), new DateTime(2024, 9, 4, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 5, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 9, 4, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 6, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(615), new DateTime(2024, 9, 5, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(619), new DateTime(2024, 9, 6, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 8, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(622), new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CostPerUse", "DateAdded", "StockQuantity" },
                values: new object[] { 3.28m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9746), 28 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 7.91m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9758), 6, 8, 12 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 7.52m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9768), 7, 5, 42 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 7.59m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9804), 5, 45 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "StockQuantity" },
                values: new object[] { 5.91m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9813), 4, 16 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 8.77m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9822), 1, 6, 48 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 4.54m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9832), 1, 12 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 2.68m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9841), 7, 7, 39 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 0.45m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9849), 2, 7, 38 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "StockQuantity" },
                values: new object[] { 5.30m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9858), 1, 38 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID" },
                values: new object[] { 8.09m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9866), 2, 9 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 4.45m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9875), 4, 3, 34 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 9.67m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9883), 8, 9, 33 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 3.07m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9892), 9, 7, 31 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 2.55m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9927), 9, 3, 41 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 7.58m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9936), 3, 6, 31 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 2.47m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9945), 9, 6, 18 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 6.32m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9953), 4, 9, 41 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 7.42m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9961), 8, 7, 44 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 5.45m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9969), 7, 7, 47 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 7.17m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9978), 1, 7, 42 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 6.19m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9986), 9, 1, 41 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 4.51m, new DateTime(2024, 9, 7, 17, 43, 59, 963, DateTimeKind.Local).AddTicks(9995), 9, 3, 17 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 3.77m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(3), 2, 6, 34 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 1.68m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(11), 6, 7, 25 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 2.79m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(47), 9, 3, 48 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 7.72m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(55), 8, 3, 46 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID" },
                values: new object[] { 4.10m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(63), 4, 7 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 3.20m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(71), 7, 4, 28 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 0.74m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(79), 5, 2, 15 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 3.23m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(89), 2, 39 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 4.12m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(97), 9, 9, 43 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 4.93m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(106), 3, 9, 37 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 5.76m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(114), 6, 5, 18 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 5.50m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(122), 7, 36 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 6.72m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(177), 7, 9, 36 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 1.98m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(187), 9, 5, 15 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 4.50m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(195), 3, 2, 17 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 7.34m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(204), 6, 8, 13 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "StockQuantity" },
                values: new object[] { 3.96m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(212), 2, 38 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 3.42m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(220), 2, 9, 35 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 9.84m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(228), 4, 7, 11 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 0.30m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(236), 2, 17 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 6.83m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(244), 8, 5, 26 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 4.17m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(252), 6, 6, 19 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID" },
                values: new object[] { 2.19m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(261), 5, 5 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId" },
                values: new object[] { 3.60m, new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(301), 1 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatePlaced",
                value: new DateTime(2024, 8, 28, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 2,
                column: "DatePlaced",
                value: new DateTime(2024, 8, 30, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 3,
                column: "DatePlaced",
                value: new DateTime(2024, 9, 2, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 4,
                column: "DatePlaced",
                value: new DateTime(2024, 8, 31, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 5,
                column: "DatePlaced",
                value: new DateTime(2024, 9, 3, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 6,
                column: "DatePlaced",
                value: new DateTime(2024, 9, 4, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 7,
                column: "DatePlaced",
                value: new DateTime(2024, 9, 5, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 8,
                column: "DatePlaced",
                value: new DateTime(2024, 9, 6, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 9,
                column: "DatePlaced",
                value: new DateTime(2024, 9, 1, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 10,
                column: "DatePlaced",
                value: new DateTime(2024, 8, 29, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 29, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(446), new DateTime(2024, 8, 28, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 30, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(452), new DateTime(2024, 8, 28, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 31, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(456), new DateTime(2024, 8, 30, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 1, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(461), new DateTime(2024, 8, 30, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(459) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(465), new DateTime(2024, 9, 2, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 1, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(469), new DateTime(2024, 8, 31, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 5, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(474), new DateTime(2024, 9, 3, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 6, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(478), new DateTime(2024, 9, 4, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 8, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(482), new DateTime(2024, 9, 5, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 7, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(487), new DateTime(2024, 9, 6, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(491), new DateTime(2024, 9, 1, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(496), new DateTime(2024, 9, 1, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 30, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(500), new DateTime(2024, 8, 29, 17, 43, 59, 964, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "sRTsGRjffsRw2K0G/9ZFN+EvoE2SEdabhHq55jmBq/k=", "ktn9I29B0imKx0RhFtkt+A==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "sRTsGRjffsRw2K0G/9ZFN+EvoE2SEdabhHq55jmBq/k=", "ktn9I29B0imKx0RhFtkt+A==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "sRTsGRjffsRw2K0G/9ZFN+EvoE2SEdabhHq55jmBq/k=", "ktn9I29B0imKx0RhFtkt+A==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "sRTsGRjffsRw2K0G/9ZFN+EvoE2SEdabhHq55jmBq/k=", "ktn9I29B0imKx0RhFtkt+A==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "sRTsGRjffsRw2K0G/9ZFN+EvoE2SEdabhHq55jmBq/k=", "ktn9I29B0imKx0RhFtkt+A==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "sRTsGRjffsRw2K0G/9ZFN+EvoE2SEdabhHq55jmBq/k=", "ktn9I29B0imKx0RhFtkt+A==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "sRTsGRjffsRw2K0G/9ZFN+EvoE2SEdabhHq55jmBq/k=", "ktn9I29B0imKx0RhFtkt+A==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "sRTsGRjffsRw2K0G/9ZFN+EvoE2SEdabhHq55jmBq/k=", "ktn9I29B0imKx0RhFtkt+A==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "sRTsGRjffsRw2K0G/9ZFN+EvoE2SEdabhHq55jmBq/k=", "ktn9I29B0imKx0RhFtkt+A==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "sRTsGRjffsRw2K0G/9ZFN+EvoE2SEdabhHq55jmBq/k=", "ktn9I29B0imKx0RhFtkt+A==" });
        }
    }
}

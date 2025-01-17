using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rs2_rent_sistem.Services.Migrations
{
    /// <inheritdoc />
    public partial class AddIsDeletedToEquipmentCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "EquipmentCategory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2025, 1, 11, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2025, 1, 12, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2025, 1, 13, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2025, 1, 14, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2025, 1, 15, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "ID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2025, 1, 16, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "ID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 12, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4656), new DateTime(2025, 1, 11, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 12, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4661), new DateTime(2025, 1, 11, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 13, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4665), new DateTime(2025, 1, 12, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 14, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4668), new DateTime(2025, 1, 13, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 14, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4671), new DateTime(2025, 1, 13, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 15, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4700), new DateTime(2025, 1, 14, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 15, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4703), new DateTime(2025, 1, 14, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 16, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4706), new DateTime(2025, 1, 15, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4710), new DateTime(2025, 1, 16, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "CartItem",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 18, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4714), new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4713) });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CostPerUse", "DateAdded", "StockQuantity" },
                values: new object[] { 4.13m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(3864), 40 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 7.84m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(3883), 8, 21 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 3.27m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(3894), 6, 1, 35 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 9.35m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(3930), 5, 8, 23 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 2.53m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(3939), 4, 4, 25 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 2.86m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(3947), 2, 5, 12 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 1.63m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(3957), 3, 46 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 2.86m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(3965), 7, 9, 12 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 2.28m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(3973), 8, 9, 32 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 0.56m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(3982), 3, 2, 41 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 4.06m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(3990), 5, 6, 13 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 7.02m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(3998), 6, 6, 17 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 9.54m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4006), 3, 9, 34 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 9.32m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4014), 2, 4, 47 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 9.48m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4063), 9, 28 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 9.25m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4072), 2, 8, 21 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 9.41m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4079), 6, 11 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 8.39m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4088), 2, 5, 42 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 9.54m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4096), 3, 5, 43 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 9.64m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4104), 6, 7, 36 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 5.70m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4111), 2, 5, 18 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 2.34m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4120), 3, 4, 46 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 8.79m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4128), 2, 5, 32 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 8.69m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4136), 7, 4, 20 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 2.73m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4144), 5, 9, 28 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 7.40m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4176), 9, 6, 30 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 2.79m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4184), 9, 4, 47 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 6.09m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4192), 4, 7, 38 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 8.36m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4200), 3, 24 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 4.51m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4209), 7, 34 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 2.47m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4217), 6, 8, 12 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 3.10m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4225), 3, 4, 13 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 4.60m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4233), 9, 9, 36 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 3.32m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4241), 1, 34 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "StockQuantity" },
                values: new object[] { 6.57m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4248), 1, 44 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 5.79m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4256), 7, 8, 12 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 1.00m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4289), 4, 7, 40 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 8.45m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4298), 6, 8, 29 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 7.91m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4306), 4, 37 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 8.90m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4314), 9, 1, 28 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "StockQuantity" },
                values: new object[] { 5.50m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4322), 1, 42 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 3.82m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4330), 4, 7, 26 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 7.62m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4338), 3, 1, 25 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 9.76m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4346), 3, 7, 38 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 8.55m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4354), 3, 1, 32 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 1.02m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4362), 4, 9, 42 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 4.45m, new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4370), 6, 9, 47 });

            migrationBuilder.UpdateData(
                table: "EquipmentCategory",
                keyColumn: "ID",
                keyValue: 1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "EquipmentCategory",
                keyColumn: "ID",
                keyValue: 2,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "EquipmentCategory",
                keyColumn: "ID",
                keyValue: 3,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "EquipmentCategory",
                keyColumn: "ID",
                keyValue: 4,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "EquipmentCategory",
                keyColumn: "ID",
                keyValue: 5,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "EquipmentCategory",
                keyColumn: "ID",
                keyValue: 6,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "EquipmentCategory",
                keyColumn: "ID",
                keyValue: 7,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "EquipmentCategory",
                keyColumn: "ID",
                keyValue: 8,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "EquipmentCategory",
                keyColumn: "ID",
                keyValue: 9,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "EquipmentCategory",
                keyColumn: "ID",
                keyValue: 10,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatePlaced",
                value: new DateTime(2025, 1, 7, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 2,
                column: "DatePlaced",
                value: new DateTime(2025, 1, 9, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 3,
                column: "DatePlaced",
                value: new DateTime(2025, 1, 12, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 4,
                column: "DatePlaced",
                value: new DateTime(2025, 1, 10, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 5,
                column: "DatePlaced",
                value: new DateTime(2025, 1, 13, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 6,
                column: "DatePlaced",
                value: new DateTime(2025, 1, 14, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 7,
                column: "DatePlaced",
                value: new DateTime(2025, 1, 15, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 8,
                column: "DatePlaced",
                value: new DateTime(2025, 1, 16, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 9,
                column: "DatePlaced",
                value: new DateTime(2025, 1, 11, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "ID",
                keyValue: 10,
                column: "DatePlaced",
                value: new DateTime(2025, 1, 8, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 8, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4543), new DateTime(2025, 1, 7, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 9, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4551), new DateTime(2025, 1, 7, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 10, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4555), new DateTime(2025, 1, 9, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4553) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 11, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4560), new DateTime(2025, 1, 9, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 13, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4564), new DateTime(2025, 1, 12, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 11, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4569), new DateTime(2025, 1, 10, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 15, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4573), new DateTime(2025, 1, 13, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 16, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4577), new DateTime(2025, 1, 14, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 18, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4582), new DateTime(2025, 1, 15, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 17, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4587), new DateTime(2025, 1, 16, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 13, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4591), new DateTime(2025, 1, 11, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 12, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4595), new DateTime(2025, 1, 11, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 9, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4599), new DateTime(2025, 1, 8, 1, 12, 11, 326, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "Loz+8NcUuoihBW1RDXRD1XLJ5Ph3bmAIcsoNvS6x2t8=", "zJ+7itttKsBRJ1vYQQF6gw==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "Loz+8NcUuoihBW1RDXRD1XLJ5Ph3bmAIcsoNvS6x2t8=", "zJ+7itttKsBRJ1vYQQF6gw==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "Loz+8NcUuoihBW1RDXRD1XLJ5Ph3bmAIcsoNvS6x2t8=", "zJ+7itttKsBRJ1vYQQF6gw==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "Loz+8NcUuoihBW1RDXRD1XLJ5Ph3bmAIcsoNvS6x2t8=", "zJ+7itttKsBRJ1vYQQF6gw==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "Loz+8NcUuoihBW1RDXRD1XLJ5Ph3bmAIcsoNvS6x2t8=", "zJ+7itttKsBRJ1vYQQF6gw==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "Loz+8NcUuoihBW1RDXRD1XLJ5Ph3bmAIcsoNvS6x2t8=", "zJ+7itttKsBRJ1vYQQF6gw==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "Loz+8NcUuoihBW1RDXRD1XLJ5Ph3bmAIcsoNvS6x2t8=", "zJ+7itttKsBRJ1vYQQF6gw==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "Loz+8NcUuoihBW1RDXRD1XLJ5Ph3bmAIcsoNvS6x2t8=", "zJ+7itttKsBRJ1vYQQF6gw==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "Loz+8NcUuoihBW1RDXRD1XLJ5Ph3bmAIcsoNvS6x2t8=", "zJ+7itttKsBRJ1vYQQF6gw==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { "Loz+8NcUuoihBW1RDXRD1XLJ5Ph3bmAIcsoNvS6x2t8=", "zJ+7itttKsBRJ1vYQQF6gw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "EquipmentCategory");

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
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 1.99m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3732), 5, 32 });

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
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 1.96m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3751), 7, 1, 19 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 5.58m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3760), 8, 2, 36 });

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
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 5.92m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3860), 7, 3, 40 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 8.13m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3869), 8, 3, 39 });

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
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 2.42m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3904), 4, 34 });

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
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 4.30m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(3921), 1, 13 });

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
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 8.04m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4042), 5, 3, 45 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 1.88m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4050), 2, 47 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 5.97m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4059), 4, 19 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 8.36m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4068), 4, 1, 24 });

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
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 0.21m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4121), 9, 47 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "StockQuantity" },
                values: new object[] { 8.80m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4130), 4, 20 });

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
                columns: new[] { "CostPerUse", "DateAdded", "ManufacturerID", "StockQuantity" },
                values: new object[] { 1.42m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4163), 3, 34 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 8.13m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4173), 4, 7, 40 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "StockQuantity" },
                values: new object[] { 6.86m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4181), 4, 20 });

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
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 9.61m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4225), 1, 5, 44 });

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
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 6.28m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4250), 6, 6, 38 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "CostPerUse", "DateAdded", "EquipmentCategoryId", "ManufacturerID", "StockQuantity" },
                values: new object[] { 0.82m, new DateTime(2025, 1, 17, 1, 10, 13, 367, DateTimeKind.Local).AddTicks(4258), 8, 6, 23 });

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
    }
}

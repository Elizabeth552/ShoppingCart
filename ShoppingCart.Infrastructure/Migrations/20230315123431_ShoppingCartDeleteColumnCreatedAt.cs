using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCart.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ShoppingCartDeleteColumnCreatedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShoppingCartCreatedAt",
                table: "UserEntity");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedAt",
                table: "UserEntity",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "ProductEntity",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 15, 14, 34, 31, 642, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "ProductEntity",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 15, 14, 34, 31, 642, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "11.12.2022");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserEntity",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "ShoppingCartCreatedAt",
                table: "UserEntity",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ProductEntity",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 14, 10, 36, 33, 362, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "ProductEntity",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 14, 10, 36, 33, 362, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ShoppingCartCreatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 36, 33, 365, DateTimeKind.Local).AddTicks(242), new DateTime(2023, 3, 14, 10, 36, 33, 364, DateTimeKind.Local).AddTicks(9400) });
        }
    }
}

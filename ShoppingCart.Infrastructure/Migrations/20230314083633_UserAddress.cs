using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCart.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "EmailIndex",
                table: "UserEntity");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "UserEntity");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "UserEntity");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "UserEntity");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "UserEntity");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "UserEntity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HouseNumber",
                table: "UserEntity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "UserEntity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "ShoppingCartCreatedAt", "City", "CreatedAt", "HouseNumber", "Street" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 36, 33, 364, DateTimeKind.Local).AddTicks(9400), "burgas", new DateTime(2023, 3, 14, 10, 36, 33, 365, DateTimeKind.Local).AddTicks(242), "23M", "Ivan" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "UserEntity");

            migrationBuilder.DropColumn(
                name: "HouseNumber",
                table: "UserEntity");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "UserEntity");

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "UserEntity",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "UserEntity",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "UserEntity",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ProductEntity",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 9, 10, 48, 38, 575, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "ProductEntity",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 9, 10, 48, 38, 575, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "NormalizedEmail", "NormalizedUserName", "UserName", "ShoppingCartCreatedAt" },
                values: new object[] { new DateTime(2023, 3, 9, 10, 48, 38, 577, DateTimeKind.Local).AddTicks(8837), null, null, "pesho_boga", new DateTime(2023, 3, 9, 10, 48, 38, 577, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "UserEntity",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "UserEntity",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }
    }
}

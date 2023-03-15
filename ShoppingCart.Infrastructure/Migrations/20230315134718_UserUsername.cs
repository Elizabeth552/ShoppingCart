using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCart.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserUsername : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "UserEntity",
                type: "bit",
                nullable: true);

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
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ProductEntity",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 15, 15, 47, 17, 975, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "ProductEntity",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 15, 15, 47, 17, 975, DateTimeKind.Local).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsEnabled", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { null, null, null, null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "EmailIndex",
                table: "UserEntity");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "UserEntity");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
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
        }
    }
}

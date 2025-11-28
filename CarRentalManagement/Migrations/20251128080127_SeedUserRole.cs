using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "664ad599-d589-4fd8-94cb-7eeee45095f7", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEC1hLANhYFY6U+a8D7QC05mAsRy2ZZRc8nEWMAEyBRpNBvB/fAZxvPbeQhBVZVqDzg==", null, false, "a3075018-5fcf-4eca-aad1-4f21457c1b92", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 1, 26, 493, DateTimeKind.Local).AddTicks(5973), new DateTime(2025, 11, 28, 16, 1, 26, 493, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 1, 26, 493, DateTimeKind.Local).AddTicks(5975), new DateTime(2025, 11, 28, 16, 1, 26, 493, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 1, 26, 493, DateTimeKind.Local).AddTicks(5604), new DateTime(2025, 11, 28, 16, 1, 26, 493, DateTimeKind.Local).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 1, 26, 493, DateTimeKind.Local).AddTicks(5618), new DateTime(2025, 11, 28, 16, 1, 26, 493, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 1, 26, 493, DateTimeKind.Local).AddTicks(5878), new DateTime(2025, 11, 28, 16, 1, 26, 493, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 1, 26, 493, DateTimeKind.Local).AddTicks(5881), new DateTime(2025, 11, 28, 16, 1, 26, 493, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 1, 26, 493, DateTimeKind.Local).AddTicks(5883), new DateTime(2025, 11, 28, 16, 1, 26, 493, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 1, 26, 493, DateTimeKind.Local).AddTicks(5885), new DateTime(2025, 11, 28, 16, 1, 26, 493, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 32, 57, 434, DateTimeKind.Local).AddTicks(2460), new DateTime(2025, 11, 28, 15, 32, 57, 434, DateTimeKind.Local).AddTicks(2461) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 32, 57, 434, DateTimeKind.Local).AddTicks(2463), new DateTime(2025, 11, 28, 15, 32, 57, 434, DateTimeKind.Local).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 32, 57, 434, DateTimeKind.Local).AddTicks(1959), new DateTime(2025, 11, 28, 15, 32, 57, 434, DateTimeKind.Local).AddTicks(1971) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 32, 57, 434, DateTimeKind.Local).AddTicks(1975), new DateTime(2025, 11, 28, 15, 32, 57, 434, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 32, 57, 434, DateTimeKind.Local).AddTicks(2360), new DateTime(2025, 11, 28, 15, 32, 57, 434, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 32, 57, 434, DateTimeKind.Local).AddTicks(2363), new DateTime(2025, 11, 28, 15, 32, 57, 434, DateTimeKind.Local).AddTicks(2363) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 32, 57, 434, DateTimeKind.Local).AddTicks(2365), new DateTime(2025, 11, 28, 15, 32, 57, 434, DateTimeKind.Local).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 32, 57, 434, DateTimeKind.Local).AddTicks(2367), new DateTime(2025, 11, 28, 15, 32, 57, 434, DateTimeKind.Local).AddTicks(2367) });
        }
    }
}

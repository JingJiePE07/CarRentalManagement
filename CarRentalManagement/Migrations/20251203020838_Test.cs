using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a68a8f1-8c86-49e2-b894-932a13f97c52", "AQAAAAIAAYagAAAAEK7QruPVpSndRggakJMUsDVm5McYvfXQAIr9epEwk91o5pICwSexwyxOb242F181nQ==", "ea42f84c-d379-4c71-bb3a-c632aecba397" });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 10, 8, 38, 106, DateTimeKind.Local).AddTicks(807), new DateTime(2025, 12, 3, 10, 8, 38, 106, DateTimeKind.Local).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 10, 8, 38, 106, DateTimeKind.Local).AddTicks(810), new DateTime(2025, 12, 3, 10, 8, 38, 106, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 10, 8, 38, 106, DateTimeKind.Local).AddTicks(486), new DateTime(2025, 12, 3, 10, 8, 38, 106, DateTimeKind.Local).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 10, 8, 38, 106, DateTimeKind.Local).AddTicks(502), new DateTime(2025, 12, 3, 10, 8, 38, 106, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 10, 8, 38, 106, DateTimeKind.Local).AddTicks(700), new DateTime(2025, 12, 3, 10, 8, 38, 106, DateTimeKind.Local).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 10, 8, 38, 106, DateTimeKind.Local).AddTicks(703), new DateTime(2025, 12, 3, 10, 8, 38, 106, DateTimeKind.Local).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 10, 8, 38, 106, DateTimeKind.Local).AddTicks(705), new DateTime(2025, 12, 3, 10, 8, 38, 106, DateTimeKind.Local).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 10, 8, 38, 106, DateTimeKind.Local).AddTicks(707), new DateTime(2025, 12, 3, 10, 8, 38, 106, DateTimeKind.Local).AddTicks(708) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "664ad599-d589-4fd8-94cb-7eeee45095f7", "AQAAAAIAAYagAAAAEC1hLANhYFY6U+a8D7QC05mAsRy2ZZRc8nEWMAEyBRpNBvB/fAZxvPbeQhBVZVqDzg==", "a3075018-5fcf-4eca-aad1-4f21457c1b92" });

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
        }
    }
}

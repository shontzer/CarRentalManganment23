using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManganment23.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "6e5ab593-b14a-4956-8d89-1662f38b01a9", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEAN/7BX6tfEpfF0dfcO9OpxEfP+5+3KTF1ZcvGUJaaCX+g/y5wu23KMpmiG0txjMDw==", null, false, "751b37af-c0ac-4ed3-86b9-a28eb8aae7af", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 12, 22, 6, 16, 20, 849, DateTimeKind.Local).AddTicks(5422), new DateTime(2023, 12, 22, 6, 16, 20, 849, DateTimeKind.Local).AddTicks(5432), "Black", "System" },
                    { 2, "System", new DateTime(2023, 12, 22, 6, 16, 20, 849, DateTimeKind.Local).AddTicks(5434), new DateTime(2023, 12, 22, 6, 16, 20, 849, DateTimeKind.Local).AddTicks(5434), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 12, 22, 6, 16, 20, 849, DateTimeKind.Local).AddTicks(5676), new DateTime(2023, 12, 22, 6, 16, 20, 849, DateTimeKind.Local).AddTicks(5677), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 12, 22, 6, 16, 20, 849, DateTimeKind.Local).AddTicks(5678), new DateTime(2023, 12, 22, 6, 16, 20, 849, DateTimeKind.Local).AddTicks(5678), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 12, 22, 6, 16, 20, 849, DateTimeKind.Local).AddTicks(5815), new DateTime(2023, 12, 22, 6, 16, 20, 849, DateTimeKind.Local).AddTicks(5815), "3 Serires", "System" },
                    { 2, "System", new DateTime(2023, 12, 22, 6, 16, 20, 849, DateTimeKind.Local).AddTicks(5817), new DateTime(2023, 12, 22, 6, 16, 20, 849, DateTimeKind.Local).AddTicks(5817), "X5", "System" },
                    { 3, "System", new DateTime(2023, 12, 22, 6, 16, 20, 849, DateTimeKind.Local).AddTicks(5818), new DateTime(2023, 12, 22, 6, 16, 20, 849, DateTimeKind.Local).AddTicks(5819), "Rav4", "System" }
                });

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
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}

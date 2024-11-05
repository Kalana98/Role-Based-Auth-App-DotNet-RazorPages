using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthWebApp.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b1232a8-1e21-4a5f-9d97-338f819c212e", null, "client", "client" },
                    { "9b270b18-5372-4892-9b33-e409f4d2f9e4", null, "seller", "seller" },
                    { "e11ecb9a-8410-4e9f-9d69-a67cf4d8c37f", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b1232a8-1e21-4a5f-9d97-338f819c212e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b270b18-5372-4892-9b33-e409f4d2f9e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e11ecb9a-8410-4e9f-9d69-a67cf4d8c37f");
        }
    }
}

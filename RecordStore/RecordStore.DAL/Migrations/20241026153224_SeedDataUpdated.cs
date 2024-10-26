using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecordStore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 12,
                column: "Discount",
                value: 0.85m);

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Album",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Discount", "IsActive", "Name", "Price", "PublishedDate", "Singers", "UpdatedDate" },
                values: new object[,]
                {
                    { 13, new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, null, false, "Sametten Nameler", 100m, new DateOnly(2024, 10, 26), "Samet", null },
                    { 14, new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, 0.8m, true, "Sametten Nameler", 100m, new DateOnly(2024, 10, 26), "Samet", null },
                    { 15, new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, null, false, "Sametten Nameler", 100m, new DateOnly(2024, 10, 26), "Samet", null },
                    { 16, new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, null, false, "Sametten Nameler", 100m, new DateOnly(2024, 10, 26), "Samet", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 12,
                column: "Discount",
                value: null);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecordStore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Albums",
                table: "Albums");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Albums",
                newName: "Album",
                newSchema: "dbo");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                schema: "dbo",
                table: "User",
                type: "varchar(40)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Singers",
                schema: "dbo",
                table: "Album",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                schema: "dbo",
                table: "Album",
                type: "decimal(7,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Album",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                schema: "dbo",
                table: "Album",
                type: "decimal(7,2)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                schema: "dbo",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Album",
                schema: "dbo",
                table: "Album",
                column: "Id");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Album",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Discount", "IsActive", "Name", "Price", "PublishedDate", "Singers", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, null, true, "Sametten Nameler", 100m, new DateOnly(2024, 10, 26), "Samet", null },
                    { 2, new DateTime(2024, 9, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, 0.5m, true, "Batuhandan Nameler", 200m, new DateOnly(2024, 10, 25), "Batuhan", null },
                    { 3, new DateTime(2024, 8, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, null, true, "Meltemden Nameler", 300m, new DateOnly(2024, 10, 24), "Meltem", null },
                    { 4, new DateTime(2024, 7, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, null, true, "Aydandan Nameler", 400m, new DateOnly(2024, 10, 23), "Aydan", null },
                    { 5, new DateTime(2024, 6, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, null, true, "Ankaranın Ayazı", 500m, new DateOnly(2024, 11, 22), "Ankaranın Bağları", null },
                    { 6, new DateTime(2024, 5, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, null, true, "Ankaranın Ayazı", 500m, new DateOnly(2024, 11, 22), "Ankaranın Bağları", null },
                    { 7, new DateTime(2024, 4, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, null, true, "Ankaranın Ayazı", 500m, new DateOnly(2024, 11, 22), "Ankaranın Bağları", null },
                    { 8, new DateTime(2024, 3, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, null, true, "Ankaranın Ayazı", 500m, new DateOnly(2024, 11, 22), "Ankaranın Bağları", null },
                    { 9, new DateTime(2024, 2, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, null, true, "Ankaranın Ayazı", 500m, new DateOnly(2024, 11, 22), "Ankaranın Bağları", null },
                    { 10, new DateTime(2024, 1, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, null, true, "Ankaranın Ayazı", 500m, new DateOnly(2024, 11, 22), "Ankaranın Bağları", null },
                    { 11, new DateTime(2024, 6, 10, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, null, true, "Ankaranın Ayazı", 500m, new DateOnly(2024, 11, 22), "Ankaranın Bağları", null },
                    { 12, new DateTime(2024, 6, 9, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, null, true, "Ankaranın Ayazı", 500m, new DateOnly(2024, 11, 22), "Ankaranın Bağları", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "User",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Password", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "7908281b119b087a0c719cd42d7d75a9f301304f4db96b03756001317dbd942f", null, "Samet" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "982357496c6e531cba092c30369173cf0277e81553aa215c0c4c06529d05ea30", null, "Meltem" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "dd130a849d7b29e5541b05d2f7f86a4acd4f1ec598c1c9438783f56bc4f0ff80", null, "Batuhan" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "f3c6b429c665c140db8fe878b5bef89ae9e1be09bd87ecd537706b8db3ef7e62", null, "Aydan" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                schema: "dbo",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Album",
                schema: "dbo",
                table: "Album");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "User",
                schema: "dbo",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Album",
                schema: "dbo",
                newName: "Albums");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(40)");

            migrationBuilder.AlterColumn<string>(
                name: "Singers",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Albums",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(7,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<double>(
                name: "Discount",
                table: "Albums",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(decimal),
                oldType: "decimal(7,2)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Albums",
                table: "Albums",
                column: "Id");
        }
    }
}

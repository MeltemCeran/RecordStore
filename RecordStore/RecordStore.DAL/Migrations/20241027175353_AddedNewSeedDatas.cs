using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecordStore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewSeedDatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Discount", "Name", "PublishedDate", "Singers" },
                values: new object[] { 0.78m, "AM", new DateOnly(2013, 8, 12), "Arctic Monkeys" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "PublishedDate", "Singers" },
                values: new object[] { "Favourite Worst Nightmare", new DateOnly(2007, 10, 3), "Arctic Monkeys" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Discount", "Name", "PublishedDate", "Singers" },
                values: new object[] { 0.76m, "Biraz Pop Biraz Sezen", new DateOnly(2017, 2, 17), "Sezen Aksu" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Discount", "IsActive", "Name", "Price", "PublishedDate", "Singers" },
                values: new object[] { 0.76m, false, "Please Please Me", 750m, new DateOnly(1963, 7, 11), "The Beatles" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Discount", "Name", "PublishedDate", "Singers" },
                values: new object[] { 1m, "CryBaby", new DateOnly(2016, 6, 18), "Lil Peep" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Discount", "Name", "Price", "PublishedDate", "Singers" },
                values: new object[] { 0.89m, "Astroworld", 625m, new DateOnly(2023, 5, 21), "Travis Scott" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Discount", "IsActive", "Name", "Price", "PublishedDate", "Singers" },
                values: new object[] { 0.78m, false, "Bak Kollarım Burada", 310m, new DateOnly(2019, 4, 5), "Mert Demir" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Discount", "Name", "Price", "PublishedDate", "Singers" },
                values: new object[] { 0.93m, "Homecoming", 900m, new DateOnly(2019, 9, 7), "Beyonce" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Discount", "IsActive", "Name", "Price", "PublishedDate", "Singers" },
                values: new object[] { 0.95m, false, "Yolcu", 95m, new DateOnly(2003, 5, 13), "Neşet Ertaş" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Discount", "Name", "Price", "PublishedDate", "Singers" },
                values: new object[] { 0.85m, "Seni Kendime Sakladım", 175m, new DateOnly(2004, 5, 19), "Duman" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Discount", "Name", "Price", "PublishedDate", "Singers" },
                values: new object[] { 0.7m, "Antichrist Superstar", 700m, new DateOnly(1996, 10, 8), "Marilyn Manson" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Discount", "Name", "Price", "PublishedDate", "Singers" },
                values: new object[] { 0.65m, "Hal Hal", 585m, new DateOnly(1989, 11, 22), "Barış Manço" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Discount", "Name", "PublishedDate", "Singers" },
                values: new object[] { 1m, "In Utero", new DateOnly(1993, 9, 21), "Nirvana" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Discount", "Name", "Price", "PublishedDate", "Singers" },
                values: new object[] { 0.65m, "Büyük İnsan", 320m, new DateOnly(2010, 7, 16), "Gökhan Türkmen" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Discount", "Name", "Price", "PublishedDate", "Singers" },
                values: new object[] { 0.93m, "Resimdeki Gözyaşları", 700m, new DateOnly(1968, 8, 10), "Cem Karaca" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Discount", "IsActive", "Name", "Price", "PublishedDate", "Singers" },
                values: new object[] { 0.84m, true, "Dünden Yarına", 560m, new DateOnly(1988, 3, 17), "İlhan İrem'" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "1c878f9f7033734c34647bfd6bb1e312dd835f319b3df608873444f3a9e65769");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "45e01a38ba96519d7ad13fbf9cb03442768c9f3f2d4c69143554670e54d3f18b");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "428b5b31f6f928e466cba5926691b5b18b9dea5d8243114d27cb2909464f22d7");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "504d3d0e64bef294ad0e15b86f8813bc6ea3b20cd70787b98d47aadba7d98d0d");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Discount", "Name", "PublishedDate", "Singers" },
                values: new object[] { null, "Sametten Nameler", new DateOnly(2024, 10, 26), "Samet" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "PublishedDate", "Singers" },
                values: new object[] { "Batuhandan Nameler", new DateOnly(2024, 10, 25), "Batuhan" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Discount", "Name", "PublishedDate", "Singers" },
                values: new object[] { null, "Meltemden Nameler", new DateOnly(2024, 10, 24), "Meltem" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Discount", "IsActive", "Name", "Price", "PublishedDate", "Singers" },
                values: new object[] { null, true, "Aydandan Nameler", 400m, new DateOnly(2024, 10, 23), "Aydan" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Discount", "Name", "PublishedDate", "Singers" },
                values: new object[] { null, "Ankaranın Ayazı", new DateOnly(2024, 11, 22), "Ankaranın Bağları" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Discount", "Name", "Price", "PublishedDate", "Singers" },
                values: new object[] { null, "Ankaranın Ayazı", 500m, new DateOnly(2024, 11, 22), "Ankaranın Bağları" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Discount", "IsActive", "Name", "Price", "PublishedDate", "Singers" },
                values: new object[] { null, true, "Ankaranın Ayazı", 500m, new DateOnly(2024, 11, 22), "Ankaranın Bağları" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Discount", "Name", "Price", "PublishedDate", "Singers" },
                values: new object[] { null, "Ankaranın Ayazı", 500m, new DateOnly(2024, 11, 22), "Ankaranın Bağları" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Discount", "IsActive", "Name", "Price", "PublishedDate", "Singers" },
                values: new object[] { null, true, "Ankaranın Ayazı", 500m, new DateOnly(2024, 11, 22), "Ankaranın Bağları" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Discount", "Name", "Price", "PublishedDate", "Singers" },
                values: new object[] { null, "Ankaranın Ayazı", 500m, new DateOnly(2024, 11, 22), "Ankaranın Bağları" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Discount", "Name", "Price", "PublishedDate", "Singers" },
                values: new object[] { null, "Ankaranın Ayazı", 500m, new DateOnly(2024, 11, 22), "Ankaranın Bağları" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Discount", "Name", "Price", "PublishedDate", "Singers" },
                values: new object[] { 0.85m, "Ankaranın Ayazı", 500m, new DateOnly(2024, 11, 22), "Ankaranın Bağları" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Discount", "Name", "PublishedDate", "Singers" },
                values: new object[] { null, "Sametten Nameler", new DateOnly(2024, 10, 26), "Samet" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Discount", "Name", "Price", "PublishedDate", "Singers" },
                values: new object[] { 0.8m, "Sametten Nameler", 100m, new DateOnly(2024, 10, 26), "Samet" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Discount", "Name", "Price", "PublishedDate", "Singers" },
                values: new object[] { null, "Sametten Nameler", 100m, new DateOnly(2024, 10, 26), "Samet" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Album",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Discount", "IsActive", "Name", "Price", "PublishedDate", "Singers" },
                values: new object[] { null, false, "Sametten Nameler", 100m, new DateOnly(2024, 10, 26), "Samet" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "7908281b119b087a0c719cd42d7d75a9f301304f4db96b03756001317dbd942f");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "982357496c6e531cba092c30369173cf0277e81553aa215c0c4c06529d05ea30");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "dd130a849d7b29e5541b05d2f7f86a4acd4f1ec598c1c9438783f56bc4f0ff80");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "f3c6b429c665c140db8fe878b5bef89ae9e1be09bd87ecd537706b8db3ef7e62");
        }
    }
}

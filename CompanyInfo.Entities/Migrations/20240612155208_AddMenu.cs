using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyInfo.Entities.Migrations
{
    /// <inheritdoc />
    public partial class AddMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ActionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ControllerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Area = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QueryStrings = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Css = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ParentMenuId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Menu_ParentMenuId",
                        column: x => x.ParentMenuId,
                        principalTable: "Menu",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 18, 52, 7, 471, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 18, 52, 7, 471, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 18, 52, 7, 471, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 18, 52, 7, 471, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 18, 52, 7, 472, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 18, 52, 7, 472, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 18, 52, 7, 472, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 18, 52, 7, 472, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "ActionName", "Area", "Class", "ControllerName", "CreateDate", "Css", "Description", "Name", "OrderNo", "ParentId", "ParentMenuId", "QueryStrings" },
                values: new object[,]
                {
                    { 1, "", "", null, "", new DateTime(2024, 6, 12, 18, 52, 7, 476, DateTimeKind.Local).AddTicks(731), null, "Urun Yonetimi", "Urun Yonetimi", null, null, null, null },
                    { 2, "Index", "Admin", null, "Urun", new DateTime(2024, 6, 12, 18, 52, 7, 476, DateTimeKind.Local).AddTicks(759), null, "Urunler", "Urunler", null, 1, null, null },
                    { 3, "Index", "Admin", null, "Kategori", new DateTime(2024, 6, 12, 18, 52, 7, 476, DateTimeKind.Local).AddTicks(762), null, "Kategoriler", "Kategoriler", null, 1, null, null },
                    { 4, "KategoriYonet", "Admin", null, "Urun", new DateTime(2024, 6, 12, 18, 52, 7, 476, DateTimeKind.Local).AddTicks(769), null, "Urunlere Kategori Ekle", "Urunlere Kategori Ekleme", null, 1, null, null },
                    { 5, "UrunYonet", "Admin", null, "Kategori", new DateTime(2024, 6, 12, 18, 52, 7, 476, DateTimeKind.Local).AddTicks(772), null, "Kategorilere Urun Ekle", "Kategorilere Urun Ekleme", null, 1, null, null },
                    { 6, "", "", null, "", new DateTime(2024, 6, 12, 18, 52, 7, 476, DateTimeKind.Local).AddTicks(776), null, "Tedarikciler", "Tedarikciler", null, null, null, null },
                    { 7, "Index", "Admin", null, "Tedarikci", new DateTime(2024, 6, 12, 18, 52, 7, 476, DateTimeKind.Local).AddTicks(779), null, "Tedarikciler", "Tedarikciler", null, 6, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 18, 52, 7, 476, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 18, 52, 7, 476, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 18, 52, 7, 476, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 18, 52, 7, 476, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 18, 52, 7, 476, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 18, 52, 7, 476, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.CreateIndex(
                name: "IX_Menu_ParentMenuId",
                table: "Menu",
                column: "ParentMenuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 15, 57, 58, 428, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 15, 57, 58, 428, DateTimeKind.Local).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 15, 57, 58, 428, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 15, 57, 58, 428, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 15, 57, 58, 428, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 15, 57, 58, 428, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 15, 57, 58, 428, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 15, 57, 58, 428, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 15, 57, 58, 428, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 15, 57, 58, 428, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 15, 57, 58, 428, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 15, 57, 58, 429, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 15, 57, 58, 429, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 12, 15, 57, 58, 429, DateTimeKind.Local).AddTicks(1496));
        }
    }
}

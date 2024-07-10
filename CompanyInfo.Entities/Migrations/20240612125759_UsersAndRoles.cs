using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyInfo.Entities.Migrations
{
    /// <inheritdoc />
    public partial class UsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gsm = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cinsiyet = table.Column<bool>(type: "bit", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    KullanicilarId = table.Column<int>(type: "int", nullable: false),
                    RollerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.KullanicilarId, x.RollerId });
                    table.ForeignKey(
                        name: "FK_RoleUser_Roller_RollerId",
                        column: x => x.RollerId,
                        principalTable: "Roller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_Users_KullanicilarId",
                        column: x => x.KullanicilarId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Roller",
                columns: new[] { "Id", "CreateDate", "RoleAdi" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 12, 15, 57, 58, 428, DateTimeKind.Local).AddTicks(8547), "Admin" },
                    { 2, new DateTime(2024, 6, 12, 15, 57, 58, 428, DateTimeKind.Local).AddTicks(8553), "User" },
                    { 3, new DateTime(2024, 6, 12, 15, 57, 58, 428, DateTimeKind.Local).AddTicks(8554), "Satis" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_RollerId",
                table: "RoleUser",
                column: "RollerId");

            migrationBuilder.CreateIndex(
                name: "IX_Roller_RoleAdi",
                table: "Roller",
                column: "RoleAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Gsm",
                table: "Users",
                column: "Gsm",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropTable(
                name: "Roller");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 30, 15, 49, 19, 333, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 5, 30, 15, 49, 19, 333, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 5, 30, 15, 49, 19, 333, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 5, 30, 15, 49, 19, 333, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 30, 15, 49, 19, 333, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 5, 30, 15, 49, 19, 333, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 5, 30, 15, 49, 19, 333, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 5, 30, 15, 49, 19, 333, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 30, 15, 49, 19, 333, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 5, 30, 15, 49, 19, 333, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 5, 30, 15, 49, 19, 333, DateTimeKind.Local).AddTicks(9094));
        }
    }
}

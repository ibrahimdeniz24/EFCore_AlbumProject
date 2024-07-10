using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFA_PlakDükkanı.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseUser",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReSifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Adi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Soyadi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseUser", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sanatci = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fiyati = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IndirimOranı = table.Column<short>(type: "smallint", nullable: true),
                    IsActive = table.Column<int>(type: "int", nullable: true),
                    EkleyenAdminID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Albums_BaseUser_EkleyenAdminID",
                        column: x => x.EkleyenAdminID,
                        principalTable: "BaseUser",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_EkleyenAdminID",
                table: "Albums",
                column: "EkleyenAdminID");

            migrationBuilder.CreateIndex(
                name: "IX_BaseUser_KullaniciAdi",
                table: "BaseUser",
                column: "KullaniciAdi",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "BaseUser");
        }
    }
}

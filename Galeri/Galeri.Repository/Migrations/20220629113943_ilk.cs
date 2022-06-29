using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.Repository.Migrations
{
    public partial class ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Araçlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    Marka = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Açıklama = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Renk = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ÜretimYılı = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    KmDurumu = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Araçlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Araçlar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "Id", "Ad" },
                values: new object[,]
                {
                    { 1, "Sedan" },
                    { 2, "Hatchback" },
                    { 3, "Cabrio" },
                    { 4, "Elektrikli" },
                    { 5, "Suv" }
                });

            migrationBuilder.InsertData(
                table: "Araçlar",
                columns: new[] { "Id", "Açıklama", "Fiyat", "KategoriId", "KmDurumu", "Marka", "Model", "Renk", "ÜretimYılı" },
                values: new object[] { 1, "Hasarsız", 5250m, 1, "125000", "BMW", "3.20i", "sarı", "2010" });

            migrationBuilder.InsertData(
                table: "Araçlar",
                columns: new[] { "Id", "Açıklama", "Fiyat", "KategoriId", "KmDurumu", "Marka", "Model", "Renk", "ÜretimYılı" },
                values: new object[] { 2, "Hasarlı", 4250m, 1, "150000", "BMW", "5.20i", "beyaz", "2009" });

            migrationBuilder.CreateIndex(
                name: "IX_Araçlar_KategoriId",
                table: "Araçlar",
                column: "KategoriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Araçlar");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}

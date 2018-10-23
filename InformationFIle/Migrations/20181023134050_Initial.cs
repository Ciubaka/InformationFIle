using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InformationFIle.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Information",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SHA256 = table.Column<string>(nullable: true),
                    SHA1 = table.Column<string>(nullable: true),
                    MD5 = table.Column<string>(nullable: true),
                    Nazwa = table.Column<string>(nullable: true),
                    Rozszerzenie = table.Column<string>(nullable: true),
                    Rozmiar = table.Column<string>(nullable: true),
                    DataOstatniegoDostepu = table.Column<string>(nullable: true),
                    Atrybuty = table.Column<string>(nullable: true),
                    Magic = table.Column<string>(nullable: true),
                    OrginalnaNazwa = table.Column<string>(nullable: true),
                    Jezyk = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    FileVersion = table.Column<string>(nullable: true),
                    VersionProduct = table.Column<string>(nullable: true),
                    ImportowaneBiblioteki = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Information", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Information");
        }
    }
}

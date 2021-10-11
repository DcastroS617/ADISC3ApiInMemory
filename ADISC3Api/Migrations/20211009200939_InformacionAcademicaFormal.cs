using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ADISC3Api.Migrations
{
    public partial class InformacionAcademicaFormal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InformacionAcademicaFormal",
                columns: table => new
                {
                    IdInformacionAcademica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Institucion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Acreditacion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FechaGraduacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacionAcademicaFormal", x => x.IdInformacionAcademica);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InformacionAcademicaFormal");
        }
    }
}

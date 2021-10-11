using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ADISC3Api.Migrations
{
    public partial class InformacionAcademicaComplementaria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InformacionAcademicaComplementaria",
                columns: table => new
                {
                    IdInformacionAcademicaComplementaria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Institucion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Acreditacion = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    FechaGraduacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacionAcademicaComplementaria", x => x.IdInformacionAcademicaComplementaria);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InformacionAcademicaComplementaria");
        }
    }
}

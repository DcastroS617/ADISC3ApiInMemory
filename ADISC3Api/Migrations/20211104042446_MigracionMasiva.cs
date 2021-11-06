using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ADISC3Api.Migrations
{
    public partial class MigracionMasiva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InformacionAcademicaComplementaria",
                columns: table => new
                {
                    IdInformacionAcademicaComp = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Institucion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Acreditacion = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    FechaGraduacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacionAcademicaComplementaria", x => x.IdInformacionAcademicaComp);
                });

            migrationBuilder.CreateTable(
                name: "InformacionAcademicaFormal",
                columns: table => new
                {
                    IdInformacionAcademicaFormal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Institucion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Acreditacion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FechaGraduacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacionAcademicaFormal", x => x.IdInformacionAcademicaFormal);
                });

            migrationBuilder.CreateTable(
                name: "InformacionAcademicaIdioma",
                columns: table => new
                {
                    IdInformacionAcademicaIdioma = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idioma = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Nivel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacionAcademicaIdioma", x => x.IdInformacionAcademicaIdioma);
                });

            migrationBuilder.CreateTable(
                name: "InformacionContacto",
                columns: table => new
                {
                    IdInfoContacto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TelefonoCelular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoOficina = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoCasa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonoExtra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZIP = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    ContactoEmergencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactoEmergenciaNombre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacionContacto", x => x.IdInfoContacto);
                });

            migrationBuilder.CreateTable(
                name: "InformacionDireccion",
                columns: table => new
                {
                    IdInformacionDireccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Provincia = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Canton = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Distrito = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    DireccionExacta = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacionDireccion", x => x.IdInformacionDireccion);
                });

            migrationBuilder.CreateTable(
                name: "InformacionLaboral",
                columns: table => new
                {
                    IdInfoLaboral = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Institucion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacionLaboral", x => x.IdInfoLaboral);
                });

            migrationBuilder.CreateTable(
                name: "InformacionPersonal",
                columns: table => new
                {
                    IdInfoPersonal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrimerApellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroAsegurado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EstadoCivil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoSangre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CuentaBancaria = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BancoEspecifico = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacionPersonal", x => x.IdInfoPersonal);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    IdLogin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cedula = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.IdLogin);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InformacionAcademicaComplementaria");

            migrationBuilder.DropTable(
                name: "InformacionAcademicaFormal");

            migrationBuilder.DropTable(
                name: "InformacionAcademicaIdioma");

            migrationBuilder.DropTable(
                name: "InformacionContacto");

            migrationBuilder.DropTable(
                name: "InformacionDireccion");

            migrationBuilder.DropTable(
                name: "InformacionLaboral");

            migrationBuilder.DropTable(
                name: "InformacionPersonal");

            migrationBuilder.DropTable(
                name: "Login");
        }
    }
}

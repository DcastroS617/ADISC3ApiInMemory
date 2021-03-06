using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ADISC3Api.Migrations
{
    public partial class MigracionMasiva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "InformacionPersonal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_InformacionPersonal", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "InformacionAcademicaComplementaria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Institucion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Acreditacion = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    FechaGraduacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InformacionPersonalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacionAcademicaComplementaria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InformacionAcademicaComplementaria_InformacionPersonal_InformacionPersonalId",
                        column: x => x.InformacionPersonalId,
                        principalTable: "InformacionPersonal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InformacionAcademicaFormal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Institucion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Acreditacion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FechaGraduacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InformacionPersonalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacionAcademicaFormal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InformacionAcademicaFormal_InformacionPersonal_InformacionPersonalId",
                        column: x => x.InformacionPersonalId,
                        principalTable: "InformacionPersonal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InformacionAcademicaIdioma",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idioma = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Nivel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    InformacionPersonalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacionAcademicaIdioma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InformacionAcademicaIdioma_InformacionPersonal_InformacionPersonalId",
                        column: x => x.InformacionPersonalId,
                        principalTable: "InformacionPersonal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InformacionLaboral",
                columns: table => new
                {
                    IdInfoLaboral = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Institucion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InformacionPersonalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacionLaboral", x => x.IdInfoLaboral);
                    table.ForeignKey(
                        name: "FK_InformacionLaboral_InformacionPersonal_InformacionPersonalId",
                        column: x => x.InformacionPersonalId,
                        principalTable: "InformacionPersonal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InformacionAcademicaComplementaria_InformacionPersonalId",
                table: "InformacionAcademicaComplementaria",
                column: "InformacionPersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_InformacionAcademicaFormal_InformacionPersonalId",
                table: "InformacionAcademicaFormal",
                column: "InformacionPersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_InformacionAcademicaIdioma_InformacionPersonalId",
                table: "InformacionAcademicaIdioma",
                column: "InformacionPersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_InformacionLaboral_InformacionPersonalId",
                table: "InformacionLaboral",
                column: "InformacionPersonalId");
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
                name: "Login");

            migrationBuilder.DropTable(
                name: "InformacionPersonal");
        }
    }
}

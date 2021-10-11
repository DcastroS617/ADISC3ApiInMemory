using Microsoft.EntityFrameworkCore.Migrations;

namespace ADISC3Api.Migrations
{
    public partial class InformacionContacto : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InformacionContacto");
        }
    }
}

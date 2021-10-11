using Microsoft.EntityFrameworkCore.Migrations;

namespace ADISC3Api.Migrations
{
    public partial class InformacionDireccion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InformacionDireccion");
        }
    }
}

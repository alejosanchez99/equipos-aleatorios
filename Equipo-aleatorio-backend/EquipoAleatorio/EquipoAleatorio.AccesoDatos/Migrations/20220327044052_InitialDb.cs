using Microsoft.EntityFrameworkCore.Migrations;

namespace EquipoAleatorio.AccesoDatos.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoJugador",
                columns: table => new
                {
                    IdTipoJugador = table.Column<int>(type: "int", nullable: false),
                    NombreTipoJugador = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoJugador", x => x.IdTipoJugador);
                });

            migrationBuilder.CreateTable(
                name: "Jugador",
                columns: table => new
                {
                    IdJugador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreJugador = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdTipoJugador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugador", x => x.IdJugador);
                    table.ForeignKey(
                        name: "FK_Jugador_TipoJugador_IdTipoJugador",
                        column: x => x.IdTipoJugador,
                        principalTable: "TipoJugador",
                        principalColumn: "IdTipoJugador",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jugador_IdTipoJugador",
                table: "Jugador",
                column: "IdTipoJugador");

            migrationBuilder.CreateIndex(
                name: "IX_Jugador_NombreJugador",
                table: "Jugador",
                column: "NombreJugador",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jugador");

            migrationBuilder.DropTable(
                name: "TipoJugador");
        }
    }
}

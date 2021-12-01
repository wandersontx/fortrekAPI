using Microsoft.EntityFrameworkCore.Migrations;

namespace ForTrek.API.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "marcas",
                columns: table => new
                {
                    MarcaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Ano_fundacao = table.Column<string>(type: "TEXT", nullable: true),
                    Fundador = table.Column<string>(type: "TEXT", nullable: true),
                    Sede = table.Column<string>(type: "TEXT", nullable: true),
                    CEO = table.Column<string>(type: "TEXT", nullable: true),
                    site = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marcas", x => x.MarcaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "marcas");
        }
    }
}

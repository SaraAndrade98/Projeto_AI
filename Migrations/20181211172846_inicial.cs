using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto_AI.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DispositivoEletronico",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Ano = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Preco = table.Column<int>(nullable: false),
                    IncidentesAquaticos = table.Column<bool>(nullable: false),
                    Acessorios = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DispositivoEletronico", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DispositivoEletronico");
        }
    }
}

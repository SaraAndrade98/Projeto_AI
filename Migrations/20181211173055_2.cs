using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto_AI.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Estado_Final",
                table: "DispositivoEletronico",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Marca_Final",
                table: "DispositivoEletronico",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado_Final",
                table: "DispositivoEletronico");

            migrationBuilder.DropColumn(
                name: "Marca_Final",
                table: "DispositivoEletronico");
        }
    }
}

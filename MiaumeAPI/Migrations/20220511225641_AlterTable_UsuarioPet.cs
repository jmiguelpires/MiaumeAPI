using Microsoft.EntityFrameworkCore.Migrations;

namespace MiaumeAPI.Migrations
{
    public partial class AlterTable_UsuarioPet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "inPersonalidadeAventureiro",
                table: "UsuarioPet");

            migrationBuilder.DropColumn(
                name: "inPersonalidadeTimido",
                table: "UsuarioPet");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "inPersonalidadeAventureiro",
                table: "UsuarioPet",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "inPersonalidadeTimido",
                table: "UsuarioPet",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}

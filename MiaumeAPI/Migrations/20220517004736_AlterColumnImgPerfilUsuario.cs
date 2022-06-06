using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiaumeAPI.Migrations
{
    public partial class AlterColumnImgPerfilUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "municipio",
                table: "Usuario");

            migrationBuilder.AlterColumn<string>(
                name: "imgFotoPerfil",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "imgFotoPerfil",
                table: "Usuario",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "municipio",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

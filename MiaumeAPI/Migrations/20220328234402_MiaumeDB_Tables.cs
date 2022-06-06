using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiaumeAPI.Migrations
{
    public partial class MiaumeDB_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    CPFCNPJ = table.Column<long>(type: "bigint", nullable: false),
                    nmUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dtNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    imgFotoPerfil = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    inPessoaFisica = table.Column<bool>(type: "bit", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cdEstado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    municipio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.CPFCNPJ);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioPet",
                columns: table => new
                {
                    idPet = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPFCNPJ = table.Column<long>(type: "bigint", nullable: false),
                    tipoPet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nmPet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dtNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    raca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    porte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pesokg = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    inVacinado = table.Column<bool>(type: "bit", nullable: false),
                    inVermifugado = table.Column<bool>(type: "bit", nullable: false),
                    inPedigree = table.Column<bool>(type: "bit", nullable: false),
                    inCuidadoEspecial = table.Column<bool>(type: "bit", nullable: false),
                    inPersonalidadeDocil = table.Column<bool>(type: "bit", nullable: false),
                    inPersonalidadeTranquilo = table.Column<bool>(type: "bit", nullable: false),
                    inPersonalidadeAlerta = table.Column<bool>(type: "bit", nullable: false),
                    inPersonalidadeAgressivo = table.Column<bool>(type: "bit", nullable: false),
                    inPersonalidadeAtivoMinimo = table.Column<bool>(type: "bit", nullable: false),
                    inPersonalidadeAtivoMedio = table.Column<bool>(type: "bit", nullable: false),
                    inPersonalidadeAtivoMaximo = table.Column<bool>(type: "bit", nullable: false),
                    inPersonalidadeCarinhoso = table.Column<bool>(type: "bit", nullable: false),
                    inPersonalidadeAssustado = table.Column<bool>(type: "bit", nullable: false),
                    inPersonalidadePreguicoso = table.Column<bool>(type: "bit", nullable: false),
                    inPersonalidadeExplorador = table.Column<bool>(type: "bit", nullable: false),
                    inPersonalidadeAventureiro = table.Column<bool>(type: "bit", nullable: false),
                    inPersonalidadeCurioso = table.Column<bool>(type: "bit", nullable: false),
                    inPersonalidadeTimido = table.Column<bool>(type: "bit", nullable: false),
                    inPersonalidadeMedroso = table.Column<bool>(type: "bit", nullable: false),
                    ImgPet1 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ImgPet2 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ImgPet3 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ImgPet4 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    txDescricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dtCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dtAdotado = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioPet", x => x.idPet);
                    table.ForeignKey(
                        name: "FK_UsuarioPet_Usuario_CPFCNPJ",
                        column: x => x.CPFCNPJ,
                        principalTable: "Usuario",
                        principalColumn: "CPFCNPJ",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioPet_CPFCNPJ",
                table: "UsuarioPet",
                column: "CPFCNPJ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuarioPet");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}

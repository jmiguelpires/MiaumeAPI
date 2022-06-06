﻿// <auto-generated />
using System;
using MiaumeAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MiaumeAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220328234402_MiaumeDB_Tables")]
    partial class MiaumeDB_Tables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MiaumeAPI.Models.Usuario", b =>
                {
                    b.Property<long>("CPFCNPJ")
                        .HasColumnType("bigint");

                    b.Property<string>("cdEstado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dtNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("imgFotoPerfil")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("inPessoaFisica")
                        .HasColumnType("bit");

                    b.Property<string>("municipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nmUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CPFCNPJ");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("MiaumeAPI.Models.UsuarioPet", b =>
                {
                    b.Property<long>("idPet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CPFCNPJ")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("ImgPet1")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("ImgPet2")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("ImgPet3")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("ImgPet4")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime?>("dtAdotado")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dtCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dtNascimento")
                        .HasColumnType("datetime2");

                    b.Property<bool>("inCuidadoEspecial")
                        .HasColumnType("bit");

                    b.Property<bool>("inPedigree")
                        .HasColumnType("bit");

                    b.Property<bool>("inPersonalidadeAgressivo")
                        .HasColumnType("bit");

                    b.Property<bool>("inPersonalidadeAlerta")
                        .HasColumnType("bit");

                    b.Property<bool>("inPersonalidadeAssustado")
                        .HasColumnType("bit");

                    b.Property<bool>("inPersonalidadeAtivoMaximo")
                        .HasColumnType("bit");

                    b.Property<bool>("inPersonalidadeAtivoMedio")
                        .HasColumnType("bit");

                    b.Property<bool>("inPersonalidadeAtivoMinimo")
                        .HasColumnType("bit");

                    b.Property<bool>("inPersonalidadeAventureiro")
                        .HasColumnType("bit");

                    b.Property<bool>("inPersonalidadeCarinhoso")
                        .HasColumnType("bit");

                    b.Property<bool>("inPersonalidadeCurioso")
                        .HasColumnType("bit");

                    b.Property<bool>("inPersonalidadeDocil")
                        .HasColumnType("bit");

                    b.Property<bool>("inPersonalidadeExplorador")
                        .HasColumnType("bit");

                    b.Property<bool>("inPersonalidadeMedroso")
                        .HasColumnType("bit");

                    b.Property<bool>("inPersonalidadePreguicoso")
                        .HasColumnType("bit");

                    b.Property<bool>("inPersonalidadeTimido")
                        .HasColumnType("bit");

                    b.Property<bool>("inPersonalidadeTranquilo")
                        .HasColumnType("bit");

                    b.Property<bool>("inVacinado")
                        .HasColumnType("bit");

                    b.Property<bool>("inVermifugado")
                        .HasColumnType("bit");

                    b.Property<string>("nmPet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("pesokg")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("porte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("raca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipoPet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("txDescricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idPet");

                    b.HasIndex("CPFCNPJ");

                    b.ToTable("UsuarioPet");
                });

            modelBuilder.Entity("MiaumeAPI.Models.UsuarioPet", b =>
                {
                    b.HasOne("MiaumeAPI.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("CPFCNPJ")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}

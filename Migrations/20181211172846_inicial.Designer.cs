﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projeto_AI.Models;

namespace Projeto_AI.Migrations
{
    [DbContext(typeof(Projeto_AIContext))]
    [Migration("20181211172846_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Projeto_AI.Models.DispositivoEletronico", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Acessorios");

                    b.Property<int>("Ano");

                    b.Property<bool>("IncidentesAquaticos");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int>("Preco");

                    b.HasKey("ID");

                    b.ToTable("DispositivoEletronico");
                });
#pragma warning restore 612, 618
        }
    }
}

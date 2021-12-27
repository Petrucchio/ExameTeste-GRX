﻿// <auto-generated />
using System;
using ExameTeste.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExameTeste.Migrations
{
    [DbContext(typeof(ExameTesteContext))]
    partial class ExameTesteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExameTeste.Models.FaixaEtaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Classificação");

                    b.HasKey("Id");

                    b.ToTable("FaixaEtaria");
                });

            modelBuilder.Entity("ExameTeste.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<int>("Age");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("FaixaEtariaId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("FaixaEtariaId");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("ExameTeste.Models.Pessoa", b =>
                {
                    b.HasOne("ExameTeste.Models.FaixaEtaria", "FaixaEtaria")
                        .WithMany("pessoas")
                        .HasForeignKey("FaixaEtariaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

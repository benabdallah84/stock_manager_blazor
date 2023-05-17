﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using comuneProject.Server.Controllers;

namespace comuneProject.Server.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20220308112935_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("comuneProject.Shared.Models.beneficie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Post")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("beneficies");
                });

            modelBuilder.Entity("comuneProject.Shared.Models.facture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Date_facture")
                        .HasColumnType("datetime2");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("FournisseurId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Num_facture")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("factures");
                });

            modelBuilder.Entity("comuneProject.Shared.Models.fournisseur", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Compte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("MF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RC")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("fournisseurs");
                });

            modelBuilder.Entity("comuneProject.Shared.Models.operation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("beneficieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("titre")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("operations");
                });

            modelBuilder.Entity("comuneProject.Shared.Models.product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Matricul")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prix_unitaire")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid?>("beneficieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("facturesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("operationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("productType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("products");
                });
#pragma warning restore 612, 618
        }
    }
}

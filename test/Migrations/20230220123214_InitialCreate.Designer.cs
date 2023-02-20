﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using test.Data;

#nullable disable

namespace test.Migrations
{
    [DbContext(typeof(testContext))]
    [Migration("20230220123214_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("test.Models.LignePanier", b =>
                {
                    b.Property<int>("LignePanierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LignePanierID"), 1L, 1);

                    b.Property<int>("PanierID")
                        .HasColumnType("int");

                    b.Property<int>("ProduitID")
                        .HasColumnType("int");

                    b.Property<int>("Quantite")
                        .HasColumnType("int");

                    b.HasKey("LignePanierID");

                    b.ToTable("LignePanier");
                });

            modelBuilder.Entity("test.Models.Panier", b =>
                {
                    b.Property<int>("PanierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PanierID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PanierID");

                    b.ToTable("Panier");
                });

            modelBuilder.Entity("test.Models.Produit", b =>
                {
                    b.Property<int>("ProduitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProduitID"), 1L, 1);

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Price")
                        .HasColumnType("real");

                    b.HasKey("ProduitID");

                    b.ToTable("Produit");
                });
#pragma warning restore 612, 618
        }
    }
}

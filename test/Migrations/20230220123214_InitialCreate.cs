﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LignePanier",
                columns: table => new
                {
                    LignePanierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantite = table.Column<int>(type: "int", nullable: false),
                    PanierID = table.Column<int>(type: "int", nullable: false),
                    ProduitID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LignePanier", x => x.LignePanierID);
                });

            migrationBuilder.CreateTable(
                name: "Panier",
                columns: table => new
                {
                    PanierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Panier", x => x.PanierID);
                });

            migrationBuilder.CreateTable(
                name: "Produit",
                columns: table => new
                {
                    ProduitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produit", x => x.ProduitID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LignePanier");

            migrationBuilder.DropTable(
                name: "Panier");

            migrationBuilder.DropTable(
                name: "Produit");
        }
    }
}

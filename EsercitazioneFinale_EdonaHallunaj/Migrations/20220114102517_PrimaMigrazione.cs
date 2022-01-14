using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EsercitazioneFinale_EdonaHallunaj.Migrations
{
    public partial class PrimaMigrazione : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    CodiceFiscale = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Cognome = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Indirizzo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.CodiceFiscale);
                });

            migrationBuilder.CreateTable(
                name: "Polizza",
                columns: table => new
                {
                    Numero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataStipula = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImportoAssicurato = table.Column<float>(type: "real", nullable: true),
                    RataMensile = table.Column<float>(type: "real", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PercentualeCoperta = table.Column<int>(type: "int", nullable: true),
                    Targa = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Cilindrata = table.Column<int>(type: "int", nullable: true),
                    AnniAssicurato = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polizza", x => x.Numero);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Polizza");
        }
    }
}

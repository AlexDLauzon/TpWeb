using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hackfest.Migrations
{
    public partial class DbHackfest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Réponses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Prénom = table.Column<string>(nullable: false),
                    Nom = table.Column<string>(nullable: false),
                    Courriel = table.Column<string>(nullable: false),
                    Affiliation = table.Column<string>(nullable: false),
                    DateInscription = table.Column<DateTime>(nullable: false),
                    Montant = table.Column<decimal>(type: "decimal(10, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Réponses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Réponses");
        }
    }
}

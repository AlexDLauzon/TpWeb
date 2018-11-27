using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hackfest.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "participant",
                columns: table => new
                {
                    id_participant = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    prénom_participant = table.Column<string>(nullable: false),
                    nom_participant = table.Column<string>(nullable: false),
                    courriel_participant = table.Column<string>(maxLength: 1, nullable: false),
                    affiliation = table.Column<string>(maxLength: 1, nullable: false),
                    date_inscription = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_participant", x => x.id_participant);
                });

            migrationBuilder.CreateTable(
                name: "article",
                columns: table => new
                {
                    id_article = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_participant = table.Column<int>(nullable: false),
                    titre_article = table.Column<string>(unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_article", x => x.id_article);
                    table.ForeignKey(
                        name: "cé_article_participant",
                        column: x => x.id_participant,
                        principalTable: "participant",
                        principalColumn: "id_participant",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "membre",
                columns: table => new
                {
                    id_membre = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_participant = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_membre", x => x.id_membre);
                    table.ForeignKey(
                        name: "cé_membre_participant",
                        column: x => x.id_participant,
                        principalTable: "participant",
                        principalColumn: "id_participant",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "organisateur",
                columns: table => new
                {
                    id_organisateur = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_participant = table.Column<int>(nullable: false),
                    mot_de_passe = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    rôle_organisateur = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organisateur", x => x.id_organisateur);
                    table.ForeignKey(
                        name: "cé_organisateur_participant",
                        column: x => x.id_participant,
                        principalTable: "participant",
                        principalColumn: "id_participant",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "paiement",
                columns: table => new
                {
                    id_paiement = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    montant = table.Column<decimal>(type: "money", nullable: false),
                    date_réception_paiement = table.Column<DateTime>(type: "date", nullable: false),
                    id_participant = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paiement", x => x.id_paiement);
                    table.ForeignKey(
                        name: "cé_paiement_participant",
                        column: x => x.id_participant,
                        principalTable: "participant",
                        principalColumn: "id_participant",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "version_article",
                columns: table => new
                {
                    id_version_article = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    url = table.Column<string>(nullable: false),
                    no_version = table.Column<int>(nullable: false),
                    date_soumission = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    id_article = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_version_article", x => x.id_version_article);
                    table.ForeignKey(
                        name: "cé_va_article",
                        column: x => x.id_article,
                        principalTable: "article",
                        principalColumn: "id_article",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "membre_article",
                columns: table => new
                {
                    id_article = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_membre = table.Column<int>(nullable: false),
                    note = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_membre_article", x => new { x.id_article, x.id_membre });
                    table.ForeignKey(
                        name: "cé_ma_article",
                        column: x => x.id_article,
                        principalTable: "article",
                        principalColumn: "id_article",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "cé_ma_membre",
                        column: x => x.id_membre,
                        principalTable: "membre",
                        principalColumn: "id_membre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "session",
                columns: table => new
                {
                    id_article = table.Column<int>(nullable: false),
                    id_membre = table.Column<int>(nullable: false),
                    titre_session = table.Column<string>(nullable: false),
                    date_session = table.Column<DateTime>(type: "datetime", nullable: false),
                    heure = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_session", x => x.id_membre);
                    table.UniqueConstraint("AK_session_id_article", x => x.id_article);
                    table.UniqueConstraint("AK_session_id_article_id_membre", x => new { x.id_article, x.id_membre });
                    table.ForeignKey(
                        name: "cé_session_article",
                        column: x => x.id_article,
                        principalTable: "article",
                        principalColumn: "id_article",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "cé_session_membre",
                        column: x => x.id_membre,
                        principalTable: "membre",
                        principalColumn: "id_membre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "spécialité",
                columns: table => new
                {
                    id_spécialité = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_membre = table.Column<int>(nullable: false),
                    spécialité = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spécialité", x => x.id_spécialité);
                    table.ForeignKey(
                        name: "cé_spécialité_membre",
                        column: x => x.id_membre,
                        principalTable: "membre",
                        principalColumn: "id_membre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_article_id_participant",
                table: "article",
                column: "id_participant");

            migrationBuilder.CreateIndex(
                name: "IX_membre_id_participant",
                table: "membre",
                column: "id_participant",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_membre_article_id_membre",
                table: "membre_article",
                column: "id_membre");

            migrationBuilder.CreateIndex(
                name: "IX_organisateur_id_participant",
                table: "organisateur",
                column: "id_participant",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_paiement_id_participant",
                table: "paiement",
                column: "id_participant");

            migrationBuilder.CreateIndex(
                name: "IX_spécialité_id_membre",
                table: "spécialité",
                column: "id_membre");

            migrationBuilder.CreateIndex(
                name: "IX_version_article_id_article",
                table: "version_article",
                column: "id_article");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "membre_article");

            migrationBuilder.DropTable(
                name: "organisateur");

            migrationBuilder.DropTable(
                name: "paiement");

            migrationBuilder.DropTable(
                name: "session");

            migrationBuilder.DropTable(
                name: "spécialité");

            migrationBuilder.DropTable(
                name: "version_article");

            migrationBuilder.DropTable(
                name: "membre");

            migrationBuilder.DropTable(
                name: "article");

            migrationBuilder.DropTable(
                name: "participant");
        }
    }
}

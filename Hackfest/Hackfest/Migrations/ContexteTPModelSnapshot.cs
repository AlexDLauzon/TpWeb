﻿// <auto-generated />
using System;
using Hackfest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hackfest.Migrations
{
    [DbContext(typeof(ContexteTP))]
    partial class ContexteTPModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hackfest.Models.Article", b =>
                {
                    b.Property<int>("IdArticle")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_article")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdParticipant")
                        .HasColumnName("id_participant");

                    b.Property<string>("TitreArticle")
                        .IsRequired()
                        .HasColumnName("titre_article")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.HasKey("IdArticle");

                    b.HasIndex("IdParticipant");

                    b.ToTable("article");
                });

            modelBuilder.Entity("Hackfest.Models.Membre", b =>
                {
                    b.Property<int>("IdMembre")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_membre")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdParticipant")
                        .HasColumnName("id_participant");

                    b.HasKey("IdMembre");

                    b.HasIndex("IdParticipant")
                        .IsUnique();

                    b.ToTable("membre");
                });

            modelBuilder.Entity("Hackfest.Models.MembreArticle", b =>
                {
                    b.Property<int>("IdArticle")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_article")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdMembre")
                        .HasColumnName("id_membre");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnName("note");

                    b.HasKey("IdArticle", "IdMembre");

                    b.HasIndex("IdMembre");

                    b.ToTable("membre_article");
                });

            modelBuilder.Entity("Hackfest.Models.Organisateur", b =>
                {
                    b.Property<int>("IdOrganisateur")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_organisateur")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdParticipant")
                        .HasColumnName("id_participant");

                    b.Property<string>("MotDePasse")
                        .IsRequired()
                        .HasColumnName("mot_de_passe")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<string>("RôleOrganisateur")
                        .IsRequired()
                        .HasColumnName("rôle_organisateur");

                    b.HasKey("IdOrganisateur");

                    b.HasIndex("IdParticipant")
                        .IsUnique();

                    b.ToTable("organisateur");
                });

            modelBuilder.Entity("Hackfest.Models.Paiement", b =>
                {
                    b.Property<int>("IdPaiement")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_paiement")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateRéceptionPaiement")
                        .HasColumnName("date_réception_paiement")
                        .HasColumnType("date");

                    b.Property<int>("IdParticipant")
                        .HasColumnName("id_participant");

                    b.Property<decimal?>("Montant")
                        .IsRequired()
                        .HasColumnName("montant")
                        .HasColumnType("money");

                    b.HasKey("IdPaiement");

                    b.HasIndex("IdParticipant");

                    b.ToTable("paiement");
                });

            modelBuilder.Entity("Hackfest.Models.Participant", b =>
                {
                    b.Property<int>("IdParticipant")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_participant")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Affiliation")
                        .IsRequired()
                        .HasColumnName("affiliation")
                        .HasMaxLength(1);

                    b.Property<string>("CourrielParticipant")
                        .IsRequired()
                        .HasColumnName("courriel_participant")
                        .HasMaxLength(1);

                    b.Property<DateTime>("DateInscription")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("date_inscription")
                        .HasColumnType("date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("NomParticipant")
                        .IsRequired()
                        .HasColumnName("nom_participant");

                    b.Property<string>("PrénomParticipant")
                        .IsRequired()
                        .HasColumnName("prénom_participant");

                    b.HasKey("IdParticipant");

                    b.ToTable("participant");
                });

            modelBuilder.Entity("Hackfest.Models.Session", b =>
                {
                    b.Property<int>("IdMembre")
                        .HasColumnName("id_membre");

                    b.Property<DateTime>("DateSession")
                        .HasColumnName("date_session")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Heure")
                        .HasColumnName("heure");

                    b.Property<int>("IdArticle")
                        .HasColumnName("id_article");

                    b.Property<string>("TitreSession")
                        .IsRequired()
                        .HasColumnName("titre_session");

                    b.HasKey("IdMembre");

                    b.HasAlternateKey("IdArticle");


                    b.HasAlternateKey("IdArticle", "IdMembre");

                    b.ToTable("session");
                });

            modelBuilder.Entity("Hackfest.Models.Spécialité", b =>
                {
                    b.Property<int>("IdSpécialité")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_spécialité")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescriptionSpécialité")
                        .IsRequired()
                        .HasColumnName("spécialité");

                    b.Property<int>("IdMembre")
                        .HasColumnName("id_membre");

                    b.HasKey("IdSpécialité");

                    b.HasIndex("IdMembre");

                    b.ToTable("spécialité");
                });

            modelBuilder.Entity("Hackfest.Models.VersionArticle", b =>
                {
                    b.Property<int>("IdVersionArticle")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_version_article")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateSoumission")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("date_soumission")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("IdArticle")
                        .HasColumnName("id_article");

                    b.Property<int>("NoVersion")
                        .HasColumnName("no_version");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnName("url");

                    b.HasKey("IdVersionArticle");

                    b.HasIndex("IdArticle");

                    b.ToTable("version_article");
                });

            modelBuilder.Entity("Hackfest.Models.Article", b =>
                {
                    b.HasOne("Hackfest.Models.Participant", "IdParticipantNavigation")
                        .WithMany("Article")
                        .HasForeignKey("IdParticipant")
                        .HasConstraintName("cé_article_participant");
                });

            modelBuilder.Entity("Hackfest.Models.Membre", b =>
                {
                    b.HasOne("Hackfest.Models.Participant", "IdParticipantNavigation")
                        .WithOne("Membre")
                        .HasForeignKey("Hackfest.Models.Membre", "IdParticipant")
                        .HasConstraintName("cé_membre_participant");
                });

            modelBuilder.Entity("Hackfest.Models.MembreArticle", b =>
                {
                    b.HasOne("Hackfest.Models.Article", "IdArticleNavigation")
                        .WithMany("MembreArticles")
                        .HasForeignKey("IdArticle")
                        .HasConstraintName("cé_ma_article");

                    b.HasOne("Hackfest.Models.Membre", "IdMembreNavigation")
                        .WithMany("MembreArticles")
                        .HasForeignKey("IdMembre")
                        .HasConstraintName("cé_ma_membre");
                });

            modelBuilder.Entity("Hackfest.Models.Organisateur", b =>
                {
                    b.HasOne("Hackfest.Models.Participant", "IdParticipantNavigation")
                        .WithOne("Organisateur")
                        .HasForeignKey("Hackfest.Models.Organisateur", "IdParticipant")
                        .HasConstraintName("cé_organisateur_participant");
                });

            modelBuilder.Entity("Hackfest.Models.Paiement", b =>
                {
                    b.HasOne("Hackfest.Models.Participant", "IdParticipantNavigation")
                        .WithMany("Paiement")
                        .HasForeignKey("IdParticipant")
                        .HasConstraintName("cé_paiement_participant");
                });

            modelBuilder.Entity("Hackfest.Models.Session", b =>
                {
                    b.HasOne("Hackfest.Models.Article", "IdArticleNavigation")
                        .WithMany("Sessions")
                        .HasForeignKey("IdArticle")
                        .HasConstraintName("cé_session_article");

                    b.HasOne("Hackfest.Models.Membre", "IdMembreNavigation")
                        .WithMany("Sessions")
                        .HasForeignKey("IdMembre")
                        .HasConstraintName("cé_session_membre");
                });

            modelBuilder.Entity("Hackfest.Models.Spécialité", b =>
                {
                    b.HasOne("Hackfest.Models.Membre", "IdMembreNavigation")
                        .WithMany("Spécialités")
                        .HasForeignKey("IdMembre")
                        .HasConstraintName("cé_spécialité_membre");
                });

            modelBuilder.Entity("Hackfest.Models.VersionArticle", b =>
                {
                    b.HasOne("Hackfest.Models.Article", "IdArticleNavigation")
                        .WithMany("VersionArticles")
                        .HasForeignKey("IdArticle")
                        .HasConstraintName("cé_va_article");
                });
#pragma warning restore 612, 618
        }
    }
}

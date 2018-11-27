using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Hackfest.Models;

namespace Hackfest.Models
{
    public partial class ContexteTP : DbContext
    {
        public ContexteTP()
        {
        }

        public ContexteTP(DbContextOptions<ContexteTP> options)
            : base(options)
        {
        }

        //public virtual DbSet<Article> Article { get; set; }
        //public virtual DbSet<Membre> Membre { get; set; }
        //public virtual DbSet<MembreArticle> MembreArticle { get; set; }
        //public virtual DbSet<Organisateur> Organisateur { get; set; }
        public virtual DbSet<Paiement> Paiement { get; set; }
        public virtual DbSet<Participant> Participant { get; set; }
        //public virtual DbSet<Session> Session { get; set; }
        //public virtual DbSet<Spécialité> Spécialité { get; set; }
        //public virtual DbSet<VersionArticle> VersionArticle { get; set; }
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TP_GEC_21_11;Trusted_Connection=True;");
            }
        }
        */
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MembreArticle>(entity =>
        //    {
        //        entity.HasKey(c => new { c.IdArticle, c.IdMembre });

        //        entity.HasOne(d => d.IdArticleNavigation)
        //              .WithMany(p => p.MembreArticle)
        //              .HasForeignKey(d => d.IdArticle)
        //              .OnDelete(DeleteBehavior.Restrict);

        //        entity.HasOne(d => d.IdMembreNavigation)
        //              .WithMany(p => p.MembreArticle)
        //              .HasForeignKey(d => d.IdMembre)
        //              .OnDelete(DeleteBehavior.Restrict);
        //    });

        //    modelBuilder.Entity<Session>(entity =>
        //    {
        //        entity.HasKey(c => new { c.IdArticle, c.IdMembre });

        //        entity.HasOne(d => d.IdArticleNavigation)
        //              .WithMany(p => p.Session)
        //              .HasForeignKey(d => d.IdArticle)
        //              .OnDelete(DeleteBehavior.Restrict);

        //        entity.HasOne(d => d.IdMembreNavigation)
        //              .WithMany(p => p.Session)
        //              .HasForeignKey(d => d.IdMembre)
        //              .OnDelete(DeleteBehavior.Restrict);
        //    });


            /*
            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasKey(e => e.IdArticle);

                entity.ToTable("article");

                entity.Property(e => e.IdArticle).HasColumnName("id_article");

                entity.Property(e => e.IdParticipant).HasColumnName("id_participant");

                entity.Property(e => e.TitreArticle)
                    .IsRequired()
                    .HasColumnName("titre_article")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdParticipantNavigation)
                    .WithMany(p => p.Article)
                    .HasForeignKey(d => d.IdParticipant)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cé_article_participant");
            });


            modelBuilder.Entity<Membre>(entity =>
            {
                entity.HasKey(e => e.IdMembre);

                entity.ToTable("membre");

                entity.Property(e => e.IdMembre).HasColumnName("id_membre");

                entity.Property(e => e.IdParticipant).HasColumnName("id_participant");

                entity.HasOne(d => d.IdParticipantNavigation)
                    .WithMany(p => p.Membre)
                    .HasForeignKey(d => d.IdParticipant)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cé_membre_participant");
            });


            modelBuilder.Entity<MembreArticle>(entity =>
            {
                entity.HasKey(e => new { e.IdArticle, e.IdMembre });

                entity.ToTable("membre_article");

                entity.Property(e => e.IdArticle)
                    .HasColumnName("id_article")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdMembre).HasColumnName("id_membre");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.HasOne(d => d.IdArticleNavigation)
                    .WithMany(p => p.MembreArticle)
                    .HasForeignKey(d => d.IdArticle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cé_ma_article");

                entity.HasOne(d => d.IdMembreNavigation)
                    .WithMany(p => p.MembreArticle)
                    .HasForeignKey(d => d.IdMembre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cé_ma_membre");
            });


            modelBuilder.Entity<Organisateur>(entity =>
            {
                entity.HasKey(e => e.IdOrganisateur);

                entity.ToTable("organisateur");

                entity.Property(e => e.IdOrganisateur).HasColumnName("id_organisateur");

                entity.Property(e => e.IdParticipant).HasColumnName("id_participant");

                entity.Property(e => e.MotDePasse)
                    .IsRequired()
                    .HasColumnName("mot_de_passe")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RôleOrganisateur)
                    .IsRequired()
                    .HasColumnName("rôle_organisateur");

                entity.HasOne(d => d.IdParticipantNavigation)
                    .WithMany(p => p.Organisateur)
                    .HasForeignKey(d => d.IdParticipant)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cé_organisateur_participant");
            });

            modelBuilder.Entity<Paiement>(entity =>
            {
                entity.HasKey(e => e.IdPaiement);

                entity.ToTable("paiement");

                entity.Property(e => e.IdPaiement).HasColumnName("id_paiement");

                entity.Property(e => e.DateRéceptionPaiement)
                    .HasColumnName("date_réception_paiement")
                    .HasColumnType("date");

                entity.Property(e => e.IdParticipant).HasColumnName("id_participant");

                entity.Property(e => e.Montant)
                    .HasColumnName("montant")
                    .HasColumnType("money");

                entity.HasOne(d => d.IdParticipantNavigation)
                    .WithMany(p => p.Paiement)
                    .HasForeignKey(d => d.IdParticipant)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cé_paiement_participant");
            });

            modelBuilder.Entity<Participant>(entity =>
            {
                entity.HasKey(e => e.IdParticipant);

                entity.ToTable("participant");

                entity.Property(e => e.IdParticipant).HasColumnName("id_participant");

                entity.Property(e => e.Affiliation)
                    .HasColumnName("affiliation")
                    .HasMaxLength(1);

                entity.Property(e => e.CourrielParticipant)
                    .HasColumnName("courriel_participant")
                    .HasMaxLength(1);

                entity.Property(e => e.DateInscription)
                    .HasColumnName("date_inscription")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NomParticipant)
                    .IsRequired()
                    .HasColumnName("nom_participant");

                entity.Property(e => e.PrénomParticipant)
                    .IsRequired()
                    .HasColumnName("prénom_participant");
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.HasKey(e => e.IdSession);

                entity.ToTable("session");

                entity.Property(e => e.IdSession).HasColumnName("id_session");

                entity.Property(e => e.DateSession)
                    .HasColumnName("date_session")
                    .HasColumnType("datetime");

                entity.Property(e => e.Heure)
                    .IsRequired()
                    .HasColumnName("heure");

                entity.Property(e => e.IdArticle).HasColumnName("id_article");

                entity.Property(e => e.IdMembre).HasColumnName("id_membre");

                entity.Property(e => e.TitreSession)
                    .IsRequired()
                    .HasColumnName("titre_session");

                entity.HasOne(d => d.IdArticleNavigation)
                    .WithMany(p => p.Session)
                    .HasForeignKey(d => d.IdArticle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cé_session_article");

                entity.HasOne(d => d.IdMembreNavigation)
                    .WithMany(p => p.Session)
                    .HasForeignKey(d => d.IdMembre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cé_session_membre");
            });

            modelBuilder.Entity<Spécialité>(entity =>
            {
                entity.HasKey(e => e.IdSpécialité);

                entity.ToTable("spécialité");

                entity.Property(e => e.IdSpécialité).HasColumnName("id_spécialité");

                entity.Property(e => e.IdMembre).HasColumnName("id_membre");

                entity.Property(e => e.DescriptionSpécialité)
                    .IsRequired()
                    .HasColumnName("spécialité");

                entity.HasOne(d => d.IdMembreNavigation)
                    .WithMany(p => p.Spécialité)
                    .HasForeignKey(d => d.IdMembre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cé_spécialité_membre");
            });

            modelBuilder.Entity<VersionArticle>(entity =>
            {
                entity.HasKey(e => e.IdVersionArticle);

                entity.ToTable("version_article");

                entity.Property(e => e.IdVersionArticle).HasColumnName("id_version_article");

                entity.Property(e => e.DateSoumission)
                    .HasColumnName("date_soumission")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdArticle).HasColumnName("id_article");

                entity.Property(e => e.NoVersion).HasColumnName("no_version");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url");

                entity.HasOne(d => d.IdArticleNavigation)
                    .WithMany(p => p.VersionArticle)
                    .HasForeignKey(d => d.IdArticle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cé_va_article");
            });
            */
        //}
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication5.Models
{
    public partial class BDTRContext : DbContext
    {
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Contrat> Contrat { get; set; }
        public virtual DbSet<Employe> Employe { get; set; }
        public virtual DbSet<FaitLeVoyage> FaitLeVoyage { get; set; }
        public virtual DbSet<Hotel> Hotel { get; set; }
        public virtual DbSet<Voyage> Voyage { get; set; }
        public BDTRContext(DbContextOptions<BDTRContext> options)
    : base(options)
{ }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BDTR;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.CliNo);

                entity.ToTable("client");

                entity.Property(e => e.CliNo)
                    .HasColumnName("cliNo")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.CliNom)
                    .HasColumnName("cliNom")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CliPrenom)
                    .HasColumnName("cliPrenom")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CliRue)
                    .HasColumnName("cliRue")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CliTelephone)
                    .HasColumnName("cliTelephone")
                    .HasColumnType("char(12)");

                entity.Property(e => e.CliVille)
                    .HasColumnName("cliVille")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Totoville')");
            });

            modelBuilder.Entity<Contrat>(entity =>
            {
                entity.HasKey(e => e.ConNo);

                entity.ToTable("contrat");

                entity.Property(e => e.ConNo)
                    .HasColumnName("conNo")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.CliNo)
                    .HasColumnName("cliNo")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.ConAcompte)
                    .HasColumnName("conAcompte")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.ConDate)
                    .HasColumnName("conDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ConMontant)
                    .HasColumnName("conMontant")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.ConPaye)
                    .HasColumnType("numeric(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ConTypeOcc)
                    .HasColumnName("conTypeOcc")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.EmpNo)
                    .HasColumnName("empNo")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.VoyNo)
                    .HasColumnName("voyNo")
                    .HasColumnType("numeric(4, 0)");

                entity.HasOne(d => d.CliNoNavigation)
                    .WithMany(p => p.Contrat)
                    .HasForeignKey(d => d.CliNo)
                    .HasConstraintName("fk_clientPayeur");

                entity.HasOne(d => d.EmpNoNavigation)
                    .WithMany(p => p.Contrat)
                    .HasForeignKey(d => d.EmpNo)
                    .HasConstraintName("fk_vendeur");

                entity.HasOne(d => d.VoyNoNavigation)
                    .WithMany(p => p.Contrat)
                    .HasForeignKey(d => d.VoyNo)
                    .HasConstraintName("fk_choixVoyage");
            });

            modelBuilder.Entity<Employe>(entity =>
            {
                entity.HasKey(e => e.EmpNo);

                entity.ToTable("employe");

                entity.Property(e => e.EmpNo)
                    .HasColumnName("empNo")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.EmpBureau)
                    .HasColumnName("empBureau")
                    .HasColumnType("char(3)");

                entity.Property(e => e.EmpComm)
                    .HasColumnName("empComm")
                    .HasColumnType("numeric(3, 3)");

                entity.Property(e => e.EmpEmploi)
                    .HasColumnName("empEmploi")
                    .HasColumnType("char(2)");

                entity.Property(e => e.EmpNom)
                    .HasColumnName("empNom")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EmpPrenom)
                    .HasColumnName("empPrenom")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpSal)
                    .HasColumnName("empSal")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.EmpSup)
                    .HasColumnName("empSup")
                    .HasColumnType("numeric(4, 0)");
            });

            modelBuilder.Entity<FaitLeVoyage>(entity =>
            {
                entity.HasKey(e => new { e.ConNo, e.CliNo });

                entity.ToTable("faitLeVoyage");

                entity.Property(e => e.ConNo)
                    .HasColumnName("conNo")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.CliNo)
                    .HasColumnName("cliNo")
                    .HasColumnType("numeric(6, 0)");

                entity.HasOne(d => d.CliNoNavigation)
                    .WithMany(p => p.FaitLeVoyage)
                    .HasForeignKey(d => d.CliNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_faitVoyageClient");

                entity.HasOne(d => d.ConNoNavigation)
                    .WithMany(p => p.FaitLeVoyage)
                    .HasForeignKey(d => d.ConNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_faitVoyageContrat");
            });

            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.HasKey(e => e.HotNo);

                entity.ToTable("hotel");

                entity.Property(e => e.HotNo)
                    .HasColumnName("hotNo")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.HotCote)
                    .HasColumnName("hotCote")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.HotNbChambreTot)
                    .HasColumnName("hotNbChambreTot")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.HotNom)
                    .HasColumnName("hotNom")
                    .HasColumnType("char(25)");

                entity.Property(e => e.HotPiscine)
                    .HasColumnName("hotPiscine")
                    .HasColumnType("char(1)");
            });

            modelBuilder.Entity<Voyage>(entity =>
            {
                entity.HasKey(e => e.VoyNo);

                entity.ToTable("voyage");

                entity.Property(e => e.VoyNo)
                    .HasColumnName("voyNo")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.EmpNo)
                    .HasColumnName("empNo")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Hotno)
                    .HasColumnName("hotno")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.NbChambreRes).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.TarifDouble)
                    .HasColumnName("tarifDouble")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.TarifQuadruple)
                    .HasColumnName("tarifQuadruple")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.TarifSimple)
                    .HasColumnName("tarifSimple")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.TarifTriple)
                    .HasColumnName("tarifTriple")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.VoyActivite)
                    .HasColumnName("voyActivite")
                    .HasColumnType("char(76)");

                entity.Property(e => e.VoyDateArrive)
                    .HasColumnName("voyDateArrive")
                    .HasColumnType("datetime");

                entity.Property(e => e.VoyDateDepart)
                    .HasColumnName("voyDateDepart")
                    .HasColumnType("datetime");

                entity.Property(e => e.VoyDestination)
                    .HasColumnName("voyDestination")
                    .HasColumnType("char(20)");

                entity.Property(e => e.VoyNbPlace)
                    .HasColumnName("voyNbPlace")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.VoyRepas)
                    .HasColumnName("voyRepas")
                    .HasColumnType("numeric(1, 0)");

                entity.HasOne(d => d.EmpNoNavigation)
                    .WithMany(p => p.Voyage)
                    .HasForeignKey(d => d.EmpNo)
                    .HasConstraintName("fk_animateur");

                entity.HasOne(d => d.HotnoNavigation)
                    .WithMany(p => p.Voyage)
                    .HasForeignKey(d => d.Hotno)
                    .HasConstraintName("fk_inclus");
            });
        }
    }
}

using DNACityGuide.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DNACityGuide.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Tura> Tura { get; set; }
        public DbSet<RezervacijaTura> RezervacijaTura { get; set; }
        public DbSet<Komentar> Komentar { get; set; }
        public DbSet<QASesija> QASesija { get; set; }
        public DbSet<ChatSesija> ChatSesija { get; set; }
        public DbSet<Ulaznica> Ulaznica { get; set; }
        public DbSet<Suvenir> Suvenir { get; set; }
        public DbSet<KatalogSuvenira> KatalogSuvenira { get; set; }
        public DbSet<Mapa> Mapa { get; set; }
        public DbSet<Atrakcija> Atrakcija { get; set; }
        public DbSet<CityPass> CityPass { get; set; }
        public DbSet<ChatSesijaKorisnici> ChatSesijaKorisnici { get; set; }
        public DbSet<ChatSesijaPoruke> ChatSesijaPoruke { get; set; }
        public DbSet<CityPassAtrakcije> CityPassAtrakcije { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<MapaAtrakcije> MapaAtrakcije { get; set; }
        public DbSet<QAKomentari> QAKomentari { get; set; }
        public DbSet<QAKorisnici> QAKorisnici { get; set; }
        public DbSet<QAOcjene> QAOcjene { get; set; }
        public DbSet<QARecenzije> QARecenzije { get; set; }
        public DbSet<SuveniriKatalog> SuveniriKatalog { get; set; }
        public DbSet<TuraTuristi> TuraTuristi { get; set; }
        public DbSet<TureZaRezervaciju> TureZaRezervaciju { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tura>().ToTable("Tura");
            modelBuilder.Entity<RezervacijaTura>().ToTable("RezervacijaTura");
            modelBuilder.Entity<Komentar>().ToTable("Komentar");
            modelBuilder.Entity<QASesija>().ToTable("QASesija");
            modelBuilder.Entity<ChatSesija>().ToTable("ChatSesija");
            modelBuilder.Entity<Ulaznica>().ToTable("Ulaznica");
            modelBuilder.Entity<Suvenir>().ToTable("Suvenir");
            modelBuilder.Entity<KatalogSuvenira>().ToTable("KatalogSuvenira");
            modelBuilder.Entity<Mapa>().ToTable("Mapa");
            modelBuilder.Entity<Atrakcija>().ToTable("Atrakcija");
            modelBuilder.Entity<CityPass>().ToTable("CityPass");
            modelBuilder.Entity<ChatSesijaKorisnici>().ToTable("ChatSesijaKorisnici");
            modelBuilder.Entity<ChatSesijaPoruke>().ToTable("ChatSesijaPoruke");
            modelBuilder.Entity<CityPassAtrakcije>().ToTable("CityPassAtrakcije");
            modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            modelBuilder.Entity<MapaAtrakcije>().ToTable("MapaAtrakcije");
            modelBuilder.Entity<QAKomentari>().ToTable("QAKomentari");
            modelBuilder.Entity<QAKorisnici>().ToTable("QAKorisnici");
            modelBuilder.Entity<QAOcjene>().ToTable("QAOcjene");
            modelBuilder.Entity<QARecenzije>().ToTable("QARecenzije");
            modelBuilder.Entity<SuveniriKatalog>().ToTable("SuveniriKatalog");
            modelBuilder.Entity<TuraTuristi>().ToTable("TuraTuristi");
            modelBuilder.Entity<TureZaRezervaciju>().ToTable("TureZaRezervaciju");
            base.OnModelCreating(modelBuilder);
        }
    }
}

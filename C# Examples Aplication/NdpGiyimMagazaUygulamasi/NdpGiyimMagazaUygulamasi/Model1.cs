using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NdpGiyimMagazaUygulamasi
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<BayanCategories> BayanCategories { get; set; }
        public virtual DbSet<BCocuks> BCocuks { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<ECocuks> ECocuks { get; set; }
        public virtual DbSet<ErkekCategories> ErkekCategories { get; set; }
        public virtual DbSet<Giris> Giris { get; set; }
        public virtual DbSet<Uruns> Uruns { get; set; }
        public virtual DbSet<Musteris> Musteris { get; set; }
        public virtual DbSet<SubCategories> SubCategories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BayanCategories>()
                .Property(e => e.Isim)
                .IsUnicode(false);

            modelBuilder.Entity<BCocuks>()
                .Property(e => e.Isim)
                .IsUnicode(false);

            modelBuilder.Entity<Categories>()
                .Property(e => e.Isim)
                .IsUnicode(false);

            modelBuilder.Entity<Categories>()
                .HasMany(e => e.BayanCategories)
                .WithRequired(e => e.Categories)
                .HasForeignKey(e => e.CategoryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Categories>()
                .HasMany(e => e.BCocuks)
                .WithRequired(e => e.Categories)
                .HasForeignKey(e => e.CategoryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Categories>()
                .HasMany(e => e.ECocuks)
                .WithRequired(e => e.Categories)
                .HasForeignKey(e => e.CategoryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Categories>()
                .HasMany(e => e.ErkekCategories)
                .WithRequired(e => e.Categories)
                .HasForeignKey(e => e.CategoryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Categories>()
                .HasMany(e => e.Uruns)
                .WithRequired(e => e.Categories)
                .HasForeignKey(e => e.CategoryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ECocuks>()
                .Property(e => e.Isim)
                .IsUnicode(false);

            modelBuilder.Entity<ErkekCategories>()
                .Property(e => e.Isim)
                .IsUnicode(false);

            modelBuilder.Entity<Giris>()
                .Property(e => e.SessionId)
                .IsUnicode(false);

            modelBuilder.Entity<Giris>()
                .Property(e => e.KullaniciIsmi)
                .IsUnicode(false);

            modelBuilder.Entity<Giris>()
                .Property(e => e.Sifre)
                .IsUnicode(false);

            modelBuilder.Entity<Giris>()
                .Property(e => e.GirisTarih)
                .IsUnicode(false);

            modelBuilder.Entity<Uruns>()
                .Property(e => e.Marka)
                .IsUnicode(false);

            modelBuilder.Entity<Uruns>()
                .Property(e => e.Fiyat)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Uruns>()
                .Property(e => e.Renk)
                .IsUnicode(false);

            modelBuilder.Entity<Uruns>()
                .Property(e => e.Beden)
                .IsUnicode(false);

            modelBuilder.Entity<Uruns>()
                .Property(e => e.ImagePath)
                .IsUnicode(false);

            modelBuilder.Entity<Musteris>()
                .Property(e => e.Isim)
                .IsUnicode(false);

            modelBuilder.Entity<Musteris>()
                .Property(e => e.KullaniciIsmi)
                .IsUnicode(false);

            modelBuilder.Entity<Musteris>()
                .Property(e => e.Sifre)
                .IsUnicode(false);

            modelBuilder.Entity<SubCategories>()
                .Property(e => e.Isim)
                .IsUnicode(false);
        }
    }
}

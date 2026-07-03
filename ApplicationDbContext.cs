using Microsoft.EntityFrameworkCore;
using KutuphaneWeb.Models;

namespace KutuphaneWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Kullanici> Kullanicilar { get; set; } = null!;
        public DbSet<Yazar> Yazarlar { get; set; } = null!;
        public DbSet<YayinEvi> YayinEvleri { get; set; } = null!;
        public DbSet<Kitap> Kitaplar { get; set; } = null!;
        public DbSet<Alisveris> Alisverisler { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kullanici>(e =>
            {
                e.ToTable("Kullanici");
                e.HasKey(x => x.ID);
            });

            modelBuilder.Entity<Yazar>(e =>
            {
                e.ToTable("Yazar");
                e.HasKey(x => x.ID);
            });

            modelBuilder.Entity<YayinEvi>(e =>
            {
                e.ToTable("YayinEvi");
                e.HasKey(x => x.ID);
            });

            modelBuilder.Entity<Kitap>(e =>
            {
                e.ToTable("Kitap");
                e.HasKey(x => x.ID);
                e.HasOne(x => x.YayinEvi)
                    .WithMany(y => y.Kitaplar)
                    .HasForeignKey(x => x.YayinEviID)
                    .OnDelete(DeleteBehavior.SetNull);
                e.HasOne(x => x.Yazar)
                    .WithMany(y => y.Kitaplar)
                    .HasForeignKey(x => x.YazarID)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            modelBuilder.Entity<Alisveris>(e =>
            {
                e.ToTable("Alisveris");
                e.HasKey(x => x.ID);
                e.HasOne(x => x.Kitap)
                    .WithMany(k => k.Alisverisler)
                    .HasForeignKey(x => x.KitapID)
                    .OnDelete(DeleteBehavior.SetNull);
                e.HasOne(x => x.Kullanici)
                    .WithMany(k => k.Alisverisler)
                    .HasForeignKey(x => x.KullaniciID)
                    .OnDelete(DeleteBehavior.SetNull);
            });
        }
    }
}

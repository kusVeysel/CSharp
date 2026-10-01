using Microsoft.EntityFrameworkCore;
using WebApplicationAPI.Models;

namespace WebApplicationAPI
{
    public class AppDbContext : DbContext // DbContext, veritabanı ile bir oturumu temsil eden; varlıklarınızın (entity) örneklerini sorgulamak ve kaydetmek için kullanılabilen bir sınıftır.
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; } // DbSet, veritabanındaki bir tabloyu temsil eder ve bu tabloya karşılık gelen varlıkların (entity) koleksiyonunu içerir.Products: DB'de oluşacak tablo ismi, Product: entity ismi.DbSet: Tablo oluşturmamızı sağlar.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.ProductName).HasMaxLength(100).IsRequired();

            base.OnModelCreating(modelBuilder);
        }


    }
}

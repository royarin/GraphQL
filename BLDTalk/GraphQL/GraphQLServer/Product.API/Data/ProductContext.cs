using Microsoft.EntityFrameworkCore;

namespace Product.API.Data
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options):base(options)
        {
        }

        public DbSet<Product.API.Models.Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product.API.Models.Product>()
                .HasIndex(x => x.SKU)
                .IsUnique();
        }
    }
}

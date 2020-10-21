using connect_back.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace connect_back.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products{get;set;}
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Product>().ToTable("Products");
            builder.Entity<Product>().HasKey(p => p.ProductId);
            builder.Entity<Product>().Property(p => p.ProductId).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Product>().HasData
            (
                new Product {
                    ProductId=1, 
                    Code="6901443165889",
                    Name= "Coca-cola",
                    Price = 2.5F,
                    Description="bebida gasificada con mucha azucar"
                    }
            );

        }
    }
}
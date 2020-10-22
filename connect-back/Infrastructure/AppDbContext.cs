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
                    },
                new Product {
                    ProductId=2, 
                    Code="6901443165890",
                    Name= "inkacola",
                    Price = 2.2F,
                    Description="bebida gasificada con mucha azucar"
                    },
                new Product {
                    ProductId=3, 
                    Code="6901443165891",
                    Name= "Pepsi",
                    Price = 2.0F,
                    Description="bebida gasificada con mucha azucar"
                    },
                new Product {
                    ProductId=4, 
                    Code="6901443165892",
                    Name= "Sprite",
                    Price = 2.5F,
                    Description="bebida gasificada con mucha azucar"
                    },
                new Product {
                    ProductId=5, 
                    Code="6901443165893",
                    Name= "fanta",
                    Price = 2.5F,
                    Description="bebida gasificada con mucha azucar"
                    }
            );

        }
    }
}
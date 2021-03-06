﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using connect_back.Infrastructure;

namespace connect_back.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("connect_back.Domain.Model.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Code = "6901443165889",
                            Description = "bebida gasificada con mucha azucar",
                            Name = "Coca-cola",
                            Price = 2.5f
                        },
                        new
                        {
                            ProductId = 2,
                            Code = "6901443165890",
                            Description = "bebida gasificada con mucha azucar",
                            Name = "inkacola",
                            Price = 2.2f
                        },
                        new
                        {
                            ProductId = 3,
                            Code = "6901443165891",
                            Description = "bebida gasificada con mucha azucar",
                            Name = "Pepsi",
                            Price = 2.1f
                        },
                        new
                        {
                            ProductId = 4,
                            Code = "6901443165892",
                            Description = "bebida gasificada con mucha azucar",
                            Name = "Sprite",
                            Price = 2.5f
                        },
                        new
                        {
                            ProductId = 5,
                            Code = "6901443165893",
                            Description = "bebida gasificada con mucha azucar",
                            Name = "fanta",
                            Price = 2.5f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

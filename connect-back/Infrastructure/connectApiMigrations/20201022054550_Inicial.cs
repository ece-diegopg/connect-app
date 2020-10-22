using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace connect_back.Infrastructure.connectApiMigrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Code", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "6901443165889", "bebida gasificada con mucha azucar", "Coca-cola", 2.5f },
                    { 2, "6901443165890", "bebida gasificada con mucha azucar", "inkacola", 2.2f },
                    { 3, "6901443165891", "bebida gasificada con mucha azucar", "Pepsi", 2f },
                    { 4, "6901443165892", "bebida gasificada con mucha azucar", "Sprite", 2.5f },
                    { 5, "6901443165893", "bebida gasificada con mucha azucar", "fanta", 2.5f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

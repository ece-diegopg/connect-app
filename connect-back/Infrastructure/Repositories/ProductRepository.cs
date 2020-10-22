using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using connect_back.Domain.Model;
using connect_back.Domain.Repositories;
using connect_back.Infrastructure;

namespace connect_back.Infrastructure.Repositories
{
	public class ProductRepository : BaseRepository, IProductRepository
	{
		public ProductRepository(AppDbContext context) : base(context) { }
        
        public async Task<IEnumerable<Product>> GetProductsAsync(){
            return await _context.Products.ToArrayAsync();
            //por ahora devuelve todos, se cambiara para que admita los parametros
            //de las queries
        }
		public async Task<Product> GetProductByIdAsync(int productId)
		{
			return await _context.Products
								 .FirstOrDefaultAsync(p => p.ProductId == productId); // Since Include changes the method's return type, we can't use FindAsync
		}

		public async Task CreateProductAsync(Product product)
		{
			await _context.Products.AddAsync(product);
		}

		public void UpdateProduct(Product product)
		{
			_context.Products.Update(product);
		}

		public void DeleteProduct(Product product)
		{
			_context.Products.Remove(product);
		}
	}
}
using System.Threading.Tasks;
using connect_back.Domain.Model;
using System.Collections.Generic;
namespace connect_back.Domain.Repositories
{
    public interface IProductRepository//repositorio para los productos
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(int userId);
        Task CreateProductAsync(Product product);
        void DeleteProduct(Product product);
        void UpdateProduct(Product product);
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using connect_back.Domain.Model;
using connect_back.Domain.Services.Communication;
namespace connect_back.Domain.Services{
    public interface IProductService{
        Task<IEnumerable<Product>> GetProductsAsync();//Lista de productos
        Task<ProductResponse> GetProductByIdAsync(int productId);//Producto por su id
        Task<ProductResponse> CreateAsync(Product product);//Crear un Producto
        Task<ProductResponse> UpdateAsync(int productId, Product product);//Actualizar un producto
        Task<ProductResponse> DeleteAsync(int productId);//Eliminar un producto
    }
}
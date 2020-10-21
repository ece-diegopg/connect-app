using System.Collections.Generic;
using System.Threading.Tasks;
using connect_back.Domain.Model;
using connect_back.Domain.Services.Communication;
namespace connect_back.Domain.Services{
    public interface IProductService{
        Task<IEnumerable<Product>> GetProductsAsync();//list de productos
        Task<ProductResponse> CreateAsync();//Crear un Producto
        Task<ProductResponse> UpdateAsync(int productId, Product product);//Actualizar un producto
        Task<ProductResponse> DeleteAsync(int productId);//Eliminar un producto
    }
}
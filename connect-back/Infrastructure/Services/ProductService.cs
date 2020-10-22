using System.Threading.Tasks;
using System.Collections.Generic;
using connect_back.Domain.Services;
using connect_back.Domain.Repositories;
using connect_back.Domain.Services.Communication;
using connect_back.Domain.Model;
using System;

namespace connect_back.Infrastructure.Services{
    public class ProductService:IProductService{
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork){
            this._productRepository = productRepository;
            this._unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Product>> GetProductsAsync(){
            return await _productRepository.GetProductsAsync();
            //modificar 
        }
        public async Task<ProductResponse> GetProductByIdAsync(int productId){
            var result = await _productRepository.GetProductByIdAsync(productId);
            if(result == null){
                return new ProductResponse("no encontrado");
            }
            Product product = new Product{
                ProductId = result.ProductId,
                Code = result.Code,
                Description = result.Description,
                Name = result.Name,
                Price = result.Price
            };
            return new ProductResponse(product);
        }
        public async Task<ProductResponse> CreateAsync(Product product){
            try{
                await _productRepository.CreateProductAsync(product);
                await _unitOfWork.CompleteAsync();
                return new ProductResponse(product);
            }
            catch(Exception e){
                return new ProductResponse($"Ocurrio un error {e.Message}");
            }
        }
        public async Task<ProductResponse> UpdateAsync(int productId, Product product){
            var thisProduct = await _productRepository.GetProductByIdAsync(productId);
            if(thisProduct == null){
                return new ProductResponse("producto no encontrado");
            }
            thisProduct.Code = product.Code;
            thisProduct.Name = product.Name;
            thisProduct.Description = product.Description;
            thisProduct.Price = product.Price;
            try{
                _productRepository.UpdateProduct(thisProduct);
                await _unitOfWork.CompleteAsync();
                return new ProductResponse(thisProduct);
            }
            catch(Exception e){
                return new ProductResponse($"Ocurrio un error al actualizar el producto{e.Message}");
            }
        }
        public async Task<ProductResponse> DeleteAsync(int productId){
            var thisProduct = await _productRepository.GetProductByIdAsync(productId);
            if(thisProduct == null){
                return new ProductResponse("producto no encontrado");
            }
            try{
                _productRepository.DeleteProduct(thisProduct);
                await _unitOfWork.CompleteAsync();
                return new ProductResponse(thisProduct);
            }
            catch(Exception e){
                return new ProductResponse($"Ocurrio un error al eliminar el producto{e.Message}");
            }
        }
    }
}
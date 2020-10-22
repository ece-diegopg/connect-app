using connect_back.Dto;
using connect_back.Domain.Model;
namespace connect_back.Mapper{
    public static class ProductMapper{
        //mapedor de dto a model object y viceversa
        public static ProductDTO ModelToDto(Product product){
            return new ProductDTO{
                ProductId = product.ProductId,
                Code = product.Code,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price
            };
        }
        public static Product DtoToModel(ProductDTO dto){
            return new Product{
                ProductId = dto.ProductId,
                Code = dto.Code,
                Name = dto.Name,
                Description = dto.Description,
                Price = dto.Price
            };
        }
    }
}
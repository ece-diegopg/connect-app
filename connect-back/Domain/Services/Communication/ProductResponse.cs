using connect_back.Domain.Model;
namespace connect_back.Domain.Services.Communication{
    public class ProductResponse : BaseResponse<Product>
    {
        //exito.
        public ProductResponse(Product product) : base(product) { }

        //error.
        public ProductResponse(string message) : base(message) { }
    }
}
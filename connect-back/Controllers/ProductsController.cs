using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using connect_back.Domain.Services;
using connect_back.Dto;
using connect_back.Mapper;

namespace connect_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("{productId}")]
        [ProducesResponseType(typeof(ProductDTO), 200)]
        public async Task<IActionResult> GetProductByIdAsync(int productId)
        {
            var result = await _productService.GetProductByIdAsync(productId);
            if(!result.Success){
                return BadRequest(result.Message);
            }
            return Ok(ProductMapper.ModelToDto(result.Entity));
        }
    }
}

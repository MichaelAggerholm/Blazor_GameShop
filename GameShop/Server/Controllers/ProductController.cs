using GameShop.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // Her instantieres interface'et IProductService.cs, som definerer metoderne fra ProductService.cs
        private readonly IProductService _productService;

        // Her injecteres interface'et IProductService.cs, som definerer metoderne fra ProductService.cs
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
            // Her kaldes metoden fra ProductService.cs, som er defineret i interface'et IProductService.cs
            var result = await _productService.GetProductsAsync();

            // returnerer resultatet fra ProductService.cs
            return Ok(result);
        }

        [HttpGet]
        [Route("{productId}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProduct([FromRoute]Guid productId)
        {
            var result = await _productService.GetProductAsync(productId);

            return Ok(result);
        }

        [HttpGet]
        [Route("category/{categoryUrl}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductsByCategory([FromRoute]string categoryUrl)
        {
            var result = await _productService.GetProductsByCategoryAsync(categoryUrl);

            return Ok(result);
        }

        [HttpGet]
        [Route("search/{searchText}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> SearchProducts([FromRoute] string searchText)
        {
            var result = await _productService.SearchProducts(searchText);

            return Ok(result);
        }
    } 
}

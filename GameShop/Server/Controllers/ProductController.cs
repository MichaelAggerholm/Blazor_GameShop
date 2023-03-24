using GameShop.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProduct()
        {
            // Henter en liste af produkter fra databasen asynkront og gemmer dem i variablen 'products'
            var products = await _context.Products.ToListAsync();

            // Opretter et nyt ServiceResponse-objekt med typen 'List<Product>' og gemmer 'products' i dets Data-felt
            var response = new ServiceResponse<List<Product>>
            {
                Data = products
            };

            // Returnerer en HTTP OK-statuskode sammen med det oprettede ServiceResponse-objekt
            return Ok(response);
        }
    } 
}

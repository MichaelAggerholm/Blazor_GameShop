using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace GameShop.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        // Her instantieres DataContext.cs, som definerer metoderne fra GameShopDb.db
        private readonly DataContext _context;

        // Her injecteres DataContext.cs, som definerer metoderne fra GameShopDb.db
        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(Guid productId)
        {
            var response = new ServiceResponse<Product>();
            // Lambda expression, som henter et produkt fra GameShopDb.db, som har samme Id som productId
            // Her hentes også alle varianterne af produktet og alle produkttyperne af varianten
            // Hvis produktet ikke findes, returneres null som default.
            var product = await _context.Products
                .Include(p => p.Variants)
                .ThenInclude(v => v.ProductType)
                .FirstOrDefaultAsync(p => p.Id == productId);
            if (product == null)
            {
                response.Success = false;
                response.Message = "Dette produkt blev ikke fundet..";
            }
            else
            {
                response.Data = product;
            }

            return response;
        }

        // Metode til at hente alle produkter fra GameShopDb.db og returnere dem som en liste af objekter af typen Product.cs
        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            // Her instantieres et objekt af typen ServiceResponse.cs, som definerer metoderne til at returnere data
            var response = new ServiceResponse<List<Product>>()
            {
                // Henter alle produkter, og inkluderer alle varianterne af produktet
                Data = await _context.Products.Include(p => p.Variants).ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl)
        {
            var response = new ServiceResponse<List<Product>>
            {
                // Henter alle produkter, hvor kategorien er lig med categoryUrl, og inkluderer alle varianterne af produktet
                // Til sidst returneres listen af produkter som et objekt af typen ServiceResponse.cs
                Data = await _context.Products
                    .Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower()))
                    .Include(p => p.Variants)
                    .ToListAsync()
            };

            return response;
        }

        // Find produkter hvor searchText indgår i produkt titlen eller hvor searchText indgår i produkt beskrivelsen. 
        private async Task<List<Product>> FindProductsBySearchTextAsync(string searchText)
        {
            return await _context.Products
                                .Where(p => p.Title.ToLower().Contains(searchText.ToLower())
                                ||
                                p.Description.ToLower().Contains(searchText.ToLower()))
                                // Inkluder produktets varianter
                                .Include(p => p.Variants)
                                .ToListAsync();
        }

        public async Task<ServiceResponse<List<Product>>> SearchProductsAsync(string searchText)
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await FindProductsBySearchTextAsync(searchText)
            };

            return response;
        }

        public async Task<ServiceResponse<List<string>>> GetProductSearchSuggestionsAsync(string searchText)
        {
            var products = await FindProductsBySearchTextAsync(searchText);

            List<string> result = new List<string>();

            foreach(var product in products)
            {
                // Hvis produkt titlen indeholder searchText, tilføjes titlen til result.
                if(product.Title.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(product.Title);
                }

                // lidt tricky, men gør det muligt at søge på ord i produkt beskrivelsen.
                if(product.Description != null)
                {
                    // punctioation bruges til at skaffe alle ord i beskrivelsen
                    var punctuation = product.Description.Where(char.IsPunctuation)
                        .Distinct().ToArray();
                    var words = product.Description.Split()
                        .Select(s => s.Trim(punctuation));

                    // Hvis searchText indeholder nogle ord som er med i en produkt beskrivelse, tilføjes de ord til result. 
                    foreach(var word in words) 
                    {
                        if(word.Contains(searchText, StringComparison.OrdinalIgnoreCase)
                            && !result.Contains(word))
                        {
                            result.Add(word);
                        }
                    }
                }


            }
            
            return new ServiceResponse<List<string>> { Data = result };
        }

        public async Task<ServiceResponse<List<Product>>> GetFeaturedProducts()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products
                    .Where(p => p.Featured)
                    .Include(p => p.Variants)
                    .ToListAsync()
            };

            return response;
        }
    }
}

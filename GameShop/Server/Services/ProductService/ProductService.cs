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
            var product = await _context.Products.FindAsync(productId);
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
                Data = await _context.Products.ToListAsync()
            };

            return response;
        }

    }
}

using GameShop.Shared.DTO;

namespace GameShop.Server.Services.CartService;

public class CartService : ICartService
{
    private readonly DataContext _context;

    public CartService(DataContext context)
    {
        _context = context;
    }
    
    // Hent produkter fra databasen baseret på CartItem
    public async Task<ServiceResponse<List<CartProductResponse>>> GetCartProductsAsync(List<CartItem> cartItems)
    {
        // Ny liste med CartProductResponse
        var result = new ServiceResponse<List<CartProductResponse>>
        {
            // Data er en liste med CartProductResponse
            Data = new List<CartProductResponse>()
        };
        
        // Gennemgå alle CartItem i cartItems
        foreach (var cartItem in cartItems)
        {
            // Find produktet i databasen
            var product = await _context.Products
                .Where(p => p.Id == cartItem.ProductId)
                .FirstOrDefaultAsync();

            // Hvis produktet ikke findes, så fortsæt til næste CartItem
            if (product == null)
            {
                continue;
            }

            // Find produktvarianten i databasen
            var productVariant = await _context.ProductVariants
                .Where(v => v.ProductId == cartItem.ProductId
                            && v.ProductTypeId == cartItem.ProductTypeId)
                .Include(v => v.ProductType)
                .FirstOrDefaultAsync();

            // Hvis produktvarianten ikke findes, så fortsæt til næste CartItem
            if (productVariant == null)
            {
                continue;
            }

            // Opret et nyt CartProductResponse objekt
            var cartProduct = new CartProductResponse
            {
                ProductId = product.Id,
                Title = product.Title,
                ImageUrl = product.ImageUrl,
                Price = productVariant.Price,
                ProductType = productVariant.ProductType.Name,
                ProductTypeId = productVariant.ProductTypeId,
                Quantity = cartItem.Quantity
            };
            
            // Tilføj CartProductResponse til result.Data
            result.Data.Add(cartProduct);
        }

        // Returner result
        return result;
    }
}
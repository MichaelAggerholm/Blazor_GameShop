using GameShop.Shared.DTO;

namespace GameShop.Server.Services.CartService;

public interface ICartService
{
    Task<ServiceResponse<List<CartProductResponse>>> GetCartProductsAsync(List<CartItem> cartItems);
}
using GameShop.Shared.DTO;

namespace GameShop.Client.Services.CartService;

public interface ICartService
{
    event Action OnChange;
    Task AddToCart(CartItem cartItem);
    Task<List<CartItem>> GetCartItems();
    Task<List<CartProductResponse>> GetCartProducts();
    Task RemoveProductFromCart(Guid productId, Guid productTypeId);
    Task UpdateQuantity(CartProductResponse cartProduct);
}
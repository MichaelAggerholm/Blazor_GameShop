using GameShop.Shared;

namespace GameShop.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }

        Task GetProductsAsync();
        Task<ServiceResponse<Product>> GetProductAsync(Guid productId);
    }
}

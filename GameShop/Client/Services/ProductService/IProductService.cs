using GameShop.Shared;

namespace GameShop.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }

        Task GetProductsAsync();
    }
}

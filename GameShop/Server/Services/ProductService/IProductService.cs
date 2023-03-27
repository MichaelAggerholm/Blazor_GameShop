namespace GameShop.Server.Services.ProductService
{
    public interface IProductService
    {
        // Her i interface'et defineres metoderne fra ProductService.cs, som skal kunne kaldes fra andre klasser (f.eks. ProductController.cs)
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
    }
}

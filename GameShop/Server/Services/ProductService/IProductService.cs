﻿using GameShop.Shared.DTO;

namespace GameShop.Server.Services.ProductService
{
    public interface IProductService
    {
        // Her i interface'et defineres metoderne fra ProductService.cs, som skal kunne kaldes fra andre klasser (f.eks. ProductController.cs)
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        Task<ServiceResponse<Product>> GetProductAsync(Guid productId);
        Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl);
        Task<ServiceResponse<ProductSearchResult>> SearchProductsAsync(string searchText, int page);
        Task<ServiceResponse<List<string>>> GetProductSearchSuggestionsAsync(string searchText);
        Task<ServiceResponse<List<Product>>> GetFeaturedProducts();
    }
}

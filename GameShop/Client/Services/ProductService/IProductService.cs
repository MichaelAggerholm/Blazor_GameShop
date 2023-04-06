using GameShop.Shared;

namespace GameShop.Client.Services.ProductService
{
    public interface IProductService
    {
        // Event der bliver kaldt når der er ændret i listen af produkter
        event Action ProductsChanged;

        // Liste af produkter
        List<Product> Products { get; set; }

        // Ineholder besked om hvis der er sket en fejl i søgning, som hvis der eksempelvis ingen produkter er fundet ved søgning.
        string Message { get; set; }

        // Hvis der angives en categoryurl bliver den brugt, hvis ikke bliver den ikke brugt
        // Hvis den ikke bliver brugt, bliver alle produkter hentet
        Task GetProductsAsync(string? categoryUrl = null);

        // Henter et produkt ud fra id
        Task<ServiceResponse<Product>> GetProductAsync(Guid productId);

        Task SearchProducts(string searchText);
        Task<List<string>> GetProductSearchSuggestions(string searchText);
    }
}

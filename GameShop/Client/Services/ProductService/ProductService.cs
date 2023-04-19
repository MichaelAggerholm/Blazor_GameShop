namespace GameShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public event Action ProductsChanged;

        public ProductService(HttpClient http) 
        {
            _http = http;
        }

        // Liste af produkter
        public List<Product> Products { get; set; } = new List<Product>();
        public string Message { get; set; } = "Indlæser produkter..";

        // Henter alle produkter ud fra categoryurl, hvis der ikke er en categoryurl bliver alle produkter hentet
        public async Task GetProductsAsync(string? categoryUrl = null)
        {
            // Ternary operator der tjekker om der er en categoryurl, hvis der er, bliver den brugt, hvis ikke bliver den ikke brugt
            // Hvis den ikke bliver brugt, bliver alle produkter hentet
            var result = categoryUrl == null ?
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product/featured") :
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");
            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }

            // Kald eventet der siger at der er ændret i listen af produkter
            ProductsChanged.Invoke();
        }

        // Henter et produkt ud fra id
        public async Task<ServiceResponse<Product>> GetProductAsync(Guid productId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");

            return result;
        }

        // Søger efter produkter ud fra søgetekst, hvis der ikke er nogle produkter fundet, bliver der sat en besked
        public async Task SearchProducts(string searchText)
        {
            var result = await _http
                .GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/search/{searchText}");

            if(result != null && result.Data != null)
            {
                Products = result.Data;
            }
            if(Products.Count == 0) 
            {
                Message = "Ingen produkter fundet.";
            }

            ProductsChanged?.Invoke();

        }

        // Henter forslag til søgning ud fra søgetekst
        public async Task<List<string>> GetProductSearchSuggestions(string searchText)
        {
            var result = await _http
                .GetFromJsonAsync<ServiceResponse<List<string>>>($"api/product/searchsuggestions/{searchText}");

            return result.Data;
        }
    }
}

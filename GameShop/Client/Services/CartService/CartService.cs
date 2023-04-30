using Blazored.LocalStorage;
using GameShop.Shared.DTO;

namespace GameShop.Client.Services.CartService;

public class CartService : ICartService
{
    // Dette er CartService klassen, som håndterer alle indkøbsrelaterede funktioner og interaktion med API'en.
    private readonly ILocalStorageService _localStorage;
    private readonly HttpClient _http;

    // Constructor metoden, som opretter en ny instance af CartService klassen.
    public CartService(ILocalStorageService localStorage, HttpClient http)
    {
    // Gemmer en reference til local storage service og http client objekterne
        _localStorage = localStorage;
        _http = http;
    }

    // En eventhandler, som kaldes, når der foretages ændringer i indkøbskurven
    public event Action OnChange;
    
    // Tilføjer en vare til indkøbskurven ved hjælp af en asynkron metode.
    public async Task AddToCart(CartItem cartItem)
    {
        // Henter indholdet af indkøbskurven fra local storage
        var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
        // Hvis indholdet ikke findes, oprettes en ny liste
        if (cart == null)
        {
            cart = new List<CartItem>();
        }
    
        // Tilføjer varen til listen
        cart.Add(cartItem);
    
        // Gemmer listen tilbage i local storage
        await _localStorage.SetItemAsync("cart", cart);
    
        // Kalder eventhandleren for OnChange
        OnChange.Invoke();
    }

    // Henter alle varer i indkøbskurven ved hjælp af en asynkron metode.
    public async Task<List<CartItem>> GetCartItems()
    {
        // Henter indholdet af indkøbskurven fra local storage
        var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
        // Hvis indholdet ikke findes, oprettes en ny liste
        if (cart == null)
        {
            cart = new List<CartItem>();
        }
    
        // Returnerer listen over CartItem objekter
        return cart;
    }

    // Henter alle produkter fra indkøbskurven ved hjælp af en asynkron metode.
    public async Task<List<CartProductResponse>> GetCartProducts()
    {
        // Henter indholdet af indkøbskurven fra local storage
        var cartItems = await _localStorage.GetItemAsync<List<CartItem>>("cart");
        // Sender en POST-anmodning til API'en for at hente produkterne i indkøbskurven
        var response = await _http.PostAsJsonAsync("api/cart/products", cartItems);

        // Henter produkterne i indkøbskurven fra API'ens respons og konverterer dem til en liste af CartProductResponse objekter
        var cartProducts =
            await response.Content.ReadFromJsonAsync<ServiceResponse<List<CartProductResponse>>>();

        // Returnerer listen over CartProductResponse objekter
        return cartProducts.Data;
    }

    public async Task RemoveProductFromCart(Guid productId, Guid productTypeId)
    {
        // Hent kurv fra LocalStorage
        var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
        if (cart == null)
        {
            // Hvis kurven er tom, så er der ikke noget at fjerne
            return;
        }

        // Find det produkt der skal fjernes
        var cartItem = cart.Find(x => x.ProductId == productId 
                                      && x.ProductTypeId == productTypeId);

        if (cartItem != null)
        {
            cart.Remove(cartItem);
            // Opdater LocalStorage
            await _localStorage.SetItemAsync("cart", cart);
            // Invoke OnChange for at opdatere kurven i UI
            OnChange.Invoke();
        }
    }
}
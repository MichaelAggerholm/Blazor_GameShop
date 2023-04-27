namespace GameShop.Shared.DTO;

public class CartProductResponse
{
    public Guid ProductId { get; set; }

    public string Title { get; set; } = string.Empty;

    public Guid ProductTypeId { get; set; }
    
    public string ProductType { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;
    
    public decimal Price { get; set; }
}
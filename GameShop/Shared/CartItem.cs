namespace GameShop.Shared;

public class CartItem
{
    public Guid ProductId { get; set; }
    
    public Guid ProductTypeId { get; set; }

    public int Quantity { get; set; } = 1;
}
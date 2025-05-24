namespace PurchaseCart.Domain;

public class OrderItem
{
    public int ItemId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal VatValue { get; set; }
}

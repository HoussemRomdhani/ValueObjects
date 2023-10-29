using ValueObjects.Enums;
using ValueObjects.Examples;

namespace ValueObjects;

public class Product
{
    public string Title { get; set; } = string.Empty;
    public Money Price { get; set; } = Money.Create(0, Currency.EUR);
    public Quantity Quantity { get; set; } = Quantity.Create(1);
    public Percentage Discount { get; set; } = Percentage.ZeroPercent;
    public Money Cost => (Price - (Price * Discount)) * Quantity;
}



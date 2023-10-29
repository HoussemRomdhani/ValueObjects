using ValueObjects;
using ValueObjects.Enums;
using ValueObjects.Examples;

namespace Client1;

internal class Program
{
    static void Main()
    {
        var product1 = new Product
        {
            Title = "Product 1",
            Price = Money.Create(12.76m, Currency.EUR),
            Discount = Percentage.TenPercent,
            Quantity = Quantity.Create(23)
        };

        var product2 = new Product
        {
            Title = "Product 2",
            Price = Money.Create(245m, Currency.EUR),
            Discount = Percentage.ZeroPercent,
            Quantity = Quantity.Create(5)
        };

        var product3 = new Product
        {
            Title = "Product 3",
            Price = Money.Create(15, Currency.EUR),
            Discount = Percentage.TwentyPercent,
            Quantity = Quantity.Create(2)
        };

        var cart = new ShoppingCart();

        cart.Add(product1);
        cart.Add(product2);
        cart.Add(product3);

        cart.Print();

        Console.ReadKey();
    }
}
using ValueObjects.Examples;
using ValueObjects.Examples.Extensions;

namespace ValueObjects;

public class ShoppingCart
{
    public IList<Product> Products { get; private set; } = new List<Product>();
    public Money Total => Products.Select(x => x.Cost).Sum();

    public void Add(Product product)
    {
        Products.Add(product);
    }

    public void Add(IList<Product> products)
    {
        foreach (var product in products)
        {
            Add(product);
        }
    }



}

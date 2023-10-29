using ConsoleTables;

namespace ValueObjects;

public static class UIExtensions
{
    public static void Print(this IList<Customer> customers)
    {
        var table = new ConsoleTable("Id", "Name", "Email");

        foreach (var item in customers)
        {
            table.AddRow(item.Id, $"{item.FirstName} {item.LastName}", item.Email);
        }

        table.Write();
    }

    public static void Print(this Customer customer)
    {
        var table = new ConsoleTable("Id", "Name", "Email");

        table.AddRow(customer.Id, $"{customer.FirstName} {customer.LastName}", customer.Email);

        table.Write();
    }


    public static void Print(this ShoppingCart cart)
    {
        var table = new ConsoleTable("Product", "Unit price", "Discount", "Cost");

        foreach (var product in cart.Products)
        {
            table.AddRow($"{product.Quantity} x {product.Title}", product.Price, product.Discount, product.Cost);
        }

        table.AddRow(string.Empty, string.Empty, string.Empty, cart.Total);
        table.Write();
    }
}

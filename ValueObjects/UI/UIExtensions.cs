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
}

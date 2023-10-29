using ValueObjects;

namespace Client1;

internal class Program
{
    static void Main()
    {
        var customers = new List<Customer>
        {
             Customer.Create("Scott", "Archibald", "scottarchibald.42@yy"),
             Customer.Create("Travis", "Brooks", ""),
             Customer.Create("Victor", "Erickson", "victor.erickson@gmail.com"),
             Customer.Create("Thomas", "Adderiy", null),
        };

        customers.Print();

        Console.ReadKey();
    }
}
using ValueObjects;

namespace Client1;

internal class Program
{
    static void Main()
    {
        var customers = new List<Customer>();

        if (Validators.IsValidEmail("scottarchibald.42@yy"))
        {
            customers.Add(Customer.Create("Scott", "Archibald", "scottarchibald.42@yy"));
        }

        if (Validators.IsValidEmail(""))
        {
            customers.Add(Customer.Create("Travis", "Brooks", ""));
        }

        if (Validators.IsValidEmail("victor.erickson@gmail.com"))
        {
            customers.Add(Customer.Create("Victor", "Erickson", "victor.erickson@gmail.com"));
        }

        if (Validators.IsValidEmail(null))
        {
            customers.Add(Customer.Create("Thomas", "Adderiy", null));
        }

        customers.Print();

        Console.ReadKey();
    }
}
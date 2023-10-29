using System.ComponentModel.DataAnnotations;
using ValueObjects;

namespace Client2;

internal class Program
{
    static void Main()
    {
        var customers = new List<Customer>();

        if (IsValidEmail("scottarchibald.42@yy"))
        {
            customers.Add(Customer.Create("Scott", "Archibald", "scottarchibald.42@yy"));
        }

        if (IsValidEmail(""))
        {
            customers.Add(Customer.Create("Travis", "Brooks", ""));
        }

        if (IsValidEmail("victor.erickson@gmail.com"))
        {
            customers.Add(Customer.Create("Victor", "Erickson", "victor.erickson@gmail.com"));
        }

        if (IsValidEmail(null))
        {
            customers.Add(Customer.Create("Thomas", "Adderiy", null));
        }

        customers.Print();

        Console.ReadKey();
    }


    public static bool IsValidEmail(string value)
    {
        return new EmailAddressAttribute().IsValid(value);
    }
    
}
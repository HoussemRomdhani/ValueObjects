using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using ValueObjects;

namespace Client1;

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
        if (string.IsNullOrWhiteSpace(value))
            return false;

        Regex regex = new(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        Match match = regex.Match(value);

        return match.Success;
    }
}
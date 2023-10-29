﻿using ValueObjects;

namespace Client1;

internal class Program
{
    static void Main()
    {
        var customers = new List<Customer>();

        Email? email = Email.TryCreate("scottarchibald.42@yy");

        if (email != null)
        {
            customers.Add(Customer.Create("Scott", "Archibald", email));
        }

        email = Email.TryCreate("");

        if (email != null)
        {
            customers.Add(Customer.Create("Travis", "Brooks", email));
        }

        email = Email.TryCreate("victor.erickson@gmail.com");

        if (email != null)
        {
            customers.Add(Customer.Create("Victor", "Erickson", email));
        }

        email = Email.TryCreate(null);

        if (email != null)
        {
            customers.Add(Customer.Create("Thomas", "Adderiy", email));
        }

        customers.Print();

        Console.ReadKey();
    }

    #region Hidden code
    //static void Main()
    //{
    //    var email1 = Email.TryCreate("victor.erickson@gmail.com");

    //    var email2 = Email.TryCreate("victor.erickson@gmail.com");

    //    Console.WriteLine(email1 == email2);

    //    Console.ReadKey();
    //}

    #endregion
}
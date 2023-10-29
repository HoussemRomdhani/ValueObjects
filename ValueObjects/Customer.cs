namespace ValueObjects;

public class Customer
{
    public Guid Id { get; private set; }
    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public Email Email { get; private set; }

    private Customer()
    {

    }

    public static Customer Create(string firstName, string lastName, Email email)
    {
        return new Customer
        {
            Id = Guid.NewGuid(),
            FirstName = firstName,
            LastName = lastName,
            Email = email
        };
    }
}

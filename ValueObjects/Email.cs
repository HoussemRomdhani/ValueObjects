using System.Text.RegularExpressions;
using ValueObjects.Abstractions;

namespace ValueObjects;

public sealed class Email : ValueObject
{
    public string Value { get; private set; }


    private Email()
    {
    }

    public static Email? TryCreate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return null;

        Regex regex = new(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        Match match = regex.Match(value);

        if (!match.Success)
            return null;

        return new Email
        {
            Value = value
        };
    }

    public override string ToString()
    {
        return Value;
    }

    protected override IEnumerable<object> EqualityComponents
    {
        get
        {
            yield return Value;
        }
    }

}

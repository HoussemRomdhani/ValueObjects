using ValueObjects.Abstractions;

namespace ValueObjects.Examples;

public sealed class Percentage : ValueObject
{
    public decimal Value { get; private set; }

    private Percentage()
    {
    }

    public static Percentage Create(decimal value)
    {
        if (value < 0 || value > 1)
            throw new InvalidOperationException("Invalid percentage");

        return new Percentage
        {
            Value = value
        };
    }

    public static decimal operator *(Percentage percentage, Money money) => percentage.Value * money.Amount;
    public static Percentage TenPercent => Create(0.1m);
    public static Percentage TwentyPercent => Create(0.2m);
    public static Percentage ZeroPercent => Create(decimal.Zero);
    public static Percentage OneHundredPercent => Create(1);

    protected override IEnumerable<object> EqualityComponents
    {
        get
        {
            yield return Value;
        }
    }

    public override string ToString()
    {
        return $"{Value * 100} %"; 
    }
}

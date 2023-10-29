using ValueObjects.Abstractions;

namespace ValueObjects.Examples;

public sealed class Quantity : ValueObject
{
    public int Value { get; private set; }

    private Quantity()
    {
    }

    public static Quantity Create(int value)
    {
        if (value <= 0)
        {
            throw new Exception("Invalid quantity");
        }

        return new Quantity
        {
            Value = value
        };
    }
    public static bool operator >=(Quantity left, Quantity right) => left.Value >= right.Value;
    public static bool operator <=(Quantity left, Quantity right) => left.Value <= right.Value;
    public static Quantity operator +(Quantity left, Quantity right) => Create(left.Value + right.Value);
    public static Quantity operator -(Quantity left, Quantity right) => Create(left.Value - right.Value);

    public override string ToString()
    {
        return Value.ToString();
    }

    protected override IEnumerable<object> EqualityComponents
    {
        get
        {
            yield return Value;
        }
    }
}
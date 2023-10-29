using ValueObjects.Abstractions;
using ValueObjects.Enums;

namespace ValueObjects.Examples;

public sealed class Money : ValueObject
{
    public decimal Amount { get; private set; }
    public Currency Currency { get; private set; }

    private Money()
    {
    }

    public static Money operator *(Money money, decimal value) => Create(money.Amount * value, money.Currency);
    public static Money operator *(Money money, int value) => Create(money.Amount * value, money.Currency);
    public static Money operator *(Money money, Quantity quantity) => Create(money.Amount * quantity.Value, money.Currency);
    public static Money operator *(Money money, Percentage percentage) => Create(money.Amount * percentage.Value, money.Currency);
    public static Money operator +(Money right, Money left)
    {
        return !right.Currency.Equals(left.Currency)
            ? throw new InvalidOperationException("Can't sum up money with different currencies")
            : Create(right.Amount + left.Amount, right.Currency);
    }

    public static Money operator -(Money right, Money left)
    {
        return !right.Currency.Equals(left.Currency)
            ? throw new InvalidOperationException("Can't substract money with different currencies")
            : Create(right.Amount - left.Amount, right.Currency);
    }
    public static Money Create(decimal amount, Currency currency)
    {
        return new Money
        {
            Amount = amount,
            Currency = currency
        };
    }

    public static Money ZeroEuro => Create(0, Currency.EUR);

    public override string ToString()
    {
        return $"{Amount} {Currency}"; 
    }

    protected override IEnumerable<object> EqualityComponents
    {
        get
        {
            yield return Amount;
            yield return Currency;
        }
    }
}
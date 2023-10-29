using ValueObjects.Enums;

namespace ValueObjects.Examples.Extensions;

public static class MoneyExtensions
{
    public static Money Sum(this IEnumerable<Money> moneys)
    {
        Money result = Money.Create(decimal.Zero, Currency.EUR);

        foreach (var money in moneys)
            result += money;

        return result;
    }
}

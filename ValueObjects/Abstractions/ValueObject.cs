namespace ValueObjects.Abstractions;

public abstract class ValueObject
{
    protected abstract IEnumerable<object> EqualityComponents { get; }

    public override bool Equals(object? other)
    {
        if (other == null)
            return false;

        if (GetType() != other.GetType())
            return false;

        var valueObject = (ValueObject)other;

        return EqualityComponents.SequenceEqual(valueObject.EqualityComponents);
    }

    public override int GetHashCode() => EqualityComponents
            .Aggregate(1, (current, obj) =>
            {
                unchecked
                {
                    return current * 42 + (obj?.GetHashCode() ?? 0);
                }
            });

    public static bool operator ==(ValueObject left, ValueObject right)
    {
        if (ReferenceEquals(left, null) && ReferenceEquals(right, null))
            return true;

        if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            return false;

        return left.Equals(right);
    }

    public static bool operator !=(ValueObject left, ValueObject right) => !(left == right);
}

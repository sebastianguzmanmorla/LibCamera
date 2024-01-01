using System.Reflection;

namespace LibCamera.Helpers
{
    public abstract class Enumeration<TValue> : IComparable where TValue : IComparable, IComparable<TValue>
    {
        public TValue Value { get; private set; }

        public string? Description { get; private set; }

        protected Enumeration(TValue value, string? description = null) => (Value, Description) = (value, description);

        public override string? ToString() =>  Value?.ToString();

        public static IEnumerable<T> GetAll<T>() where T : Enumeration<TValue>
        {
            return typeof(T).GetFields(BindingFlags.Public |
                                BindingFlags.Static |
                                BindingFlags.DeclaredOnly)
                    .Select(f => f.GetValue(null))
                    .Cast<T>();
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Enumeration<TValue> otherValue)
            {
                return false;
            }

            bool typeMatches = GetType().Equals(obj.GetType());
            bool valueMatches = Value.Equals(otherValue.Value);

            return typeMatches && valueMatches;
        }

        public int CompareTo(object? other)
        {
            return other is null ? throw new ArgumentNullException(nameof(other)) : Value.CompareTo(((Enumeration<TValue>)other).Value);
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Enumeration<TValue> left, Enumeration<TValue> right)
        {
            return left is null ? right is null : left.Equals(right);
        }

        public static bool operator !=(Enumeration<TValue> left, Enumeration<TValue> right)
        {
            return !(left == right);
        }

        public static bool operator <(Enumeration<TValue> left, Enumeration<TValue> right)
        {
            return left is null ? right is not null : left.CompareTo(right) < 0;
        }

        public static bool operator <=(Enumeration<TValue> left, Enumeration<TValue> right)
        {
            return left is null || left.CompareTo(right) <= 0;
        }

        public static bool operator >(Enumeration<TValue> left, Enumeration<TValue> right)
        {
            return left is not null && left.CompareTo(right) > 0;
        }

        public static bool operator >=(Enumeration<TValue> left, Enumeration<TValue> right)
        {
            return left is null ? right is null : left.CompareTo(right) >= 0;
        }
    }
}
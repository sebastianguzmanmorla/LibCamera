using System.Reflection;

namespace LibCamera.Helpers
{
    public abstract class Enumeration<TValue> : Stringable, IComparable where TValue : IComparable, IComparable<TValue>
    {
        public TValue Value { get; private set; }

        public string? Description { get; private set; }

        protected Enumeration(TValue value, string? description = null) => (Value, Description) = (value, description);

        public override string? ToString() => Value?.ToString();

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
            return Value.GetHashCode();
        }
    }
}
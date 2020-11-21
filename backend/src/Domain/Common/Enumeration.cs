using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Pibidex.Domain.Common
{
    public abstract class Enumeration<TEnumeration> :
        Enumeration<TEnumeration, int>
        where TEnumeration : Enumeration<TEnumeration, int>
    {
        protected Enumeration(int id, string name) : base(id, name)
        {
        }
    }


    public abstract class Enumeration<TEnumeration, TId> :
        IEquatable<Enumeration<TEnumeration, TId>>,
        IComparable<Enumeration<TEnumeration, TId>>
        where TEnumeration : Enumeration<TEnumeration, TId>
        where TId : IEquatable<TId>, IComparable<TId>
    {
        public TId Id { get; }

        public string Name { get; }

        protected Enumeration(TId id, string name)
        {
            if (string.IsNullOrEmpty(name))
                new ArgumentException(nameof(name));
            if (id is null)
                new ArgumentNullException(nameof(id));

            Id = id!;
            Name = name;
        }

        public override string ToString() => Name.ToString();

        public static IEnumerable<TEnumeration> GetAll()
        {
            var baseType = typeof(TEnumeration);
            var enumTypes = baseType.Assembly.GetTypes().Where(t => baseType.IsAssignableFrom(t));

            var options = new List<TEnumeration>();
            foreach (var enumType in enumTypes)
            {
                options.AddRange(
                    enumType.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                    .Where(fi => enumType.IsAssignableFrom(fi.FieldType))
                    .Select(fi => fi.GetValue(null))
                    .Cast<TEnumeration>()
                    .ToList());
            }

            return options;
        }

        public static TEnumeration FromId(TId id) =>
            Parse(id, nameof(id), item => item.Id.Equals(id));

        public static TEnumeration FromName(string name, bool ignoreCase = true)
        {
            if (ignoreCase)
                return Parse(name, nameof(name), item => item.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));

            return Parse(name, nameof(name), item => item.Name.Equals(name));
        }

        public static bool TryFromName(string name, out TEnumeration? result, bool ignoreCase = true)
        {
            try
            {
                result = FromName(name, ignoreCase);
                return true;
            }
            catch (InvalidOperationException)
            {
                result = default;
                return false;
            }
        }

        public static bool operator ==(Enumeration<TEnumeration, TId>? left,
            Enumeration<TEnumeration, TId>? right)
        {
            if (left is null)
                return right is null;

            return left.Equals(right);
        }

        public static bool operator !=(Enumeration<TEnumeration, TId>? left,
            Enumeration<TEnumeration, TId>? right) =>
            !(left == right);

        public override bool Equals(object? obj)
        {
            if (obj is null || obj.GetType() != GetType())
                return false;

            return ((Enumeration<TEnumeration, TId>)obj).Id.Equals(Id);
        }

        public virtual bool Equals(Enumeration<TEnumeration, TId>? other)
        {
            if (ReferenceEquals(this, other))
                return true;

            if (other is null)
                return false;

            return Id.Equals(other.Id);
        }

        public virtual int CompareTo(Enumeration<TEnumeration, TId>? other) =>
            other is null ? 1 : Id.CompareTo(other.Id);

        public override int GetHashCode() => Id.GetHashCode();

        public static bool operator <(Enumeration<TEnumeration, TId>? left,
            Enumeration<TEnumeration, TId>? right)
        {
            if (left is null)
                return !(right is null);

            return left.CompareTo(right) < 0;
        }

        public static bool operator <=(Enumeration<TEnumeration, TId>? left,
            Enumeration<TEnumeration, TId>? right)
        {
            if (left is null ^ right is null)
                return false;

            return (bool?)(left?.CompareTo(right) <= 0) ?? true;
        }

        public static bool operator >(Enumeration<TEnumeration, TId>? left,
            Enumeration<TEnumeration, TId>? right) =>
            !(left < right);

        public static bool operator >=(Enumeration<TEnumeration, TId>? left,
            Enumeration<TEnumeration, TId>? right)
        {
            if (left is null ^ right is null)
                return false;

            return (bool?)(left?.CompareTo(right) >= 0) ?? true;
        }

        public static implicit operator TId(Enumeration<TEnumeration, TId> enumeration) =>
            enumeration.Id;

        public static explicit operator Enumeration<TEnumeration, TId>(TId value) =>
            FromId(value);

        protected static TEnumeration Parse<TProperty>(TProperty propertyValue, string propertyName, Func<TEnumeration, bool> predicate) =>
            GetAll().FirstOrDefault(predicate)
            ?? throw new InvalidOperationException($"'{propertyValue}' is not a valid {propertyName} in {typeof(TEnumeration).Name}");
    }
}
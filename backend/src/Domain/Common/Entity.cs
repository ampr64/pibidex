using Pibidex.Domain.ValueObjects;
using System;

namespace Pibidex.Domain.Common
{
    public abstract class Entity : IEquatable<Entity>
    {
        public int Id { get; protected set; }

        public Name Name { get; protected set; } = null!;

        protected Entity() { }

        protected Entity(string name) => Name = (Name)name;

        protected Entity(Name name) => Name = name;

        public static bool operator ==(Entity? left, Entity? right)
        {
            if (left is null)
                return right is null;

            return left.Equals(right);
        }

        public static bool operator !=(Entity? left, Entity? right) =>
            !(left! == right!);

        public bool IsTransient() => Id.Equals(default);

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Entity other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals(Entity? other)
        {
            if (other is null || IsTransient())
                return false;

            return Id.Equals(other.Id);
        }

        public override int GetHashCode() => Id.GetHashCode();
    }
}
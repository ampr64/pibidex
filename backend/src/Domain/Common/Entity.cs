using Pibidex.Domain.ValueObjects;
using System;

namespace Pibidex.Domain.Common
{
    public abstract class Entity<TId> : IEquatable<Entity<TId>>
        where TId : Id<TId>
    {
        public TId Id { get; protected set; } = null!;

        public Name Name { get; protected set; } = null!;

        protected Entity() { }

        protected Entity(string name) => Name = (Name)name;

        protected Entity(Name name) => Name = name;

        public static bool operator ==(Entity<TId>? left, Entity<TId>? right)
        {
            if (left is null)
                return right is null;

            return left.Equals(right);
        }

        public static bool operator !=(Entity<TId>? left, Entity<TId>? right) =>
            !(left! == right!);

        public bool IsTransient() => Id is null;

        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is Entity<TId> other))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (GetType() != other.GetType())
                return false;

            if (IsTransient() || other.IsTransient())
                return false;

            return Id.Equals(other.Id);
        }

        public bool Equals(Entity<TId>? other)
        {
            if (other is null || IsTransient())
                return false;

            return GetType() == other.GetType() && Id.Equals(other.Id);
        }

        public override int GetHashCode() => Id.GetHashCode();
    }
}
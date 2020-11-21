using Ardalis.GuardClauses;
using System;

namespace Pibidex.Domain.Common
{
    public abstract class Entity<TId> : IEquatable<Entity<TId>>
        where TId : Id<TId>, IEquatable<TId>
    {
        public TId Id { get; private set; } = null!;

        public string Name { get; private set; } = null!;

        protected Entity() { }

        protected Entity(string name) => SetName(name);

        protected Entity(TId id, string name) : this(name) => Id = Guard.Against.Null(id, nameof(id));

        protected void SetName(string name) => Name = Guard.Against.NullOrWhiteSpace(name, nameof(name));

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
            if (obj is null || obj is not Entity<TId> other)
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
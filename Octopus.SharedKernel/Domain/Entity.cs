namespace Octopus.SharedKernel.Domain;

public interface IEntity
{
    object Id { get; }
}

public interface IEntity<out TId> : IEntity
    where TId : notnull
{
    new TId Id { get; }
}

public abstract class Entity<TId> : IEntity<TId>
    where TId : notnull
{
    public TId Id { get; protected set; } = default!;

    object IEntity.Id => Id;

    public override bool Equals(object? obj)
    {
        return obj is Entity<TId> other && Id.Equals(other.Id);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public static bool operator ==(Entity<TId>? left, Entity<TId>? right) => Equals(left, right);

    public static bool operator !=(Entity<TId>? left, Entity<TId>? right) => !Equals(left, right);
}

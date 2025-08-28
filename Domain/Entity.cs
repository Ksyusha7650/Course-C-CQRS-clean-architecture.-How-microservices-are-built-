using Domain.Abstractions;

namespace Domain;

public abstract class Entity<T> : IEntity<T>
{
    public required T Id { get; set; }
}
namespace MovieApp.Domain.Entities.BaseEntities;

public interface ICreationAuditedEntity<T> : IEntity<T>
{
    public DateTimeOffset CreatedAt { get; set; }
    public int? CreatedBy { get; set; }
    public string? CreatedByName { get; set; }
}
public abstract class CreationAuditedEntity<T> : Entity<T>, ICreationAuditedEntity<T>
{
    public DateTimeOffset CreatedAt { get; set; }
    public int? CreatedBy { get; set; }
    public string? CreatedByName { get; set; }
}

public abstract class CreationAuditedEntity:CreationAuditedEntity<int>
{
}
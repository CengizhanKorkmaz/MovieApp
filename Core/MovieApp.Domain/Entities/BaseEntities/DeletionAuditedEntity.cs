namespace MovieApp.Domain.Entities.BaseEntities;

public interface IDeletionAuditedEntity<T> : IEntity<T>
{
    public bool IsDeleted { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
    public int? DeletedBy { get; set; }
    public string? DeletedByName { get; set; }
}
public abstract class DeletionAuditedEntity<T> : Entity<T>, IDeletionAuditedEntity<T>
{
    public bool IsDeleted { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
    public int? DeletedBy { get; set; }
    public string? DeletedByName { get; set; }
}

public abstract class DeletionAuditedEntity : DeletionAuditedEntity<int>
{
}
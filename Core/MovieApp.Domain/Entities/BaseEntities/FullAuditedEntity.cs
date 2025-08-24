namespace MovieApp.Domain.Entities.BaseEntities;

public interface IFullAuditedEntity<T> : IEntity<T>, ICreationAuditedEntity<T>, IModificationAuditedEntity<T>, IDeletionAuditedEntity<T>
{
}

public class FullAuditedEntity<T> : Entity<T>, IFullAuditedEntity<T>
{
    public DateTimeOffset CreatedAt { get; set; }
    public int? CreatedBy { get; set; }
    public string? CreatedByName { get; set; }
    public DateTimeOffset? ModifiedAt { get; set; }
    public int? ModifiedBy { get; set; }
    public string? ModifiedByName { get; set; }
    public bool IsDeleted { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
    public int? DeletedBy { get; set; }
    public string? DeletedByName { get; set; }
}
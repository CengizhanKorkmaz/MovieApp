namespace MovieApp.Domain.Entities.BaseEntities;

public interface IModificationAuditedEntity<T> : IEntity<T>
{
    public DateTimeOffset? ModifiedAt { get; set; }
    public int? ModifiedBy { get; set; }
    public string? ModifiedByName { get; set; }
    
}
public class ModificationAuditedEntity<T>:Entity<T>, IModificationAuditedEntity<T>
{
    public DateTimeOffset? ModifiedAt { get; set; }
    public int? ModifiedBy { get; set; }
    public string? ModifiedByName { get; set; }
}

public class ModificationAuditedEntity:ModificationAuditedEntity<int>
{
}
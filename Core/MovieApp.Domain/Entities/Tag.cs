using MovieApp.Domain.Entities.BaseEntities;

namespace MovieApp.Domain.Entities;

public class Tag: CreationAuditedEntity
{
    public string Name { get; set; }
}
using MovieApp.Domain.Entities.BaseEntities;

namespace MovieApp.Domain.Entities;

public class Category :FullAuditedEntity<int>
{
    public string Name { get; set; }
}
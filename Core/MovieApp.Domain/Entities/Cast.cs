using MovieApp.Domain.Entities.BaseEntities;

namespace MovieApp.Domain.Entities;

public class Cast : FullAuditedEntity<int>
{
    public string Title { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? ImageUrl { get; set; }
    public string? Overview { get; set; }
    public string? Biography { get; set; }
    
}
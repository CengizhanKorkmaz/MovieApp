using MovieApp.Domain.Entities.BaseEntities;

namespace MovieApp.Domain.Entities;

public class RelatedMovie:CreationAuditedEntity
{
    public int MovieId { get; set; }
    public int RelatedMovieId { get; set; }
    public int UserId { get; set; }
    public bool IsWatch { get; set; }
    
}
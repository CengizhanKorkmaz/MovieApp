using MovieApp.Domain.Entities.BaseEntities;

namespace MovieApp.Domain.Entities;

public class Review : CreationAuditedEntity
{
    public string Comment { get; set; }
    public decimal UserRating { get; set; }
    public int MovieId { get; set; }
    public bool Status { get; set; }
}
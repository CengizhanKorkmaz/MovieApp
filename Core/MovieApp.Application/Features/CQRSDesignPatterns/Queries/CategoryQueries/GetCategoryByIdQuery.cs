namespace MovieApp.Application.Features.CQRSDesignPatterns.Queries.CategoryQueries;

public class GetCategoryByIdQuery(int id)
{
    public int Id { get; set; } = id;
}
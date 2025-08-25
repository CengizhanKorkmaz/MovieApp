namespace MovieApp.Application.Features.CQRSDesignPatterns.Queries.MovieQueries;

public class GetMovieByIdQuery(int id)
{
    public int Id { get; set; } = id;
}
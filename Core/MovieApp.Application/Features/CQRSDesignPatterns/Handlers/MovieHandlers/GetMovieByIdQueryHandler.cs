using MovieApp.Application.Features.CQRSDesignPatterns.Queries.MovieQueries;
using MovieApp.Application.Features.CQRSDesignPatterns.Results.MovieResults;
using MovieApp.Persistence.Data.Context;

namespace MovieApp.Application.Features.CQRSDesignPatterns.Handlers.MovieHandlers;

public class GetMovieByIdQueryHandler(ApplicationContext context)
{
    
    public async Task<GetMovieQueryResult?> Handle(GetMovieByIdQuery query)
    {
        var movie = await context.Movies.FindAsync(query.Id);
        var result = movie == null ? null : new GetMovieQueryResult
        {
            Id = movie.Id,
            Name = movie.Name,
            Title = movie.Title,
            CoverImageUrl = movie.CoverImageUrl,
            Rating = movie.Rating,
            Description = movie.Description,
            Duration = movie.Duration,
            ReleaseDate = movie.ReleaseDate,
            Year = movie.Year,
            Status = movie.Status
        };
        return result;
    }
    
}
using Microsoft.EntityFrameworkCore;
using MovieApp.Application.Features.CQRSDesignPatterns.Results.MovieResults;
using MovieApp.Persistence.Data.Context;

namespace MovieApp.Application.Features.CQRSDesignPatterns.Handlers.MovieHandlers;

public class GetMovieQueryHandler(ApplicationContext context)
{
    public async Task<List<GetMovieQueryResult>> Handle()
    {
        var movies = await context.Movies.Select(m => new GetMovieQueryResult
        {
            Id = m.Id,
            Name = m.Name,
            Title = m.Title,
            CoverImageUrl = m.CoverImageUrl,
            Rating = m.Rating,
            Description = m.Description,
            Duration = m.Duration,
            ReleaseDate = m.ReleaseDate,
            Year = m.Year,
            Status = m.Status
        }).ToListAsync();
        return movies;
        
    }
    
}
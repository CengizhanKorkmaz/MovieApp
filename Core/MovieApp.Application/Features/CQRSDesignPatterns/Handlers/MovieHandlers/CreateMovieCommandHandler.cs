using MovieApp.Application.Features.CQRSDesignPatterns.Commands.MovieCommands;
using MovieApp.Persistence.Data.Context;

namespace MovieApp.Application.Features.CQRSDesignPatterns.Handlers.MovieHandlers;

public class CreateMovieCommandHandler(ApplicationContext context)
{
    public async Task Handle(CreateMovieCommand command)
    {
        context.Movies.Add(new Domain.Entities.Movie
        {
            Name = command.Name,
            Title = command.Title,
            CoverImageUrl = command.CoverImageUrl,
            Rating = command.Rating,
            Description = command.Description,
            Duration = command.Duration,
            ReleaseDate = command.ReleaseDate,
            Year = command.Year,
            Status = command.Status,
        });
        await context.SaveChangesAsync();
    }
}
using MovieApp.Application.Features.CQRSDesignPatterns.Commands.MovieCommands;
using MovieApp.Persistence.Data.Context;

namespace MovieApp.Application.Features.CQRSDesignPatterns.Handlers.MovieHandlers;

public class UpdateMovieCommandHandler(ApplicationContext context)
{
    public async Task Handle(UpdateMovieCommand command)
    {
        var movie = await context.Movies.FindAsync(command.Id);
        if (movie != null)
        { 
            movie.Name=command.Name;  
            movie.Title=command.Title;  
            movie.CoverImageUrl=command.CoverImageUrl;  
            movie.Rating=command.Rating;  
            movie.Description=command.Description;  
            movie.Duration=command.Duration;  
            movie.ReleaseDate=command.ReleaseDate;  
            movie.Year=command.Year;  
            movie.Status=command.Status;  
            await context.SaveChangesAsync();
        }
    }
    
}
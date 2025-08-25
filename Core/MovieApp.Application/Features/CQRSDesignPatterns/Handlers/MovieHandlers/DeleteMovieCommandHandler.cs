using MovieApp.Application.Features.CQRSDesignPatterns.Commands.MovieCommands;
using MovieApp.Persistence.Data.Context;

namespace MovieApp.Application.Features.CQRSDesignPatterns.Handlers.MovieHandlers;

public class DeleteMovieCommandHandler(ApplicationContext context)
{
    public async Task Handle(DeleteMovieCommand command)
    {
        var movie = await context.Movies.FindAsync(command.Id);
        if (movie != null)
        {
            context.Movies.Remove(movie);
            await context.SaveChangesAsync();
        }
    }
}
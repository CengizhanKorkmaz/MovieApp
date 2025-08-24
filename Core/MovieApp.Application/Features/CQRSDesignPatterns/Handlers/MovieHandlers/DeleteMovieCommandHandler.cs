using MovieApp.Persistence.Data.Context;

namespace MovieApp.Application.Features.CQRSDesignPatterns.Handlers.MovieHandlers;

public class DeleteMovieCommandHandler(ApplicationContext context)
{
    public async void Handle(int id)
    {
        var movie = await context.Movies.FindAsync(id);
        if (movie != null)
        {
            context.Movies.Remove(movie);
            await context.SaveChangesAsync();
        }
    }
}
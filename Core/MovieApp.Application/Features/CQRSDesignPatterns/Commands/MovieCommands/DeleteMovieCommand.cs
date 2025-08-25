namespace MovieApp.Application.Features.CQRSDesignPatterns.Commands.MovieCommands;

public class DeleteMovieCommand(int id)
{
    public int Id { get; set; } = id;
}
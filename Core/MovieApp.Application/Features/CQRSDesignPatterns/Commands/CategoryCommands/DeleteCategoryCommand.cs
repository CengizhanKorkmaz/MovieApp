namespace MovieApp.Application.Features.CQRSDesignPatterns.Commands.CategoryCommands;

public class DeleteCategoryCommand(int id)
{
    public int Id { get; set; } = id;
}



namespace MovieApp.Application.Features.CQRSDesignPatterns.Commands.CategoryCommands;

public class UpdateCategoryCommand
{
    public int Id { get; set; }
    public string Name { get; set; }
}
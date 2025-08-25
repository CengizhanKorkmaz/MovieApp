using MovieApp.Application.Features.CQRSDesignPatterns.Commands.CategoryCommands;
using MovieApp.Persistence.Data.Context;

namespace MovieApp.Application.Features.CQRSDesignPatterns.Handlers.CategoryHandlers;

public class UpdateCategoryCommandHandler(ApplicationContext context)
{
    public async Task Handle(UpdateCategoryCommand command)
    {
        var category = await context.Categories.FindAsync(command.Id);
        if (category != null)
        {
            category.Name = command.Name;
            await context.SaveChangesAsync();
        }
    }
    
}
using MovieApp.Application.Features.CQRSDesignPatterns.Commands.CategoryCommands;
using MovieApp.Domain.Entities;
using MovieApp.Persistence.Data.Context;

namespace MovieApp.Application.Features.CQRSDesignPatterns.Handlers.CategoryHandlers;

public class CreateCategoryCommandHandler(ApplicationContext context)
{
    public async void Handle(CreateCategoryCommand command)
    {
        context.Categories.Add(new Category
        {
            Name = command.Name,
        });
        await context.SaveChangesAsync();
    }
    
}
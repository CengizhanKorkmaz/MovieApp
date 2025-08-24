using MovieApp.Persistence.Data.Context;

namespace MovieApp.Application.Features.CQRSDesignPatterns.Handlers.CategoryHandlers;

public class DeleteCategoryCommandHandler(ApplicationContext context)
{
    public async void Handle(int id)
    {
        var category = await context.Categories.FindAsync(id);
        if (category != null)
        {
            context.Categories.Remove(category);
            await context.SaveChangesAsync();
        }
    }
    
}
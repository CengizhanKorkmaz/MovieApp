using Microsoft.EntityFrameworkCore;
using MovieApp.Application.Features.CQRSDesignPatterns.Results.CategoryResults;
using MovieApp.Persistence.Data.Context;

namespace MovieApp.Application.Features.CQRSDesignPatterns.Handlers.CategoryHandlers;

public class GetCategoryQueryHandler(ApplicationContext context)
{
    public async Task<List<GetCategoryQueryResult>> Handle()
    {
        var categories = await context.Categories.Select(c => new GetCategoryQueryResult
        {
            Id = c.Id,
            Name = c.Name
        }).ToListAsync();
        return categories;
        
    }
    
}
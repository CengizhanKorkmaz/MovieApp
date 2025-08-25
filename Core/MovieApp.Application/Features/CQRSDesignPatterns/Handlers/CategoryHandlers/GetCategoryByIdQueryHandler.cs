using MovieApp.Application.Features.CQRSDesignPatterns.Queries.CategoryQueries;
using MovieApp.Application.Features.CQRSDesignPatterns.Results.CategoryResults;
using MovieApp.Persistence.Data.Context;

namespace MovieApp.Application.Features.CQRSDesignPatterns.Handlers.CategoryHandlers;

public class GetCategoryByIdQueryHandler (ApplicationContext context)
{
    
    public async Task<GetCategoryByIdQueryResult?> Handle(GetCategoryByIdQuery query)
    {
        var category = await context.Categories.FindAsync(query.Id);
        var result = category == null ? null : new GetCategoryByIdQueryResult
        {
            Id = category.Id,
            Name = category.Name
        };
        return result;
    }
    
}
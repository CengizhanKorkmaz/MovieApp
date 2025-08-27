using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieApp.Application.Features.MediatorDesignPattern.Queries.TagQueries;
using MovieApp.Application.Features.MediatorDesignPattern.Results.TagResults;
using MovieApp.Persistence.Data.Context;

namespace MovieApp.Application.Features.MediatorDesignPattern.Handlers.TagHandlers;

public class GetTagQueryHandler(ApplicationContext context) : IRequestHandler<GetTagQuery,List<GetTagQueryResult>>
{
    public async Task<List<GetTagQueryResult>> Handle(GetTagQuery request, CancellationToken cancellationToken)
    {
        var data = await context.Tags.ToListAsync(cancellationToken);
        return data.Select(x => new GetTagQueryResult()
        {
            Id = x.Id,
            Name = x.Name
        }).ToList();
    }
}
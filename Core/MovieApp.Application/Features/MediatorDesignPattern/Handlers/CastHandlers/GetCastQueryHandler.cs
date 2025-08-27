using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieApp.Application.Features.MediatorDesignPattern.Queries.CastQueries;
using MovieApp.Application.Features.MediatorDesignPattern.Results.CastResults;
using MovieApp.Persistence.Data.Context;

namespace MovieApp.Application.Features.MediatorDesignPattern.Handlers.CastHandlers;

public class GetCastQueryHandler(ApplicationContext context):IRequestHandler<GetCastQuery,List<GetCastQueryResult>>
{
    public async Task<List<GetCastQueryResult>> Handle(GetCastQuery request, CancellationToken cancellationToken)
    {
        var data = await context.Casts.ToListAsync(cancellationToken);
        return data.Select(x=> new GetCastQueryResult
        {
            Id = x.Id,
            Name = x.Name,
            Title = x.Title,
            Surname = x.Surname,
            Biography = x.Biography,
            ImageUrl = x.ImageUrl,
            Overview = x.Overview,
        }).ToList();
    }
}
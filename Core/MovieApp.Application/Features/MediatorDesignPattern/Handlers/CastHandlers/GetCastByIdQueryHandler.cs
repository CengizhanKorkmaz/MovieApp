using MediatR;
using MovieApp.Application.Features.MediatorDesignPattern.Queries.CastQueries;
using MovieApp.Application.Features.MediatorDesignPattern.Results.CastResults;
using MovieApp.Persistence.Data.Context;

namespace MovieApp.Application.Features.MediatorDesignPattern.Handlers.CastHandlers;

public class GetCastByIdQueryHandler(ApplicationContext context):IRequestHandler<GetCastByIdQuery,GetCastByIdQueryResult>
{
    public async Task<GetCastByIdQueryResult> Handle(GetCastByIdQuery request, CancellationToken cancellationToken)
    {
        var data = await context.Casts.FindAsync(request.Id, cancellationToken);
        return new GetCastByIdQueryResult()
        {
            Id = data.Id,
            Name = data.Name,
            Title = data.Title,
            Surname = data.Surname,
            Biography = data.Biography,
            ImageUrl = data.ImageUrl,
            Overview = data.Overview,
        };
    }
}
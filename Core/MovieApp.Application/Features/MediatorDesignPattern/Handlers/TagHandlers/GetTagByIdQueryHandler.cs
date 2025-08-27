using MediatR;
using MovieApp.Application.Features.MediatorDesignPattern.Queries.TagQueries;
using MovieApp.Application.Features.MediatorDesignPattern.Results.TagResults;
using MovieApp.Persistence.Data.Context;

namespace MovieApp.Application.Features.MediatorDesignPattern.Handlers.TagHandlers;

public class GetTagByIdQueryHandler(ApplicationContext context) : IRequestHandler<GetTagQueryByIdQuery,GetTagByIdQueryResult>
{
    public async Task<GetTagByIdQueryResult> Handle(GetTagQueryByIdQuery request, CancellationToken cancellationToken)
    {
        var data =await context.Tags.FindAsync(request.Id, cancellationToken);
        return new GetTagByIdQueryResult
        {
            Id = data.Id,
            Name = data.Name
        };

    }
}
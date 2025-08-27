using MediatR;
using MovieApp.Application.Features.MediatorDesignPattern.Queries.CastQueries;
using MovieApp.Application.Features.MediatorDesignPattern.Results.TagResults;

namespace MovieApp.Application.Features.MediatorDesignPattern.Queries.TagQueries;

public class GetTagQuery:IRequest<List<GetTagQueryResult>>
{
    
}
using MediatR;
using MovieApp.Application.Features.MediatorDesignPattern.Results.CastResults;

namespace MovieApp.Application.Features.MediatorDesignPattern.Queries.CastQueries;

public class GetCastQuery:IRequest<List<GetCastByIdQueryResult>>
{
    
}
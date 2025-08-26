using MediatR;
using MovieApp.Application.Features.MediatorDesignPattern.Results.CastResults;

namespace MovieApp.Application.Features.MediatorDesignPattern.Queries.CastQueries;

public class GetCastByIdQuery(int id) : IRequest<GetCastByIdQueryResult>
{
    public int Id { get; set; } = id;

}
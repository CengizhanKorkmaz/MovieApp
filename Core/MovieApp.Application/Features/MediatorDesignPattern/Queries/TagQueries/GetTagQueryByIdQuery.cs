using MediatR;
using MovieApp.Application.Features.MediatorDesignPattern.Results.TagResults;

namespace MovieApp.Application.Features.MediatorDesignPattern.Queries.TagQueries;

public class GetTagQueryByIdQuery(int id) : IRequest<GetTagByIdQueryResult>
{
    public int Id { get; set; } = id;

}
using MediatR;

namespace MovieApp.Application.Features.MediatorDesignPattern.Commands.TagCommands;

public class DeleteTagCommand(int id) : IRequest
{
    public int Id { get; set; } = id;
}
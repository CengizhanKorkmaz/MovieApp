using MediatR;

namespace MovieApp.Application.Features.MediatorDesignPattern.Commands.TagCommands;

public class UpdateTagCommand : IRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
}
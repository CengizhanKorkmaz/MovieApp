using MediatR;

namespace MovieApp.Application.Features.MediatorDesignPattern.Commands.TagCommands;

public class CreateTagCommand:IRequest
{
    public string Name { get; set; }
}
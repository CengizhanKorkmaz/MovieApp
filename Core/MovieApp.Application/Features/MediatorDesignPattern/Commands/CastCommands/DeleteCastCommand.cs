using MediatR;

namespace MovieApp.Application.Features.MediatorDesignPattern.Commands.CastCommands;

public class DeleteCastCommand(int id):IRequest
{
    public int Id { get; set; } = id;

}
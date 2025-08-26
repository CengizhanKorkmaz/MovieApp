using MediatR;
using MovieApp.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using MovieApp.Domain.Entities;
using MovieApp.Persistence.Data.Context;

namespace MovieApp.Application.Features.MediatorDesignPattern.Handlers.CastHandlers;

public class CreateCastCommandHandler(ApplicationContext context):IRequestHandler<CreateCastCommand>
{
    public async Task Handle(CreateCastCommand request, CancellationToken cancellationToken)
    {
        context.Casts.Add(new Cast
        {
            Name = request.Name,
            Surname = request.Surname,
            Biography = request.Biography,
            Title = request.Title,
            ImageUrl = request.ImageUrl,
            Overview = request.Overview
        });

        await context.SaveChangesAsync(cancellationToken);
    }
}
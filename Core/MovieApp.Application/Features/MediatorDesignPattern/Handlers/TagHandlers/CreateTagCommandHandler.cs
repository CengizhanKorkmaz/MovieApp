using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieApp.Application.Features.MediatorDesignPattern.Commands.TagCommands;
using MovieApp.Domain.Entities;
using MovieApp.Persistence.Data.Context;

namespace MovieApp.Application.Features.MediatorDesignPattern.Handlers.TagHandlers;

public class CreateTagCommandHandler(ApplicationContext context):IRequestHandler<CreateTagCommand>
{
    public async Task Handle(CreateTagCommand request, CancellationToken cancellationToken)
    {
        context.Tags.Add(new Tag()
        {
            Name = request.Name
        });
        await context.SaveChangesAsync(cancellationToken);
    }
}
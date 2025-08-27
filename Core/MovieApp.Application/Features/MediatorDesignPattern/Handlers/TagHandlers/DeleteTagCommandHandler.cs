using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieApp.Application.Features.MediatorDesignPattern.Commands.TagCommands;
using MovieApp.Persistence.Data.Context;

namespace MovieApp.Application.Features.MediatorDesignPattern.Handlers.TagHandlers;

public class DeleteTagCommandHandler(ApplicationContext context) : IRequestHandler<DeleteTagCommand>
{
    public async Task Handle(DeleteTagCommand request, CancellationToken cancellationToken)
    {
        var tag = await context.Tags.FindAsync(request.Id, cancellationToken);
        if (tag is not null)
        {
            context.Tags.Remove(tag);
            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
using MediatR;
using MovieApp.Application.Features.MediatorDesignPattern.Commands.TagCommands;
using MovieApp.Persistence.Data.Context;

namespace MovieApp.Application.Features.MediatorDesignPattern.Handlers.TagHandlers;

public class UpdateTagCommandHandler(ApplicationContext context) : IRequestHandler<UpdateTagCommand>
{
    public async Task Handle(UpdateTagCommand request, CancellationToken cancellationToken)
    {
        var tag=await context.Tags.FindAsync(request.Id, cancellationToken);
        if (tag is not null)
        {
            tag.Name = request.Name;
            context.Tags.Update(tag);
            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
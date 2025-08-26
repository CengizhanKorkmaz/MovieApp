using MediatR;
using MovieApp.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using MovieApp.Persistence.Data.Context;

namespace MovieApp.Application.Features.MediatorDesignPattern.Handlers.CastHandlers;

public class DeleteCastCommandHandler(ApplicationContext context):IRequestHandler<DeleteCastCommand> 
{
    public async Task Handle(DeleteCastCommand request, CancellationToken cancellationToken)
    {
        var cast = await context.Casts.FindAsync(request.Id, cancellationToken);
        if (cast is not null)
        {
            context.Casts.Remove(cast);
            await context.SaveChangesAsync(cancellationToken);
        }
        
    }
}
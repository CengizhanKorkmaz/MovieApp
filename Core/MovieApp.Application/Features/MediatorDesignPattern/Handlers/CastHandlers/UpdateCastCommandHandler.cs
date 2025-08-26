using MediatR;
using MovieApp.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using MovieApp.Persistence.Data.Context;

namespace MovieApp.Application.Features.MediatorDesignPattern.Handlers.CastHandlers;

public class UpdateCastCommandHandler(ApplicationContext context):IRequestHandler<UpdateCastCommand>
{
    public async Task Handle(UpdateCastCommand request, CancellationToken cancellationToken)
    {
        var cast = await context.Casts.FindAsync(request.Id, cancellationToken);
        if (cast is not null)
        {
            cast.Name = request.Name;
            cast.Surname = request.Surname;
            cast.Biography = request.Biography;
            cast.Title = request.Title;
            cast.ImageUrl = request.ImageUrl;
            cast.Overview = request.Overview;

            context.Casts.Update(cast);
            await context.SaveChangesAsync(cancellationToken);
        }
        
    }
}
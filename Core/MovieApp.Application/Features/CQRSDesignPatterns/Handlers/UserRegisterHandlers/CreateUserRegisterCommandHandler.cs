using Microsoft.AspNetCore.Identity;
using MovieApp.Application.Features.CQRSDesignPatterns.Commands.UserRegisterCommands;
using MovieApp.Persistence.Data.Context;
using MovieApp.Persistence.Data.Identity;

namespace MovieApp.Application.Features.CQRSDesignPatterns.Handlers.UserRegisterHandlers;

public class CreateUserRegisterCommandHandler(ApplicationContext context,UserManager<AppUser> userManager)
{
    public async Task Handle(CreateUserRegisterCommand command)
    {
        var user = new AppUser
        {
            UserName = command.Email,
            Email = command.Email,
            Name = command.Name,
            Surname = command.Surname
        };
        await userManager.AddPasswordAsync(user, command.Password);
        await context.Users.AddAsync(user);
        await context.SaveChangesAsync();
        
    }
    
    
}
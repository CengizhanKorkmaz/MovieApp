using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Application.Features.CQRSDesignPatterns.Commands.UserRegisterCommands;
using MovieApp.Application.Features.CQRSDesignPatterns.Handlers.UserRegisterHandlers;

namespace MovieApp.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserRegisterController(CreateUserRegisterCommandHandler createUserRegisterCommandHandler):ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateUserRegisterCommand command)
    {
        await createUserRegisterCommandHandler.Handle(command);
        return Ok();
    }
    
}
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using MovieApp.Application.Features.MediatorDesignPattern.Handlers.CastHandlers;
using MovieApp.Application.Features.MediatorDesignPattern.Queries.CastQueries;

namespace MovieApp.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CastController(IMediator mediator):ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var data = await mediator.Send(new GetCastQuery());
        return Ok(data);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var data = await mediator.Send(new GetCastByIdQuery(id));
        return Ok(data);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCastCommand command)
    {
        await mediator.Send(command);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateCastCommand command)
    {
        await mediator.Send(command);
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        await mediator.Send(new DeleteCastCommand(id));
        return Ok();
        
    }
    
    
}
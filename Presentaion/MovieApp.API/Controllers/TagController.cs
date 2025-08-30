using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Application.Features.MediatorDesignPattern.Commands.TagCommands;
using MovieApp.Application.Features.MediatorDesignPattern.Queries.TagQueries;

namespace MovieApp.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TagController(IMediator mediator):ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var data = await mediator.Send(new GetTagQuery());
        return Ok(data);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var data = await mediator.Send(new GetTagQueryByIdQuery(id));
        return Ok(data);
    }


    [HttpPost]
    public async Task<IActionResult> Create(CreateTagCommand command)
    {
        await mediator.Send(command);
        return Ok();
    }

 
    [HttpPut]
    public async Task<IActionResult> Update(UpdateTagCommand command)
    {
        await mediator.Send(command);
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        await mediator.Send(new DeleteTagCommand(id));
        return Ok();
    }
}
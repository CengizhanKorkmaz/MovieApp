using Microsoft.AspNetCore.Mvc;
using MovieApp.Application.Features.CQRSDesignPatterns.Commands.MovieCommands;
using MovieApp.Application.Features.CQRSDesignPatterns.Handlers.MovieHandlers;
using MovieApp.Application.Features.CQRSDesignPatterns.Queries.MovieQueries;

namespace MovieApp.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MovieController(
        GetMovieQueryHandler getMovieQueryHandler,
        GetMovieByIdQueryHandler getMovieByIdQueryHandler,
        UpdateMovieCommandHandler updateMovieCommandHandler,
        DeleteMovieCommandHandler deleteMovieCommandHandler,
        CreateMovieCommandHandler createMovieCommandHandler
    ):ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var movies = await getMovieQueryHandler.Handle();
        return Ok(movies);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var movie = await getMovieByIdQueryHandler.Handle(new GetMovieByIdQuery(id));
        if (movie == null) return NotFound();
        return Ok(movie);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateMovieCommand command)
    {
        await createMovieCommandHandler.Handle(command);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateMovieCommand command)
    {
        await updateMovieCommandHandler.Handle(command);
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        await deleteMovieCommandHandler.Handle(new DeleteMovieCommand(id));
        return Ok();
    }
}
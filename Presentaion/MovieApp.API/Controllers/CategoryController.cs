using Microsoft.AspNetCore.Mvc;
using MovieApp.Application.Features.CQRSDesignPatterns.Commands.CategoryCommands;
using MovieApp.Application.Features.CQRSDesignPatterns.Handlers.CategoryHandlers;
using MovieApp.Application.Features.CQRSDesignPatterns.Queries.CategoryQueries;

namespace MovieApp.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController(
    GetCategoryQueryHandler getCategoryQueryHandler,
    GetCategoryByIdQueryHandler getCategoryByIdQueryHandler,
    UpdateCategoryCommandHandler updateCategoryCommandHandler,
    DeleteCategoryCommandHandler deleteCategoryCommandHandler,
    CreateCategoryCommandHandler createCategoryCommandHandler
) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var categories = await getCategoryQueryHandler.Handle();
        return Ok(categories);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var category = await getCategoryByIdQueryHandler.Handle(new GetCategoryByIdQuery(id));
        if (category == null) return NotFound();
        return Ok(category);

    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCategoryCommand command)
    {
       await createCategoryCommandHandler.Handle(command);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateCategoryCommand command)
    {
        await updateCategoryCommandHandler.Handle(command);
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        await deleteCategoryCommandHandler.Handle(new DeleteCategoryCommand(id));
        return Ok();
        
    }
}
    
using MovieApp.Application.Features.CQRSDesignPatterns.Handlers.CategoryHandlers;
using MovieApp.Application.Features.CQRSDesignPatterns.Handlers.MovieHandlers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<GetCategoryQueryHandler>();
builder.Services.AddScoped<GetCategoryByIdQueryHandler>();
builder.Services.AddScoped<UpdateCategoryCommandHandler>();
builder.Services.AddScoped<DeleteCategoryCommandHandler>();
builder.Services.AddScoped<CreateCategoryCommandHandler>();

builder.Services.AddScoped<GetMovieQueryHandler>();
builder.Services.AddScoped<GetMovieByIdQueryHandler>();
builder.Services.AddScoped<UpdateMovieCommandHandler>();
builder.Services.AddScoped<DeleteMovieCommandHandler>();
builder.Services.AddScoped<CreateMovieCommandHandler>();


builder.Services.AddControllers();
var app = builder.Build();

// C.Services.onfigure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();

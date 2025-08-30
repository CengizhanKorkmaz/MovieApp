using System.Reflection;
using Microsoft.OpenApi.Models;
using MovieApp.Application.Features.CQRSDesignPatterns.Handlers.CategoryHandlers;
using MovieApp.Application.Features.CQRSDesignPatterns.Handlers.MovieHandlers;
using MovieApp.Application.Features.MediatorDesignPattern.Handlers.TagHandlers;
using MovieApp.Persistence.Data.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddDbContext<ApplicationContext>();
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

//builder.Services.AddMediatR(cfg=>cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetTagQueryHandler).Assembly));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x => { x.SwaggerDoc("v1", new OpenApiInfo { Title = "MovieApp API", Version = "v1" }); });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(x => { 
        x.SwaggerEndpoint("/swagger/v1/swagger.json", "MovieApp API v1");
        x.RoutePrefix = string.Empty; // Swagger UI'ı root'ta göster
    });
}

app.UseHttpsRedirection();

// Routing middleware'leri ekle
app.UseRouting();

// Controller endpoint'lerini ekle
app.MapControllers();

app.Run();
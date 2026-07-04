using DotaInsight.Application.Features.Heroes;
using DotaInsight.Application.IRepositories;
using DotaInsight.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<IHeroService, HeroService>();
builder.Services.AddScoped<IHeroRepository, HeroRepository>();

var app = builder.Build();

app.MapControllers();

app.Run();

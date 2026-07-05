using DotaInsight.Application.IRepositories;
using DotaInsight.Domain.Entities;
using DotaInsight.Domain.Shared;
using DotaInsight.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DotaInsight.Infrastructure.Repositories;

public class HeroRepository : IHeroRepository
{
    
    private readonly AppDbContext _context;

    public HeroRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<Result<List<Hero>>> GetAllAsync()
    {
        var heroes = await _context.Heroes
            .AsNoTracking()
            .ToListAsync();
        
        return Result<List<Hero>>.Success(heroes);
    }
}
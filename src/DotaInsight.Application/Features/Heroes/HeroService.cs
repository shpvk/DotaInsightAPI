using DotaInsight.Application.DTOs;
using DotaInsight.Application.IRepositories;
using DotaInsight.Application.Mappers;
using DotaInsight.Domain.Entities;
using DotaInsight.Domain.Shared;

namespace DotaInsight.Application.Features.Heroes;

public class HeroService : IHeroService
{
    private readonly IHeroRepository _heroRepository;

    public HeroService(IHeroRepository heroRepository)
    {
        _heroRepository = heroRepository;
    }
    
    public async Task<Result<List<HeroResponse>>> GetAllAsync()
    {
        var receivedHeroes = await _heroRepository.GetAllAsync();
        if (receivedHeroes.IsFailure)
        {
            return Result<List<HeroResponse>>.Failure(receivedHeroes.Error);
        }

        var heroes = receivedHeroes.Value;

        List<HeroResponse> heroesDto = new List<HeroResponse>();
        
        foreach (Hero hero in heroes)
        {
            HeroResponse heroDto = new HeroResponse
            {
                Id = hero.Id,
                Name = hero.Name
            };
            
            heroesDto.Add(heroDto);
        }
    
        return Result<List<HeroResponse>>.Success(heroesDto);
        
    }
}
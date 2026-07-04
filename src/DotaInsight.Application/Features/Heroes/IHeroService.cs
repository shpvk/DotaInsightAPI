using DotaInsight.Application.DTOs;
using DotaInsight.Domain.Entities;
using DotaInsight.Domain.Shared;

namespace DotaInsight.Application.Features.Heroes;

public interface IHeroService
{
    Task<Result<List<HeroResponse>>> GetAllAsync();
}
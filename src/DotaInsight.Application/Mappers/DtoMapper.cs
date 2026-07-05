using DotaInsight.Application.DTOs;
using DotaInsight.Domain.Entities;

namespace DotaInsight.Application.Mappers;

internal static class DtoMapper
{
    public static HeroResponse ToResponse(this Hero hero)
    {
        return new HeroResponse
        {
            Id = hero.Id,
            Name = hero.Name
        };
    }
}
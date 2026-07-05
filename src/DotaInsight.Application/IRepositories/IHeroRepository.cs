using DotaInsight.Domain.Entities;
using DotaInsight.Domain.Shared;

namespace DotaInsight.Application.IRepositories;

public interface IHeroRepository
{ 
    Task<Result<List<Hero>>> GetAllAsync();
}
using DotaInsight.Application.Features.Heroes;
using Microsoft.AspNetCore.Mvc;

namespace DotaInsight.API.Controllers;

[ApiController]
[Route("api/heroes")]
public sealed class HeroesController : ControllerBase
{
    private readonly IHeroService _heroService;

    public HeroesController(IHeroService heroService)
    {
        _heroService = heroService;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetHeroes()
    {
        var receivedResult = await _heroService.GetAllAsync();

        if (receivedResult.IsFailure)
        {
            return Problem(
                title: "Failed to get heroes",
                detail: receivedResult.Error,
                statusCode: 500);
        }
        var result = receivedResult.Value;
        return Ok(result);
    }

    [HttpGet("{heroId:int}/counters")]
    public async Task<IActionResult> GetCounters(int heroId, [FromQuery] int limit = 10)
    {
        return NotImplemented("Hero counter recommendations endpoint is not implemented yet.");
    }

    [HttpGet("{heroId:int}/synergies")]
    public async Task<IActionResult> GetSynergies(int heroId, [FromQuery] int limit = 10)
    {
        return NotImplemented("Hero synergy recommendations endpoint is not implemented yet.");
    }

    private ObjectResult NotImplemented(string detail)
    {
        return Problem(
            title: "Not implemented",
            detail: detail,
            statusCode: StatusCodes.Status501NotImplemented);
    }
}

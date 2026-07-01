using Microsoft.AspNetCore.Mvc;

namespace DotaInsight.API.Controllers;

[ApiController]
[Route("api/heroes")]
public sealed class HeroesController : ControllerBase
{
    [HttpGet]
    public IActionResult GetHeroes()
    {
        return NotImplemented("Hero catalog endpoint is not implemented yet.");
    }

    [HttpGet("{heroId:int}/counters")]
    public IActionResult GetCounters(int heroId, [FromQuery] int limit = 10)
    {
        return NotImplemented("Hero counter recommendations endpoint is not implemented yet.");
    }

    [HttpGet("{heroId:int}/synergies")]
    public IActionResult GetSynergies(int heroId, [FromQuery] int limit = 10)
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

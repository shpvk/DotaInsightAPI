using Microsoft.AspNetCore.Mvc;

namespace DotaInsight.API.Controllers;

[ApiController]
[Route("api/import/matches")]
public sealed class ImportMatchesController : ControllerBase
{
    [HttpPost("run")]
    public IActionResult Run()
    {
        return Problem(
            title: "Not implemented",
            detail: "Manual match import endpoint is not implemented yet.",
            statusCode: StatusCodes.Status501NotImplemented);
    }
}

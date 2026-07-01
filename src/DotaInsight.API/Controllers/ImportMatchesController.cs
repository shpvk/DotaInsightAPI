using Microsoft.AspNetCore.Mvc;

namespace DotaInsight.API.Controllers;

[ApiController]
[Route("api/import/matches")]
public sealed class ImportMatchesController : ControllerBase
{
    [HttpPost("run")]
    public IActionResult Run()
    {
        return NotImplemented("Manual match import endpoint is not implemented yet.");
    }

    private ObjectResult NotImplemented(string detail)
    {
        return Problem(
            title: "Not implemented",
            detail: detail,
            statusCode: StatusCodes.Status501NotImplemented);
    }
}

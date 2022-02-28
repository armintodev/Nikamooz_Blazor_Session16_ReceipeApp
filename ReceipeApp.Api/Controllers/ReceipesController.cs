using Microsoft.AspNetCore.Mvc;

using ReceipeApp.Shared;

namespace ReceipeApp.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReceipesController : ControllerBase
{
    public IActionResult Post(Receipe receipe)
    {
        return Ok();
    }
}

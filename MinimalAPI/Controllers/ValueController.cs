using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MinimalAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class ValueController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await Task.FromResult(Guid.CreateVersion7()));
    }
}


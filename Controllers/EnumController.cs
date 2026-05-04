using Microsoft.AspNetCore.Mvc;

namespace CaseMatters.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EnumController : ControllerBase
{
    // Route parameter
    [HttpGet("{status}/details")]
    public IActionResult GetByRoute(Status status) => Ok(status);

    // Query parameter
    [HttpGet("query")]
    public IActionResult GetByQuery([FromQuery] Status status) => Ok(status);

    // Header parameter
    [HttpGet("header")]
    public IActionResult GetByHeader([FromHeader(Name = "X-Status")] Status status) => Ok(status);

    // Form parameter
    [HttpPost("form")]
    public IActionResult PostByForm([FromForm] Status status) => Ok(status);

    // JSON body parameter
    [HttpPost("body")]
    public IActionResult PostByBody([FromBody] StatusRequest request) => Ok(request);
}

using Microsoft.AspNetCore.Mvc;

namespace CaseMatters.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ParamNamesController : ControllerBase
{
    // String query parameter (for testing parameter name casing)
    [HttpGet("string-query")]
    public IActionResult GetStringByQuery([FromQuery] string name) => Ok(name);

    // String form parameter (for testing parameter name casing)
    [HttpPost("string-form")]
    public IActionResult PostStringByForm([FromForm] string name) => Ok(name);
}

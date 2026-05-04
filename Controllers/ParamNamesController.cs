using Microsoft.AspNetCore.Mvc;

namespace CaseMatters.Controllers;

// for testing parameter name casing
[ApiController]
[Route("api/[controller]")]
public class ParamNamesController : ControllerBase
{
    // Query parameter
    [HttpGet("query-param")]
    public IActionResult GetStringByQuery([FromQuery] string name) => Ok(name);

    // Form parameter
    [HttpPost("form-param")]
    public IActionResult PostStringByForm([FromForm] string name) => Ok(name);

    // Path parameter
    [HttpGet("items/{id}")]
    public IActionResult GetItemById([FromRoute] int ID) => Ok(ID);
}

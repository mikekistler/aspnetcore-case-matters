using Microsoft.AspNetCore.Mvc;

public static class ParamNamesEndpoints
{
    public static void MapParamNamesEndpoints(this WebApplication app)
    {
        // String query parameter (for testing parameter name casing)
        app.MapGet("/string-query", ([FromQuery] string name) => Results.Ok(name));

        // String form parameter (for testing parameter name casing)
        app.MapPost("/string-form", ([FromForm] string name) => Results.Ok(name))
            .DisableAntiforgery();
    }
}

using Microsoft.AspNetCore.Mvc;

// for testing parameter name casing
public static class ParamNamesEndpoints
{
    public static void MapParamNamesEndpoints(this WebApplication app)
    {
        // Query parameter
        app.MapGet("/query-param", ([FromQuery] string name) => Results.Ok(name));

        // Form parameter
        app.MapPost("/form-param", ([FromForm] string name) => Results.Ok(name))
            .DisableAntiforgery();

        // Path parameter
        app.MapGet("/path-param/{Name}", ([FromRoute] string name) => Results.Ok(name));

        // Copilot said that this would fail -- does it?
        app.MapGet("/items/{id}", (int ID) => Results.Ok(ID)); // ❌ binding mismatch
    }
}

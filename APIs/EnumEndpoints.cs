using Microsoft.AspNetCore.Mvc;

public static class EnumEndpoints
{
    public static void MapEnumEndpoints(this WebApplication app)
    {
        // Issue: enum route parameters are parsed case-sensitively,
        // even though the rest of the routing stack is case-insensitive.
        // e.g. /hello/None/world -> 200 OK
        //      /hello/none/world -> 400 Bad Request (unexpected!)

        // Route parameter
        app.MapGet("hello/{status}/world", (Status status) => Results.Ok(status));

        // Query parameter
        app.MapGet("/query", ([FromQuery] Status status) => Results.Ok(status));

        // Header parameter
        app.MapGet("/header", ([FromHeader(Name = "X-Status")] Status status) => Results.Ok(status));

        // Form parameter
        app.MapPost("/form", ([FromForm] Status status) => Results.Ok(status))
            .DisableAntiforgery();

        // JSON body parameter
        app.MapPost("/body", (StatusRequest request) => Results.Ok(request))
            .DisableAntiforgery();
    }
}

# aspnetcore-case-matters

A project to explore case sensitivity in ASP.NET Core APIs.

## Enum binding

### Minimal APIs

- Enum values for route, query, header, and form parameters are parsed case-sensitively.
- Query and form parameter names are matched case-insensitively.
- Enum values in JSON body payloads are parsed case-insensitively when using the `JsonStringEnumConverter`.

### Controllers

- Enum values for route, query, header, and form parameters are parsed case-insensitively in controller action parameters.
- Query and form parameter names are matched case-insensitively.
- Enum values in JSON body payloads are parsed case-insensitively when using the `JsonStringEnumConverter`.

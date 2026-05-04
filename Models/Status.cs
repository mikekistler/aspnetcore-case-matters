using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Status
{
    None,
    Active,
    Inactive
}

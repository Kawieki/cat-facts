using System.Text.Json.Serialization;

namespace CatFacts.DTOs;

public class Fact
{
    [JsonPropertyName("fact")]
    public string Description { get; set; } = null!;
    
    [JsonPropertyName("length")]
    public int Length { get; set; }
}
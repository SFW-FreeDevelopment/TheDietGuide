using System.Text.Json.Serialization;

namespace TheDietGuide.ThirdParty.APIs.Spoonacular.Models;

public class RecipeSearchResults
{
    [JsonPropertyName("results")]
    public List<Result> Results { get; set; }

    [JsonPropertyName("offset")]
    public int Offset { get; set; }

    [JsonPropertyName("number")]
    public int Number { get; set; }

    [JsonPropertyName("totalResults")]
    public int TotalResults { get; set; }
}

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public class Result
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("image")]
    public string Image { get; set; }

    [JsonPropertyName("imageType")]
    public string ImageType { get; set; }
}


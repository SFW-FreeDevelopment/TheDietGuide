using System.Text.Json.Serialization;

namespace TheDietGuide.ThirdParty.APIs.Spoonacular.Models;

public class RecipeNutrition
{
    [JsonPropertyName("calories")]
    public string Calories { get; set; }

    [JsonPropertyName("carbs")]
    public string Carbs { get; set; }

    [JsonPropertyName("fat")]
    public string Fat { get; set; }

    [JsonPropertyName("protein")]
    public string Protein { get; set; }

    [JsonPropertyName("bad")]
    public List<Bad> Bad { get; set; }

    [JsonPropertyName("good")]
    public List<Good> Good { get; set; }

    [JsonPropertyName("expires")]
    public long Expires { get; set; }

    [JsonPropertyName("isStale")]
    public bool IsStale { get; set; }
}

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public class Bad
{
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("amount")]
    public string Amount { get; set; }

    [JsonPropertyName("indented")]
    public bool Indented { get; set; }

    [JsonPropertyName("percentOfDailyNeeds")]
    public double PercentOfDailyNeeds { get; set; }
}

public class Good
{
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("amount")]
    public string Amount { get; set; }

    [JsonPropertyName("indented")]
    public bool Indented { get; set; }

    [JsonPropertyName("percentOfDailyNeeds")]
    public double PercentOfDailyNeeds { get; set; }
}
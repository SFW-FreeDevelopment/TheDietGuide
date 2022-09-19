using System.Text.Json.Serialization;

namespace TheDietGuide.ThirdParty.APIs.Spoonacular.Models;

public class RecipeIngredients
{
    [JsonPropertyName("ingredients")]
    public List<Ingredient> Ingredients { get; set; }  
}

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public class IngredientAmount
{
    [JsonPropertyName("metric")]
    public IngredientMetric Metric { get; set; }

    [JsonPropertyName("us")]
    public IngredientUs Us { get; set; }
}

public class Ingredient
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("image")]
    public string Image { get; set; }

    [JsonPropertyName("amount")]
    public IngredientAmount Amount { get; set; }
}

public class IngredientMetric
{
    [JsonPropertyName("value")]
    public double Value { get; set; }

    [JsonPropertyName("unit")]
    public string Unit { get; set; }
}

public class IngredientUs
{
    [JsonPropertyName("value")]
    public double Value { get; set; }

    [JsonPropertyName("unit")]
    public string Unit { get; set; }
}


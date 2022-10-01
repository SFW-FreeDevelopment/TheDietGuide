using System.Text.Json.Serialization;

namespace TheDietGuide.ThirdParty.APIs.Spoonacular.Models;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

public class RecipeSearchByIngredientsResults
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("image")]
    public string Image { get; set; }

    [JsonPropertyName("imageType")]
    public string ImageType { get; set; }

    [JsonPropertyName("usedIngredientCount")]
    public int UsedIngredientCount { get; set; }

    [JsonPropertyName("missedIngredientCount")]
    public int MissedIngredientCount { get; set; }

    [JsonPropertyName("missedIngredients")]
    public List<MissedIngredient> MissedIngredients { get; set; }

    [JsonPropertyName("usedIngredients")]
    public List<UsedIngredient> UsedIngredients { get; set; }

    [JsonPropertyName("unusedIngredients")]
    public List<object> UnusedIngredients { get; set; }

    [JsonPropertyName("likes")]
    public int Likes { get; set; }
}

    public class MissedIngredient
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("amount")]
        public double Amount { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("unitLong")]
        public string UnitLong { get; set; }

        [JsonPropertyName("unitShort")]
        public string UnitShort { get; set; }

        [JsonPropertyName("aisle")]
        public string Aisle { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("original")]
        public string Original { get; set; }

        [JsonPropertyName("originalName")]
        public string OriginalName { get; set; }

        [JsonPropertyName("meta")]
        public List<string> Meta { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }
    }

    public class UsedIngredient
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("amount")]
        public double Amount { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("unitLong")]
        public string UnitLong { get; set; }

        [JsonPropertyName("unitShort")]
        public string UnitShort { get; set; }

        [JsonPropertyName("aisle")]
        public string Aisle { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("original")]
        public string Original { get; set; }

        [JsonPropertyName("originalName")]
        public string OriginalName { get; set; }

        [JsonPropertyName("meta")]
        public List<string> Meta { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }
    }


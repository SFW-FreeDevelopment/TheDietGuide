using System.Text.Json.Serialization;

namespace TheDietGuide.ThirdParty.APIs.Spoonacular.Models;

public class RecipeInformation
{
        [JsonPropertyName("vegetarian")]
        public bool Vegetarian { get; set; }

        [JsonPropertyName("vegan")]
        public bool Vegan { get; set; }

        [JsonPropertyName("glutenFree")]
        public bool GlutenFree { get; set; }

        [JsonPropertyName("dairyFree")]
        public bool DairyFree { get; set; }

        [JsonPropertyName("veryHealthy")]
        public bool VeryHealthy { get; set; }

        [JsonPropertyName("cheap")]
        public bool Cheap { get; set; }

        [JsonPropertyName("veryPopular")]
        public bool VeryPopular { get; set; }

        [JsonPropertyName("sustainable")]
        public bool Sustainable { get; set; }

        [JsonPropertyName("lowFodmap")]
        public bool LowFodmap { get; set; }

        [JsonPropertyName("weightWatcherSmartPoints")]
        public int WeightWatcherSmartPoints { get; set; }

        [JsonPropertyName("gaps")]
        public string Gaps { get; set; }

        [JsonPropertyName("preparationMinutes")]
        public int PreparationMinutes { get; set; }

        [JsonPropertyName("cookingMinutes")]
        public int CookingMinutes { get; set; }

        [JsonPropertyName("aggregateLikes")]
        public int AggregateLikes { get; set; }

        [JsonPropertyName("healthScore")]
        public int HealthScore { get; set; }

        [JsonPropertyName("creditsText")]
        public string CreditsText { get; set; }

        [JsonPropertyName("license")]
        public string License { get; set; }

        [JsonPropertyName("sourceName")]
        public string SourceName { get; set; }

        [JsonPropertyName("pricePerServing")]
        public double PricePerServing { get; set; }

        [JsonPropertyName("extendedIngredients")]
        public List<ExtendedIngredient> ExtendedIngredients { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("readyInMinutes")]
        public int ReadyInMinutes { get; set; }

        [JsonPropertyName("servings")]
        public int Servings { get; set; }

        [JsonPropertyName("sourceUrl")]
        public string SourceUrl { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("imageType")]
        public string ImageType { get; set; }

        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        [JsonPropertyName("cuisines")]
        public List<string> Cuisines { get; set; }

        [JsonPropertyName("dishTypes")]
        public List<string> DishTypes { get; set; }

        [JsonPropertyName("diets")]
        public List<string> Diets { get; set; }

        [JsonPropertyName("occasions")]
        public List<object> Occasions { get; set; }

        [JsonPropertyName("winePairing")]
        public WinePairing WinePairing { get; set; }

        [JsonPropertyName("instructions")]
        public string Instructions { get; set; }

        [JsonPropertyName("analyzedInstructions")]
        public List<AnalyzedInstruction> AnalyzedInstructions { get; set; }

        [JsonPropertyName("originalId")]
        public object OriginalId { get; set; }

        [JsonPropertyName("spoonacularSourceUrl")]
        public string SpoonacularSourceUrl { get; set; }
}

public class AnalyzedInstruction
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("steps")]
        public List<Step> Steps { get; set; }
    }

    public class Equipment
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("localizedName")]
        public string LocalizedName { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }
    }

    public class ExtendedIngredient
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("aisle")]
        public string Aisle { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("consistency")]
        public string Consistency { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("nameClean")]
        public string NameClean { get; set; }

        [JsonPropertyName("original")]
        public string Original { get; set; }

        [JsonPropertyName("originalName")]
        public string OriginalName { get; set; }

        [JsonPropertyName("amount")]
        public double Amount { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("meta")]
        public List<string> Meta { get; set; }

        [JsonPropertyName("measures")]
        public Measures Measures { get; set; }
    }

    public class RecipeIngredient
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("localizedName")]
        public string LocalizedName { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }
    }

    public class Length
    {
        [JsonPropertyName("number")]
        public int Number { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class Measures
    {
        [JsonPropertyName("us")]
        public RecipeUs Us { get; set; }

        [JsonPropertyName("metric")]
        public RecipeMetric Metric { get; set; }
    }

    public class RecipeMetric
    {
        [JsonPropertyName("amount")]
        public double Amount { get; set; }

        [JsonPropertyName("unitShort")]
        public string UnitShort { get; set; }

        [JsonPropertyName("unitLong")]
        public string UnitLong { get; set; }
    }

    public class ProductMatch
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("price")]
        public string Price { get; set; }

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("averageRating")]
        public double AverageRating { get; set; }

        [JsonPropertyName("ratingCount")]
        public double RatingCount { get; set; }

        [JsonPropertyName("score")]
        public double Score { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }
    }

    public class Step
    {
        [JsonPropertyName("number")]
        public int Number { get; set; }

        [JsonPropertyName("step")]
        public string StepDescription { get; set; }

        [JsonPropertyName("ingredients")]
        public List<Ingredient> Ingredients { get; set; }

        [JsonPropertyName("equipment")]
        public List<Equipment> Equipment { get; set; }

        [JsonPropertyName("length")]
        public Length Length { get; set; }
    }

    public class RecipeUs
    {
        [JsonPropertyName("amount")]
        public double Amount { get; set; }

        [JsonPropertyName("unitShort")]
        public string UnitShort { get; set; }

        [JsonPropertyName("unitLong")]
        public string UnitLong { get; set; }
    }

    public class WinePairing
    {
        [JsonPropertyName("pairedWines")]
        public List<string> PairedWines { get; set; }

        [JsonPropertyName("pairingText")]
        public string PairingText { get; set; }

        [JsonPropertyName("productMatches")]
        public List<ProductMatch> ProductMatches { get; set; }
    }

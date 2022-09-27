using System.Text.Json.Serialization;

namespace TheDietGuide.ThirdParty.APIs.Spoonacular.Models;

// Root myDeserializedClass = JsonSerializer.Deserialize<List<Root>>(myJsonResponse);
    public class RecipeSearchByNutrients
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("imageType")]
        public string ImageType { get; set; }

        [JsonPropertyName("calories")]
        public int Calories { get; set; }

        [JsonPropertyName("protein")]
        public string Protein { get; set; }

        [JsonPropertyName("fat")]
        public string Fat { get; set; }

        [JsonPropertyName("carbs")]
        public string Carbs { get; set; }

        [JsonPropertyName("alcohol")]
        public string Alcohol { get; set; }

        [JsonPropertyName("caffeine")]
        public string Caffeine { get; set; }

        [JsonPropertyName("copper")]
        public string Copper { get; set; }

        [JsonPropertyName("vitaminA")]
        public string VitaminA { get; set; }

        [JsonPropertyName("vitaminC")]
        public string VitaminC { get; set; }

        [JsonPropertyName("vitaminD")]
        public string VitaminD { get; set; }

        [JsonPropertyName("vitaminE")]
        public string VitaminE { get; set; }

        [JsonPropertyName("vitaminK")]
        public string VitaminK { get; set; }

        [JsonPropertyName("vitaminB1")]
        public string VitaminB1 { get; set; }

        [JsonPropertyName("vitaminB2")]
        public string VitaminB2 { get; set; }

        [JsonPropertyName("vitaminB3")]
        public string VitaminB3 { get; set; }

        [JsonPropertyName("vitaminB5")]
        public string VitaminB5 { get; set; }

        [JsonPropertyName("vitaminB6")]
        public string VitaminB6 { get; set; }

        [JsonPropertyName("vitaminB12")]
        public string VitaminB12 { get; set; }

        [JsonPropertyName("fiber")]
        public string Fiber { get; set; }

        [JsonPropertyName("folate")]
        public string Folate { get; set; }

        [JsonPropertyName("iron")]
        public string Iron { get; set; }

        [JsonPropertyName("magnesium")]
        public string Magnesium { get; set; }

        [JsonPropertyName("manganese")]
        public string Manganese { get; set; }

        [JsonPropertyName("sodium")]
        public string Sodium { get; set; }
    }


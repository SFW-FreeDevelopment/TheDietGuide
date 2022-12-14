using TheDietGuide.ThirdParty.APIs.Spoonacular;
using TheDietGuide.ThirdParty.APIs.Spoonacular.Models;

namespace TheDietGuide.Web.Services;

public class RecipeService
{
    private readonly SpoonacularApiClient _spoonacularApiClient;

    public RecipeService(SpoonacularApiClient spoonacularApiClient)
    {
        _spoonacularApiClient = spoonacularApiClient;
    }

    public async Task<RecipeSearch> SearchRecipes(string queryParameter)
    {
        return await _spoonacularApiClient.SearchRecipes(queryParameter);
    }
    
    public async Task<RecipeInformation> GetRecipeInformation(int id)
    {
        return await _spoonacularApiClient.GetRecipeInformation(id);
    }
    
    public async Task<RecipeIngredients> GetRecipeIngredients(int id)
    {
        return await _spoonacularApiClient.GetRecipeIngredients(id);
    }
    
    public async Task<RecipeNutrition> GetRecipeNutrients(int id)
    {
        return await _spoonacularApiClient.GetRecipeNutrients(id);
    }
    
    public async Task<List<RecipeSearchByIngredientsResults>> SearchRecipesByIngredients(Dictionary<string, string> queryParameters)
    {
        return await _spoonacularApiClient.SearchRecipesByIngredients(queryParameters);
    }
    
    public async Task<List<RecipeSearchByNutrients>> SearchRecipesByNutrients(Dictionary<string, string> queryParameters)
    {
        return await _spoonacularApiClient.SearchRecipesByNutrients(queryParameters);
    }
}
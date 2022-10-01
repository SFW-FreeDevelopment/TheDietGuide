using Microsoft.AspNetCore.Mvc;
using TheDietGuide.ThirdParty.APIs.Spoonacular.Models;
using TheDietGuide.Web.Services;

namespace TheDietGuide.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class RecipeController : ControllerBase
{
    private readonly RecipeService _recipeService;

    public RecipeController(RecipeService recipeService)
    {
        _recipeService = recipeService;
    }

    [HttpGet("{id:int}")]
    public async Task<RecipeInformation> Get([FromRoute] int id)
    {
        return await _recipeService.GetRecipeInformation(id);
    }
    
    [HttpGet("{id:int}/ingredients")]
    public async Task<RecipeIngredients> GetIngredients([FromRoute] int id)
    {
        return await _recipeService.GetRecipeIngredients(id);
    }
    
    [HttpGet("{id:int}/nutrients")]
    public async Task<RecipeNutrition> GetNutrients([FromRoute] int id)
    {
        return await _recipeService.GetRecipeNutrients(id);
    }
    
    [HttpGet("search")]
    public async Task<RecipeSearch> Search([FromQuery] string queryParameter)
    {
        return await _recipeService.SearchRecipes(queryParameter);
    }
    
    [HttpGet("search/ingredients")]
    public async Task<List<RecipeSearchByIngredientsResults>> SearchByIngredients([FromQuery] Dictionary<string, string> queryParameters)
    {
        return await _recipeService.SearchRecipesByIngredients(queryParameters);
    }
    
    [HttpGet("search/nutrients")]
    public async Task<List<RecipeSearchByNutrients>> SearchByNutrients([FromQuery] Dictionary<string, string> queryParameters)
    {
        return await _recipeService.SearchRecipesByNutrients(queryParameters);
    }
}
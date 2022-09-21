﻿using Microsoft.Extensions.Configuration;
using RestSharp;

namespace TheDietGuide.ThirdParty.APIs.Spoonacular.Models;

public class SpoonacularApiClient
{
    private readonly string _apiKey;
    private readonly string _baseUrl = "https://api.spoonacular.com/";
    private readonly RestClient _client;

    #region ResourceRoutes

    private const string GetRecipeSearchResultsRoute = "recipes/complexSearch";
    private const string GetRecipeInformationRoute = "recipes/{id}/information";
    private const string GetRecipeIngredientsRoute = "recipes/{id}/ingredientWidget.json";
    private const string GetRecipeNutrientsRoute = "recipes/{id}/nutritionWidget.json";
    private const string GetRecipeIngredientsFindByRoute = "recipes/findByIngredients";
    private const string GetRecipeNutrientsFindByRoute = "recipes/findByNutrients";

    #endregion
    
    public SpoonacularApiClient(IConfiguration configuration)
    {
        _apiKey = configuration["SpoonacularApiKey"];
        _client = new RestClient(_baseUrl);
    }

    public async Task<RecipeSearchResults> GetRecipeSearchResults(Dictionary<string, string> queryParameters)
    {
        var request = new RestRequest(GetRecipeSearchResultsRoute);
        request.AddHeader("x-api-key", _apiKey);
        foreach (var queryParameter in queryParameters)
        {
            request.AddQueryParameter(queryParameter.Key, queryParameter.Value);
        }
        var response = await _client.ExecuteAsync<RecipeSearchResults>(request);
        return response.IsSuccessful ? response.Data : null;
    }
    
    public async Task<RecipeInformation> GetRecipeInformation(int id)
    {
        var request = new RestRequest(GetRecipeInformationRoute);
        request.AddHeader("x-api-key", _apiKey);
        request.AddUrlSegment("id", id.ToString());
        var response = await _client.ExecuteAsync<RecipeInformation>(request);
        return response.IsSuccessful ? response.Data : null;
    }
    
    public async Task<RecipeIngredients> GetRecipeIngredients(int id)
    {
        var request = new RestRequest(GetRecipeIngredientsRoute);
        request.AddHeader("x-api-key", _apiKey);
        request.AddUrlSegment("id", id.ToString());
        var response = await _client.ExecuteAsync<RecipeIngredients>(request);
        return response.IsSuccessful ? response.Data : null;
    }
    
    public async Task<RecipeNutrition> GetRecipeNutrients(int id)
    {
        var request = new RestRequest(GetRecipeNutrientsRoute);
        request.AddHeader("x-api-key", _apiKey);
        request.AddUrlSegment("id", id.ToString());
        var response = await _client.ExecuteAsync<RecipeNutrition>(request);
        return response.IsSuccessful ? response.Data : null;
    }

    public async Task<RecipeIngredients> SearchRecipesByIngredients(Dictionary<string, string> queryParameters)
    {
        var request = new RestRequest(GetRecipeIngredientsFindByRoute);
        request.AddHeader("x-api-key", _apiKey);
        foreach (var queryParameter in queryParameters)
        {
            request.AddQueryParameter(queryParameter.Key, queryParameter.Value);
        }
        var response = await _client.ExecuteAsync<RecipeIngredients>(request);
        return response.IsSuccessful ? response.Data : null;
    }
    
    public async Task<RecipeNutrition> SearchRecipesByNutrients(Dictionary<string, string> queryParameters)
    {
        var request = new RestRequest(GetRecipeNutrientsFindByRoute);
        request.AddHeader("x-api-key", _apiKey);
        foreach (var queryParameter in queryParameters)
        {
            request.AddQueryParameter(queryParameter.Key, queryParameter.Value);
        }
        var response = await _client.ExecuteAsync<RecipeNutrition>(request);
        return response.IsSuccessful ? response.Data : null;
    }
}
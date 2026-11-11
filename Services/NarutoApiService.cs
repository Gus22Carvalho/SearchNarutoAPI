using System.Net.Http.Json;
using SearchNarutoAPI.Models;

namespace SearchNarutoAPI.Services;

public class NarutoApiService
{
    private readonly HttpClient _httpClient;
    private const string BaseUrl = "https://dattebayo-api.onrender.com/characters";

    public NarutoApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<CharacterResponse?> GetCharactersAsync(string? searchQuery = null)
    {
        var url = BaseUrl;
        
        // Se houver termo de busca, utiliza o parâmetro de query '?name=' suportado pela API
        if (!string.IsNullOrWhiteSpace(searchQuery))
        {
            url = $"{BaseUrl}?name={searchQuery}";
        }

        return await _httpClient.GetFromJsonAsync<CharacterResponse>(url);
    }
}
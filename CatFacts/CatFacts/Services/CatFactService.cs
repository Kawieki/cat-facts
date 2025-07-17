using System.Text.Json;
using CatFacts.DTOs;

namespace CatFacts;

public class CatFactService : ICatFactService
{
    private readonly HttpClient _httpClient;
    
    public CatFactService(HttpClient httpClient)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }
        
    public async Task<Fact> GetCatFactAsync()
    {
        try
        {
            var response = await _httpClient.GetAsync("https://catfact.ninja/fact");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Fact>(json) ?? throw new NullReferenceException("Deserialized fact is null.");
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Request error: {e.Message}");
            throw;
        }
        catch (JsonException e)
        {
            Console.WriteLine($"JSON parsing error: {e.Message}");
            throw;
        }
        catch (Exception e)
        {
            Console.WriteLine($"An unexpected error occurred: {e.Message}");
            throw;
        }
    }
}
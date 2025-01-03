using System.Net.Http.Json;

public class PlayerService
{
    private readonly HttpClient _httpClient;

    public PlayerService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Player>> GetRankingAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Player>>("http://localhost:5000/rankings");
    }
}

public class Player
{
    public int Rank {get ; set;}
    public string Name {get; set;}
    public string Club {get; set;}
    public double OverallScore {get; set;}
}
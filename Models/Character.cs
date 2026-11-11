using System.Text.Json.Serialization;

namespace SearchNarutoAPI.Models;

public class Character
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("images")]
    public List<string> Images { get; set; } = new();

    [JsonPropertyName("personal")]
    public PersonalInfo? Personal { get; set; }

    [JsonPropertyName("jutsu")]
    public List<string> Jutsu { get; set; } = new();

    [JsonPropertyName("rank")]
    public RankInfo? Rank { get; set; }
}

public class PersonalInfo
{
    [JsonPropertyName("clan")]
    public string? Clan { get; set; }
    
    // A propriedade affiliation pode retornar diferentes formatos (string ou array) na API.
    // Para simplificar a exibição conforme o requisito, usaremos primariamente o Clan.
}

public class RankInfo
{
    [JsonPropertyName("ninjaRank")]
    public Dictionary<string, string>? NinjaRank { get; set; }
}
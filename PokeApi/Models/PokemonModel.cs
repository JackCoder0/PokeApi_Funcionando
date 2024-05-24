using System;
using System.Text.Json.Serialization;

namespace PokeApi.Models;

public class PokemonModel
{
    [JsonPropertyName("name")]
    public string Nome { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }
}

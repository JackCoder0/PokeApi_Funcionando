using PokeApi.Dtos;
using System.Text.Json.Serialization;
using Type = PokeApi.Dtos.Type;

namespace PokeApi.Models;

public class PokemonModel
{
	[JsonPropertyName("name")]
	public string? Nome { get; set; }

	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("height")]
	public long Altura { get; set; }

	[JsonPropertyName("weight")]
	public long Peso { get; set; }

	[JsonPropertyName("sprites")]
	public Sprites? Sprites { get; set; }

	[JsonPropertyName("types")]
	public List<TypeElement>? Types { get; set; }

	[JsonIgnore]
	[JsonPropertyName("officialArtworkUrl")]
	public string? OfficialArtworkUrl { get; set; }
}
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace PokeApi.Dtos;

public class PokemonResponse
{
	public string? Nome { get; set; }
	public int Id { get; set; }
	public long Altura { get; set; }
	public long Peso { get; set; }

	[JsonPropertyName("types")]
	public List<TypeElement>? Types { get; set; }

	[JsonPropertyName("sprites")]
	public Sprites? Sprites { get; set; }

	[JsonIgnore]
	[JsonPropertyName("officialArtworkUrl")]
	public string? OfficialArtworkUrl { get; set; }
}

public class Sprites
{
	[JsonPropertyName("other")]
	public OtherSprites? Other { get; set; }
}

public class OtherSprites
{
	[JsonPropertyName("official-artwork")]
	public OfficialArtwork? OfficialArtwork { get; set; }
}

public class OfficialArtwork
{
	[JsonPropertyName("front_default")]
	public string? FrontDefault { get; set; }
}

public class TypeElement
{
	[JsonPropertyName("slot")]
	public long Slot { get; set; }

	[JsonPropertyName("type")]
	public Type? Type { get; set; }
}

public class Type
{
	[JsonPropertyName("name")]
	public string? Name { get; set; }

	[JsonPropertyName("url")]
	public Uri? Url { get; set; }
}
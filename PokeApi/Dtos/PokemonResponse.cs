using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace PokeApi.Dtos;

public class PokemonResponse
{
	public string? Nome { get; set; }
	public int Id { get; set; }
	public long Altura { get; set; }
	public long Peso { get; set; }

	[JsonPropertyName("sprites")]
	public Sprites Sprites { get; set; }

	[JsonPropertyName("officialArtworkUrl")]
	public string OfficialArtworkUrl { get; set; }
}

public class Sprites
{
	[JsonPropertyName("other")]
	public OtherSprites Other { get; set; }
}

public class OtherSprites
{
	[JsonPropertyName("official-artwork")]
	public OfficialArtwork OfficialArtwork { get; set; }
}

public class OfficialArtwork
{
	[JsonPropertyName("front_default")]
	public string? FrontDefault { get; set; }
}
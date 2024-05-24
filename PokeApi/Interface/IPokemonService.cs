using EstudosIntegracao.Dtos;
using PokeApi.Dtos;

namespace PokeApi.Interface;

public interface IPokemonService
{
    Task<ResponseGenerico<PokemonResponse>> BuscarPokemon(string name);
}

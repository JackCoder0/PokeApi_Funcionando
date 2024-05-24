using EstudosIntegracao.Dtos;
using PokeApi.Models;

namespace PokeApi.Interface;

public interface IPokemonApi
{
    Task<ResponseGenerico<PokemonModel>> BuscarPokemonNome(string name);
}

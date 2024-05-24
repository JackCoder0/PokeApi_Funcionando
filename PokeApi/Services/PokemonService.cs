using AutoMapper;
using EstudosIntegracao.Dtos;
using PokeApi.Dtos;
using PokeApi.Interface;
using System.Runtime.ConstrainedExecution;

namespace PokeApi.Services;

public class PokemonService : IPokemonService
{
    private readonly IMapper _mapper;
    private readonly IPokemonApi _pokemonApi;

    public PokemonService(IMapper mapper, IPokemonApi pokemonApi)
    {
        _mapper = mapper;
        _pokemonApi = pokemonApi;
    }

    public async Task<ResponseGenerico<PokemonResponse>> BuscarPokemon(string name)
    {
        var pokemon = await _pokemonApi.BuscarPokemonNome(name);
		return _mapper.Map<ResponseGenerico<PokemonResponse>>(pokemon);
    }
}
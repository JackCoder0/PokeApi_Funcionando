using AutoMapper;
using EstudosIntegracao.Dtos;
using PokeApi.Dtos;
using PokeApi.Models;

namespace PokeApi.Mappings;

public class PokemonMapping : Profile
{
    public PokemonMapping()
    {
        CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
        CreateMap<PokemonResponse, PokemonModel>();
        CreateMap<PokemonModel, PokemonResponse>();
    }
}

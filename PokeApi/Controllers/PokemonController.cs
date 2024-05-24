using Microsoft.AspNetCore.Mvc;
using PokeApi.Interface;
using System.Net;

namespace PokeApi.Controllers;

[ApiController]
public class PokemonController : ControllerBase
{
    public readonly IPokemonService _pokemonService;

    public PokemonController(IPokemonService pokemonService)
    {
        _pokemonService = pokemonService;
    }

    [HttpGet("buscar/pokemon/{name}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> BuscarPokemon([FromRoute] string name)
    {
        var response = await _pokemonService.BuscarPokemon(name);

        if (response.CodigoHttp == HttpStatusCode.OK)
        {
            return Ok(response.DadosRetorno);
        }
        else
        {
            return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
        }
    }
}

//Funcionando

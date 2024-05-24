using EstudosIntegracao.Dtos;
using PokeApi.Interface;
using PokeApi.Models;
using System.Dynamic;
using System.Text.Json;

namespace PokeApi.Rest;

public class PokemonApiRest :IPokemonApi
{
    public async Task<ResponseGenerico<PokemonModel>> BuscarPokemonNome(string name)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"https://pokeapi.co/api/v2/pokemon/{name}");

        var response = new ResponseGenerico<PokemonModel>();
        using (var client = new HttpClient())
        {
            var responsePokeApi = await client.SendAsync(request);
            var contentResp = await responsePokeApi.Content.ReadAsStringAsync();
            var objResponse = JsonSerializer.Deserialize<PokemonModel>(contentResp);

            if (responsePokeApi.IsSuccessStatusCode)
            {
                response.CodigoHttp = responsePokeApi.StatusCode;
                response.DadosRetorno = objResponse;
            }
            else
            {
                response.CodigoHttp = responsePokeApi.StatusCode;
                response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
            }
        }
        return response;
    }
}

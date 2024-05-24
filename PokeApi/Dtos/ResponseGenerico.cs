using System.Dynamic;
using System.Net;

namespace EstudosIntegracao.Dtos;

public class ResponseGenerico<T> where T : class
{
    public HttpStatusCode CodigoHttp {  get; set; }
    public T? DadosRetorno { get; set; }
    public ExpandoObject? ErroRetorno { get; set; }
}

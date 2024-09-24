using System.Dynamic;
using System.Text.Json;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Interfaces;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Rest;

public class BrasilApiRest : IBrasilApi
{
    public async Task<ResponseGenerico<EnderecoModel>> BuscasEnderecoPorCEP(string cep)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");
        
        var response = new ResponseGenerico<EnderecoModel>();

        using (var client = new HttpClient())
        {
            var responseBrasilApi = await client.SendAsync(request);
            var contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();
            
            var objResponse = JsonSerializer.Deserialize<EnderecoModel>(contentResponse);

            if (responseBrasilApi.IsSuccessStatusCode)
            {
                response.CodigoHttp = responseBrasilApi.StatusCode;
                response.DadosRetorno = objResponse;
            }
            else
            {
                response.CodigoHttp = responseBrasilApi.StatusCode;
                response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
            }
        }
        
        return response;
    }

    public async Task<ResponseGenerico<List<BancoModel>>> BuscasTodosBancos()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "https://brasilapi.com.br/api/banks/v1");
        
        var response = new ResponseGenerico<List<BancoModel>>();

        using (var client = new HttpClient())
        {
            var responseBrasilApi = await client.SendAsync(request);
            var contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();
            
            var objResponse = JsonSerializer.Deserialize<List<BancoModel>>(contentResponse);

            if (responseBrasilApi.IsSuccessStatusCode)
            {
                response.CodigoHttp = responseBrasilApi.StatusCode;
                response.DadosRetorno = objResponse;
            }
            else
            {
                response.CodigoHttp = responseBrasilApi.StatusCode;
                response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
            }
        }
        
        return response;    
    }

    public Task<ResponseGenerico<BancoModel>> BuscasEnderecoPorCodigo(string codigoBanco)
    {
        throw new NotImplementedException();
    }
}
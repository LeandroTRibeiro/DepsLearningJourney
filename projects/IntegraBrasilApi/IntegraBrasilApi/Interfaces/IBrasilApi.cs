using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Interfaces;

public interface IBrasilApi
{
    Task<ResponseGenerico<EnderecoModel>> BuscasEnderecoPorCEP(string cep);
    
    Task<ResponseGenerico<List<BancoModel>>> BuscasTodosBancos();
    
    Task<ResponseGenerico<BancoModel>> BuscasEnderecoPorCodigo(string codigoBanco);
}
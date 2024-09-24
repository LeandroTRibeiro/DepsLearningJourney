using IntegraBrasilApi.DTOs;

namespace IntegraBrasilApi.Interfaces;

public interface IEnderecoService
{
    Task<ResponseGenerico<EnderecoResponse>> BuscasEnderecoPorCEP(string cep);
}
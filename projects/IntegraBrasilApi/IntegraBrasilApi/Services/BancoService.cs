using AutoMapper;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Interfaces;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Services;

public class BancoService : IBancoService
{
    private readonly IMapper _mapper;
    private readonly IBrasilApi _brasilApi;
    
    public BancoService(IMapper mapper, IBrasilApi brasilApi)
    {
        _mapper = mapper;
        _brasilApi = brasilApi;
    }
    
    public async Task<ResponseGenerico<List<BancoResponse>>> BuscasTodosBancos()
    {
        var bancos = await _brasilApi.BuscasTodosBancos();
        
        return _mapper.Map<ResponseGenerico<List<BancoResponse>>>(bancos);
    }

    public async Task<ResponseGenerico<BancoResponse>> BuscarBancoPorCodigo(string codigoBanco)
    {
        var banco = await _brasilApi.BuscarBancoPorCodigo(codigoBanco);
        
        return _mapper.Map<ResponseGenerico<BancoResponse>>(banco);
    }
}
using AutoMapper;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Interfaces;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Services;

public class BancoService : IBancoService
{
    public BancoService(IMapper mapper, IBrasilApi brasilApi)
    {
        _mapper = mapper;
        _brasilApi = brasilApi;
    }

    private readonly IMapper _mapper;
    private readonly IBrasilApi _brasilApi;
    
    public async Task<ResponseGenerico<List<BancoResponse>>> BuscasTodosBancos()
    {
        var bancos = await _brasilApi.BuscasTodosBancos();
        
        return _mapper.Map<ResponseGenerico<List<BancoResponse>>>(bancos);
    }
}
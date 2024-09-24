using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Interfaces;

public interface IBancoService
{
    Task<ResponseGenerico<List<BancoResponse>>> BuscasTodosBancos();
}
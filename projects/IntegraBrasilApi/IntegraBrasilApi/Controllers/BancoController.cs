using System.Net;
using IntegraBrasilApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace IntegraBrasilApi.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class BancoController : ControllerBase
{
    private readonly BancoService _bancoService;

    public BancoController(BancoService bancoService)
    {
        _bancoService = bancoService;
    }
    
    [HttpGet("bancos")]
    public async Task<IActionResult> GetBancos()
    {
        var response = await _bancoService.BuscasTodosBancos();

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
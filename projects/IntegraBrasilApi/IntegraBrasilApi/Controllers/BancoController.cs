using System.ComponentModel.DataAnnotations;
using System.Net;
using IntegraBrasilApi.Interfaces;
using IntegraBrasilApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace IntegraBrasilApi.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class BancoController : ControllerBase
{
    private readonly IBancoService _bancoService;

    public BancoController(IBancoService bancoService)
    {
        _bancoService = bancoService;
    }
    
    [HttpGet("bancos")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
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

    [HttpGet("bancos/{codigoBanco}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetBanco([RegularExpression("^[0-9]*$")] string codigoBanco)
    {
        var response = await _bancoService.BuscarBancoPorCodigo(codigoBanco);

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
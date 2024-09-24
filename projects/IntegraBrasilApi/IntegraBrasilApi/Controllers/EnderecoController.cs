using System.Net;
using IntegraBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IntegraBrasilApi.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class EnderecoController : ControllerBase
{
    private readonly IEnderecoService _enderecoService;

    public EnderecoController(IEnderecoService enderecoService)
    {
        _enderecoService = enderecoService;
    }
    
    [HttpGet("{cep}")]
    public async Task<ActionResult> BuscarEndereco([FromRoute] string cep)
    {
        var response = await _enderecoService.BuscasEnderecoPorCEP(cep);

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
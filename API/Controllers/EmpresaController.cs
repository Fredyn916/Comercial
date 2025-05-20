using Microsoft.AspNetCore.Mvc;
using Model.Models;
using Service.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmpresaController : ControllerBase
{
    private readonly IEmpresaService _empresaService;

    public EmpresaController(IEmpresaService empresaService)
    {
        _empresaService = empresaService;
    }

    [HttpPost("PostEmpresa")]
    public async Task<IActionResult> Post(Empresa empresa)
    {
        try
        {
            await _empresaService.Post(empresa);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("GetEmpresa")]
    public async Task<List<Empresa>> Get()
    {
        try
        {
            return await _empresaService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByCNPJEmpresa")]
    public async Task<Empresa?> GetByCNPJ(int cnpj)
    {
        try
        {
            return await _empresaService.GetByCNPJ(cnpj);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutEmpresa")]
    public async Task<IActionResult> Put(Empresa empresa)
    {
        try
        {
            await _empresaService.Put(empresa);

            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteEmpresa")]
    public async Task<IActionResult> Delete(int cnpj)
    {
        try
        {
            await _empresaService.Delete(cnpj);

            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TabelaComprasController : ControllerBase
{
    private readonly ITabelaComprasService _tabelaComprasService;

    public TabelaComprasController(ITabelaComprasService tabelaComprasService)
    {
        _tabelaComprasService = tabelaComprasService;
    }

    [HttpPost("PostTabelaCompras")]
    public async Task<IActionResult> Post(CreateTabelaComprasDTO tabelaComprasDTO)
    {
        try
        {
            await _tabelaComprasService.Post(tabelaComprasDTO);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("GetTabelaCompras")]
    public async Task<List<TabelaCompras>> Get()
    {
        try
        {
            return await _tabelaComprasService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByIdTabelaCompras")]
    public async Task<TabelaCompras?> GetById(int id)
    {
        try
        {
            return await _tabelaComprasService.GetById(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutTabelaCompras")]
    public async Task<IActionResult> Put(TabelaCompras tabelaCompras)
    {
        try
        {
            await _tabelaComprasService.Put(tabelaCompras);

            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteTabelaCompras")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _tabelaComprasService.Delete(id);

            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TabelaComprasMercadoriasController : ControllerBase
{
    private readonly ITabelaComprasMercadoriasService _tabelaComprasMercadoriasService;

    public TabelaComprasMercadoriasController(ITabelaComprasMercadoriasService tabelaComprasMercadoriasService)
    {
        _tabelaComprasMercadoriasService = tabelaComprasMercadoriasService;
    }

    [HttpPost("PostTabelaComprasMercadorias")]
    public async Task<IActionResult> Post(CreateTabelaComprasMercadoriasDTO tabelaComprasMercadoriasDTO)
    {
        try
        {
            await _tabelaComprasMercadoriasService.Post(tabelaComprasMercadoriasDTO);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("GetTabelaComprasMercadorias")]
    public async Task<List<TabelaComprasMercadorias>> Get()
    {
        try
        {
            return await _tabelaComprasMercadoriasService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByIdTabelaComprasMercadorias")]
    public async Task<TabelaComprasMercadorias?> GetById(int id)
    {
        try
        {
            return await _tabelaComprasMercadoriasService.GetById(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutTabelaComprasMercadorias")]
    public async Task<IActionResult> Put(TabelaComprasMercadorias tabelaComprasMercadorias)
    {
        try
        {
            await _tabelaComprasMercadoriasService.Put(tabelaComprasMercadorias);

            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteTabelaComprasMercadorias")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _tabelaComprasMercadoriasService.Delete(id);

            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
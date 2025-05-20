using Microsoft.AspNetCore.Mvc;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TipomercadoriaController : ControllerBase
{
    private readonly ITipomercadoriaService _tipomercadoriaService;

    public TipomercadoriaController(ITipomercadoriaService tipomercadoriaService)
    {
        _tipomercadoriaService = tipomercadoriaService;
    }

    [HttpPost("PostTipomercadoria")]
    public async Task<IActionResult> Post(CreateTipomercadoriaDTO tipoMercadoriaDTO)
    {
        try
        {
            await _tipomercadoriaService.Post(tipoMercadoriaDTO);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("GetTipomercadoria")]
    public async Task<List<Tipomercadoria>> Get()
    {
        try
        {
            return await _tipomercadoriaService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByTipomercadoriaIdTipomercadoria")]
    public async Task<Tipomercadoria?> GetByTipomercadoriaId(int id)
    {
        try
        {
            return await _tipomercadoriaService.GetByTipomercadoriaId(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByDepartamentoIdTipomercadoria")]
    public async Task<Tipomercadoria?> GetByDepartamentoId(int id)
    {
        try
        {
            return await _tipomercadoriaService.GetByDepartamentoId(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByEnderecoIdTipomercadoria")]
    public async Task<Tipomercadoria?> GetByEnderecoId(int id)
    {
        try
        {
            return await _tipomercadoriaService.GetByEnderecoId(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutTipomercadoria")]
    public async Task<IActionResult> Put(Tipomercadoria tipoMercadoria)
    {
        try
        {
            await _tipomercadoriaService.Put(tipoMercadoria);

            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteByTipomercadoriaIdTipomercadoria")]
    public async Task<IActionResult> DeleteByTipomercadoriaId(int id)
    {
        try
        {
            await _tipomercadoriaService.DeleteByTipomercadoriaId(id);

            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteByDepartamentoIdTipomercadoria")]
    public async Task<IActionResult> DeleteByDepartamentoId(int id)
    {
        try
        {
            await _tipomercadoriaService.DeleteByDepartamentoId(id);

            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteByEnderecoIdTipomercadoria")]
    public async Task<IActionResult> DeleteByEnderecoId(int id)
    {
        try
        {
            await _tipomercadoriaService.DeleteByEnderecoId(id);

            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MercadoriasController : ControllerBase
{
    private readonly IMercadoriasService _mercadoriasService;

    public MercadoriasController(IMercadoriasService mercadoriasService)
    {
        _mercadoriasService = mercadoriasService;
    }

    [HttpPost("PostMercadorias")]
    public async Task<IActionResult> Post(CreateMercadoriasDTO mercadoriaDTO)
    {
        try
        {
            await _mercadoriasService.Post(mercadoriaDTO);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("GetMercadorias")]
    public async Task<List<Mercadorias>> Get()
    {
        try
        {
            return await _mercadoriasService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByIdMercadorias")]
    public async Task<Mercadorias?> GetById(int id)
    {
        try
        {
            return await _mercadoriasService.GetById(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutMercadorias")]
    public async Task<IActionResult> Put(Mercadorias mercadoria)
    {
        try
        {
            await _mercadoriasService.Put(mercadoria);

            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteMercadorias")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _mercadoriasService.Delete(id);

            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
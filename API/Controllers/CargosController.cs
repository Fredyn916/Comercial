using Microsoft.AspNetCore.Mvc;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CargosController : ControllerBase
{
    private readonly ICargosService _cargosService;

    public CargosController(ICargosService cargosService)
    {
        _cargosService = cargosService;
    }

    [HttpPost("PostCargos")]
    public async Task<IActionResult> Post(CreateCargosDTO cargoDTO)
    {
        try
        {
            await _cargosService.Post(cargoDTO);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("GetCargos")]
    public async Task<List<Cargos>> Get()
    {
        try
        {
            return await _cargosService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByIdCargos")]
    public async Task<Cargos?> GetById(int id)
    {
        try
        {
            return await _cargosService.GetById(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutCargos")]
    public async Task<IActionResult> Put(Cargos cargo)
    {
        try
        {
            await _cargosService.Put(cargo);

            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteCargos")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _cargosService.Delete(id);

            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
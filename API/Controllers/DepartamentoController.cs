using Microsoft.AspNetCore.Mvc;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DepartamentoController : ControllerBase
{
    private readonly IDepartamentoService _departamentoService;

    public DepartamentoController(IDepartamentoService departamentoService)
    {
        _departamentoService = departamentoService;
    }

    [HttpPost("PostDepartamento")]
    public async Task<IActionResult> Post(CreateDepartamentoDTO departamentoDTO)
    {
        try
        {
            await _departamentoService.Post(departamentoDTO);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("GetDepartamento")]
    public async Task<List<Departamento>> Get()
    {
        try
        {
            return await _departamentoService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByDepartamentoIdDepartamento")]
    public async Task<Departamento?> GetByDepartamentoId(int id)
    {
        try
        {
            return await _departamentoService.GetByDepartamentoId(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByEnderecoIdDepartamento")]
    public async Task<Departamento?> GetByEnderecoId(int id)
    {
        try
        {
            return await _departamentoService.GetByEnderecoId(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutDepartamento")]
    public async Task<IActionResult> Put(Departamento departamento)
    {
        try
        {
            await _departamentoService.Put(departamento);

            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteByDepartamentoIdDepartamento")]
    public async Task<IActionResult> DeleteByDepartamentoId(int id)
    {
        try
        {
            await _departamentoService.DeleteByDepartamentoId(id);

            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteByEnderecoIdDepartamento")]
    public async Task<IActionResult> DeleteByEnderecoId(int id)
    {
        try
        {
            await _departamentoService.DeleteByEnderecoId(id);

            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
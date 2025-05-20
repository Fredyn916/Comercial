using Microsoft.AspNetCore.Mvc;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FuncionariosController : ControllerBase
{
    private readonly IFuncionariosService _funcionariosService;

    public FuncionariosController(IFuncionariosService funcionariosService)
    {
        _funcionariosService = funcionariosService;
    }

    [HttpPost("PostFuncionarios")]
    public async Task<IActionResult> Post(CreateFuncionariosDTO funcionarioDTO)
    {
        try
        {
            await _funcionariosService.Post(funcionarioDTO);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("GetFuncionarios")]
    public async Task<List<Funcionarios>> Get()
    {
        try
        {
            return await _funcionariosService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByIdFuncionarios")]
    public async Task<Funcionarios?> GetById(int id)
    {
        try
        {
            return await _funcionariosService.GetById(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutFuncionarios")]
    public async Task<IActionResult> Put(Funcionarios funcionario)
    {
        try
        {
            await _funcionariosService.Put(funcionario);

            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteFuncionarios")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _funcionariosService.Delete(id);

            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
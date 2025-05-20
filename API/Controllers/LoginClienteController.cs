using Microsoft.AspNetCore.Mvc;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LoginclienteController : ControllerBase
{
    private readonly ILoginclienteService _loginClienteService;

    public LoginclienteController(ILoginclienteService loginClienteService)
    {
        _loginClienteService = loginClienteService;
    }

    [HttpPost("PostLogincliente")]
    public async Task<IActionResult> Post(CreateLoginclienteDTO loginClienteDTO)
    {
        try
        {
            await _loginClienteService.Post(loginClienteDTO);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("GetLogincliente")]
    public async Task<List<Logincliente>> Get()
    {
        try
        {
            return await _loginClienteService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByIdLogincliente")]
    public async Task<Logincliente?> GetById(int id)
    {
        try
        {
            return await _loginClienteService.GetById(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutLogincliente")]
    public async Task<IActionResult> Put(Logincliente loginCliente)
    {
        try
        {
            await _loginClienteService.Put(loginCliente);

            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteLogincliente")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _loginClienteService.Delete(id);

            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
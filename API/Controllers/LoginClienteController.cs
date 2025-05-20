using Microsoft.AspNetCore.Mvc;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LoginClienteController : ControllerBase
{
    private readonly ILoginClienteService _loginClienteService;

    public LoginClienteController(ILoginClienteService loginClienteService)
    {
        _loginClienteService = loginClienteService;
    }

    [HttpPost("PostLoginCliente")]
    public async Task<IActionResult> Post(CreateLoginClienteDTO loginClienteDTO)
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

    [HttpGet("GetLoginCliente")]
    public async Task<List<LoginCliente>> Get()
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

    [HttpGet("GetByIdLoginCliente")]
    public async Task<LoginCliente?> GetById(int id)
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

    [HttpPut("PutLoginCliente")]
    public async Task<IActionResult> Put(LoginCliente loginCliente)
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

    [HttpDelete("DeleteLoginCliente")]
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
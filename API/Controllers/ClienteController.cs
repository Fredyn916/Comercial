using Microsoft.AspNetCore.Mvc;
using Model.Models;
using Service.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClienteController : ControllerBase
{
    private readonly IClienteService _clienteService;

    public ClienteController(IClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    [HttpPost("PostCliente")]
    public async Task<IActionResult> Post(Cliente cliente)
    {
        try
        {
            await _clienteService.Post(cliente);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("GetCliente")]
    public async Task<List<Cliente>> Get()
    {
        try
        {
            return await _clienteService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByIdCliente")]
    public async Task<Cliente?> GetByCPF(int cpf)
    {
        try
        {
            return await _clienteService.GetByCPF(cpf);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutCliente")]
    public async Task<IActionResult> Put(Cliente cliente)
    {
        try
        {
            await _clienteService.Put(cliente);

            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteCliente")]
    public async Task<IActionResult> Delete(int cpf)
    {
        try
        {
            await _clienteService.Delete(cpf);

            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
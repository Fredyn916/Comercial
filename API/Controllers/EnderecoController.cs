using Microsoft.AspNetCore.Mvc;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EnderecoController : ControllerBase
{
    private readonly IEnderecoService _enderecoService;

    public EnderecoController(IEnderecoService enderecoService)
    {
        _enderecoService = enderecoService;
    }

    [HttpPost("PostEndereco")]
    public async Task<IActionResult> Post(CreateEnderecoDTO enderecoDTO)
    {
        try
        {
            await _enderecoService.Post(enderecoDTO);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("GetEndereco")]
    public async Task<List<Endereco>> Get()
    {
        try
        {
            return await _enderecoService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByIdEndereco{id}")]
    public async Task<Endereco?> GetById(int id)
    {
        try
        {
            return await _enderecoService.GetById(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutEndereco")]
    public async Task<IActionResult> Put(Endereco endereco)
    {
        try
        {
            await _enderecoService.Put(endereco);

            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteEndereco{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _enderecoService.Delete(id);

            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
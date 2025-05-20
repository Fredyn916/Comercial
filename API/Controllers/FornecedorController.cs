using Microsoft.AspNetCore.Mvc;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FornecedorController : ControllerBase
{
    private readonly IFornecedorService _fornecedorService;

    public FornecedorController(IFornecedorService fornecedorService)
    {
        _fornecedorService = fornecedorService;
    }

    [HttpPost("PostFornecedor")]
    public async Task<IActionResult> Post(CreateFornecedorDTO fornecedorDTO)
    {
        try
        {
            await _fornecedorService.Post(fornecedorDTO);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("GetFornecedor")]
    public async Task<List<Fornecedor>> Get()
    {
        try
        {
            return await _fornecedorService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByIdFornecedor")]
    public async Task<Fornecedor?> GetById(int id)
    {
        try
        {
            return await _fornecedorService.GetById(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutFornecedor")]
    public async Task<IActionResult> Put(Fornecedor fornecedor)
    {
        try
        {
            await _fornecedorService.Put(fornecedor);

            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteFornecedor")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _fornecedorService.Delete(id);

            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
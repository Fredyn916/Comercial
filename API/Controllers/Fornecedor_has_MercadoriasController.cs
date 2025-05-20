using Microsoft.AspNetCore.Mvc;
using Model.Models;
using Service.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Fornecedor_has_MercadoriasController : ControllerBase
{
    private readonly IFornecedor_has_MercadoriasService _fornecedor_has_MercadoriasService;

    public Fornecedor_has_MercadoriasController(IFornecedor_has_MercadoriasService fornecedor_has_MercadoriasService)
    {
        _fornecedor_has_MercadoriasService = fornecedor_has_MercadoriasService;
    }

    [HttpPost("PostFornecedor_has_Mercadorias")]
    public async Task<IActionResult> Post(Fornecedor_has_Mercadorias fornecedor_has_Mercadorias)
    {
        try
        {
            await _fornecedor_has_MercadoriasService.Post(fornecedor_has_Mercadorias);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("GetFornecedor_has_Mercadorias")]
    public async Task<List<Fornecedor_has_Mercadorias>> Get()
    {
        try
        {
            return await _fornecedor_has_MercadoriasService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByFornecedorIdFornecedor_has_Mercadorias")]
    public async Task<Fornecedor_has_Mercadorias?> GetByFornecedorId(int id)
    {
        try
        {
            return await _fornecedor_has_MercadoriasService.GetByFornecedorId(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByMercadoriasIdFornecedor_has_Mercadorias")]
    public async Task<Fornecedor_has_Mercadorias?> GetByMercadoriasId(int id)
    {
        try
        {
            return await _fornecedor_has_MercadoriasService.GetByMercadoriasId(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutFornecedor_has_Mercadorias")]
    public async Task<IActionResult> Put(Fornecedor_has_Mercadorias fornecedor_has_Mercadorias)
    {
        try
        {
            await _fornecedor_has_MercadoriasService.Put(fornecedor_has_Mercadorias);

            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteByFornecedorIdFornecedor_has_Mercadorias")]
    public async Task<IActionResult> DeleteByFornecedorId(int id)
    {
        try
        {
            await _fornecedor_has_MercadoriasService.DeleteByFornecedorId(id);

            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteByMercadoriasIdFornecedor_has_Mercadorias")]
    public async Task<IActionResult> DeleteByMercadoriasId(int id)
    {
        try
        {
            await _fornecedor_has_MercadoriasService.DeleteByMercadoriasId(id);

            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
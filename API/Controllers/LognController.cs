using Microsoft.AspNetCore.Mvc;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LognController : ControllerBase
{
    private readonly ILognService _lognService;

    public LognController(ILognService lognService)
    {
        _lognService = lognService;
    }

    [HttpPost("PostLogn")]
    public async Task<IActionResult> Post(CreateLognDTO lognDTO)
    {
        try
        {
            await _lognService.Post(lognDTO);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("GetLogn")]
    public async Task<List<Logn>> Get()
    {
        try
        {
            return await _lognService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByIdLogn")]
    public async Task<Logn?> GetById(int id)
    {
        try
        {
            return await _lognService.GetById(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutLogn")]
    public async Task<IActionResult> Put(Logn logn)
    {
        try
        {
            await _lognService.Put(logn);

            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteLogn")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _lognService.Delete(id);

            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
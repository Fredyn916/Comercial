using AutoMapper;
using DAO.Interfaces;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace Service.Services;

public class LoginclienteService : ILoginclienteService
{
    private readonly ILoginclienteRepository _loginClienteRepository;
    private readonly IMapper _mapper;

    public LoginclienteService(ILoginclienteRepository loginClienteRepository, IMapper mapper)
    {
        _loginClienteRepository = loginClienteRepository;
        _mapper = mapper;
    }

    public async Task Post(CreateLoginclienteDTO loginClienteDTO)
    {
        var loginCliente = _mapper.Map<Logincliente>(loginClienteDTO);

        await _loginClienteRepository.Post(loginCliente);
    }

    public async Task<List<Logincliente>> Get()
    {
        return await _loginClienteRepository.Get();
    }

    public async Task<Logincliente?> GetById(int id)
    {
        return await _loginClienteRepository.GetById(id);
    }

    public async Task Put(Logincliente loginCliente)
    {
        await _loginClienteRepository.Put(loginCliente);
    }

    public async Task Delete(int id)
    {
        await _loginClienteRepository.Delete(id);
    }
}
using AutoMapper;
using DAO.Interfaces;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace Service.Services;

public class LoginClienteService : ILoginClienteService
{
    private readonly ILoginClienteRepository _loginClienteRepository;
    private readonly IMapper _mapper;

    public LoginClienteService(ILoginClienteRepository loginClienteRepository, IMapper mapper)
    {
        _loginClienteRepository = loginClienteRepository;
        _mapper = mapper;
    }

    public async Task Post(CreateLoginClienteDTO loginClienteDTO)
    {
        var loginCliente = _mapper.Map<LoginCliente>(loginClienteDTO);

        await _loginClienteRepository.Post(loginCliente);
    }

    public async Task<List<LoginCliente>> Get()
    {
        return await _loginClienteRepository.Get();
    }

    public async Task<LoginCliente?> GetById(int id)
    {
        return await _loginClienteRepository.GetById(id);
    }

    public async Task Put(LoginCliente loginCliente)
    {
        await _loginClienteRepository.Put(loginCliente);
    }

    public async Task Delete(int id)
    {
        await _loginClienteRepository.Delete(id);
    }
}
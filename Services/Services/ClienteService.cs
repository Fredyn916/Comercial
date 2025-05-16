using DAO.Interfaces;
using Model.Models;
using Service.Interfaces;

namespace Service.Services;

public class ClienteService : IClienteService
{
    private readonly IClienteRepository _clienteRepository;

    public ClienteService(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public async Task Post(Cliente cliente)
    {

        await _clienteRepository.Post(cliente);
    }

    public async Task<List<Cliente>> Get()
    {
        return await _clienteRepository.Get();
    }

    public async Task<Cliente?> GetByCPF(int cpf)
    {
        return await _clienteRepository.GetByCPF(cpf);
    }

    public async Task Put(Cliente cliente)
    {
        await _clienteRepository.Put(cliente);
    }

    public async Task Delete(int cpf)
    {
        await _clienteRepository.Delete(cpf);
    }
}
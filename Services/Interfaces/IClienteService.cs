using Model.Models;

namespace Service.Interfaces;

public interface IClienteService
{
    Task Post(Cliente cliente);
    Task<List<Cliente>> Get();
    Task<Cliente?> GetByCPF(int cpf);
    Task Put(Cliente cliente);
    Task Delete(int cpf);
}
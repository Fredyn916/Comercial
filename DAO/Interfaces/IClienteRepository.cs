using Model.Models;

namespace DAO.Interfaces;

public interface IClienteRepository
{
    Task Post(Cliente cliente);
    Task<List<Cliente>> Get();
    Task<Cliente?> GetByCPF(int cpf);
    Task Put(Cliente cliente);
    Task Delete(int cpf);
}
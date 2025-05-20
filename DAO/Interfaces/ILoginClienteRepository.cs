using Model.Models;

namespace DAO.Interfaces;

public interface ILoginclienteRepository
{
    Task Post(Logincliente loginCliente);
    Task<List<Logincliente>> Get();
    Task<Logincliente?> GetById(int id);
    Task Put(Logincliente loginCliente);
    Task Delete(int id);
}
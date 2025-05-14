using Model.Models;

namespace DAO.Interfaces;

public interface ILoginClienteRepository
{
    Task Post(LoginCliente loginCliente);
    Task<List<LoginCliente>> Get();
    Task<LoginCliente?> GetById(int id);
    Task Put(LoginCliente loginCliente);
    Task Delete(int id);
}
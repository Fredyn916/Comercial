using Model.Models;

namespace DAO.Interfaces;

public interface ICargosRepository
{
    Task Post(Cargos cargo);
    Task<List<Cargos>> Get();
    Task<Cargos?> GetById(int id);
    Task Put(Cargos cargo);
    Task Delete(int id);
}
using Model.Models;

namespace DAO.Interfaces;

public interface IDepartamentoRepository
{
    Task Post(Departamento departamento);
    Task<List<Departamento>> Get();
    Task<Departamento?> GetByDepartamentoId(int id);
    Task<Departamento?> GetByEnderecoId(int id);
    Task Put(Departamento departamento);
    Task Delete(int id);
}
using Model.Models;

namespace DAO.Interfaces;

public interface IFuncionariosRepository
{
    Task Post(Funcionarios funcionario);
    Task<List<Funcionarios>> Get();
    Task<Funcionarios?> GetById(int id);
    Task Put(Funcionarios funcionario);
    Task Delete(int id);
}
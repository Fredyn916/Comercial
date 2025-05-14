using Model.Models;

namespace DAO.Interfaces;

public interface IFornecedorRepository
{
    Task Post(Fornecedor fornecedor);
    Task<List<Fornecedor>> Get();
    Task<Fornecedor?> GetById(int id);
    Task Put(Fornecedor fornecedor);
    Task Delete(int id);
}
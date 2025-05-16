using Model.DTO.Create;
using Model.Models;

namespace Service.Interfaces;

public interface IFornecedorService
{
    Task Post(CreateFornecedorDTO fornecedorDTO);
    Task<List<Fornecedor>> Get();
    Task<Fornecedor?> GetById(int id);
    Task Put(Fornecedor fornecedor);
    Task Delete(int id);
}
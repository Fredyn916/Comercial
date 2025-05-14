using Model.Models;

namespace DAO.Interfaces;

public interface IEmpresaRepository
{
    Task Post(Empresa empresa);
    Task<List<Empresa>> Get();
    Task<Empresa?> GetByCNPJ(int cnpj);
    Task Put(Empresa empresa);
    Task Delete(int cnpj);
}
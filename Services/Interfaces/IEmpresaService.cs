using Model.Models;

namespace Service.Interfaces;

public interface IEmpresaService
{
    Task Post(Empresa empresa);
    Task<List<Empresa>> Get();
    Task<Empresa?> GetByCNPJ(string cnpj);
    Task Put(Empresa empresa);
    Task Delete(string cnpj);
}
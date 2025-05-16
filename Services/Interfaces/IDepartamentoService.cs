using Model.DTO.Create;
using Model.Models;

namespace Service.Interfaces;

public interface IDepartamentoService
{
    Task Post(CreateDepartamentoDTO departamentoDTO);
    Task<List<Departamento>> Get();
    Task<Departamento?> GetByDepartamentoId(int id);
    Task<Departamento?> GetByEnderecoId(int id);
    Task Put(Departamento departamento);
    Task DeleteByDepartamentoId(int id);
    Task DeleteByEnderecoId(int id);
}
using Model.DTO.Create;
using Model.Models;

namespace Service.Interfaces;

public interface ILoginClienteService
{
    Task Post(CreateLoginClienteDTO loginClienteDTO);
    Task<List<LoginCliente>> Get();
    Task<LoginCliente?> GetById(int id);
    Task Put(LoginCliente loginCliente);
    Task Delete(int id);
}
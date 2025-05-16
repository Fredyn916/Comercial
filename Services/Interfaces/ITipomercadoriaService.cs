using Model.DTO.Create;
using Model.Models;

namespace Service.Interfaces;

public interface ITipomercadoriaService
{
    Task Post(CreateTipomercadoriaDTO tipoMercadoriaDTO);
    Task<List<Tipomercadoria>> Get();
    Task<Tipomercadoria?> GetByTipomercadoriaId(int id);
    Task<Tipomercadoria?> GetByDepartamentoId(int id);
    Task<Tipomercadoria?> GetByEnderecoId(int id);
    Task Put(Tipomercadoria tipoMercadoria);
    Task DeleteByTipomercadoriaId(int id);
    Task DeleteByDepartamentoId(int id);
    Task DeleteByEnderecoId(int id);
}
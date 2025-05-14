using Model.Models;

namespace DAO.Interfaces;

public interface ITipomercadoriaRepository
{
    Task Post(Tipomercadoria tipoMercadoria);
    Task<List<Tipomercadoria>> Get();
    Task<Tipomercadoria?> GetByTipomercadoriaId(int id);
    Task<Tipomercadoria?> GetByDepartamentoId(int id);
    Task<Tipomercadoria?> GetByEnderecoId(int id);
    Task Put(Tipomercadoria tipoMercadoria);
    Task Delete(int id);
}
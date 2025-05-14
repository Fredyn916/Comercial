using Model.Models;

namespace DAO.Interfaces;

public interface IMercadoriasRepository
{
    Task Post(Mercadorias mercadoria);
    Task<List<Mercadorias>> Get();
    Task<Mercadorias?> GetById(int id);
    Task Put(Mercadorias mercadoria);
    Task Delete(int id);
}
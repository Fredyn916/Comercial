using Model.Models;

namespace DAO.Interfaces;

public interface IFornecedor_has_MercadoriasRepository
{
    Task Post(Fornecedor_has_Mercadorias fornecedorHasMercadorias);
    Task<List<Fornecedor_has_Mercadorias>> Get();
    Task<Fornecedor_has_Mercadorias?> GetByFornecedorId(int id);
    Task<Fornecedor_has_Mercadorias?> GetByMercadoriasId(int id);
    Task Put(Fornecedor_has_Mercadorias fornecedorHasMercadorias);
    Task DeleteByFornecedorId(int id);
    Task DeleteByMercadoriasId(int id);
}
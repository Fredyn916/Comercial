using Model.Models;

namespace Service.Interfaces;

public interface IFornecedor_has_MercadoriasService
{
    Task Post(Fornecedor_has_Mercadorias fornecedor_has_Mercadorias);
    Task<List<Fornecedor_has_Mercadorias>> Get();
    Task<Fornecedor_has_Mercadorias?> GetByFornecedorId(int id);
    Task<Fornecedor_has_Mercadorias?> GetByMercadoriasId(int id);
    Task Put(Fornecedor_has_Mercadorias fornecedor_has_Mercadorias);
    Task DeleteByFornecedorId(int id);
    Task DeleteByMercadoriasId(int id);
}
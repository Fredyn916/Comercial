using DAO.Interfaces;
using Model.Models;
using Service.Interfaces;

namespace Service.Services;

public class Fornecedor_has_MercadoriasService : IFornecedor_has_MercadoriasService
{
    private readonly IFornecedor_has_MercadoriasRepository _fornecedor_has_MercadoriasRepository;

    public Fornecedor_has_MercadoriasService(IFornecedor_has_MercadoriasRepository fornecedor_has_MercadoriasRepository)
    {
        _fornecedor_has_MercadoriasRepository = fornecedor_has_MercadoriasRepository;
    }

    public async Task Post(Fornecedor_has_Mercadorias fornecedor_has_Mercadorias)
    {

        await _fornecedor_has_MercadoriasRepository.Post(fornecedor_has_Mercadorias);
    }

    public async Task<List<Fornecedor_has_Mercadorias>> Get()
    {
        return await _fornecedor_has_MercadoriasRepository.Get();
    }

    public async Task<Fornecedor_has_Mercadorias?> GetByFornecedorId(int id)
    {
        return await _fornecedor_has_MercadoriasRepository.GetByFornecedorId(id);
    }

    public async Task<Fornecedor_has_Mercadorias?> GetByMercadoriasId(int id)
    {
        return await _fornecedor_has_MercadoriasRepository.GetByMercadoriasId(id);
    }

    public async Task Put(Fornecedor_has_Mercadorias fornecedor_has_Mercadorias)
    {
        await _fornecedor_has_MercadoriasRepository.Put(fornecedor_has_Mercadorias);
    }

    public async Task DeleteByFornecedorId(int id)
    {
        await _fornecedor_has_MercadoriasRepository.DeleteByFornecedorId(id);
    }

    public async Task DeleteByMercadoriasId(int id)
    {
        await _fornecedor_has_MercadoriasRepository.DeleteByMercadoriasId(id);
    }
}
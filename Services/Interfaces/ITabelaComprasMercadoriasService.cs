using Model.DTO.Create;
using Model.Models;

namespace Service.Interfaces;

public interface ITabelaComprasMercadoriasService
{
    Task Post(CreateTabelaComprasMercadoriasDTO tabelaComprasMercadoriasDTO);
    Task<List<TabelaComprasMercadorias>> Get();
    Task<TabelaComprasMercadorias?> GetById(int id);
    Task Put(TabelaComprasMercadorias tabelaComprasMercadorias);
    Task Delete(int id);
}
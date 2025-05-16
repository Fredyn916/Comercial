using AutoMapper;
using DAO.Interfaces;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace Service.Services;

public class TabelaComprasMercadoriasService : ITabelaComprasMercadoriasService
{
    private readonly ITabelaComprasMercadoriasRepository _tabelaComprasMercadoriasRepository;
    private readonly IMapper _mapper;

    public TabelaComprasMercadoriasService(ITabelaComprasMercadoriasRepository tabelaComprasMercadoriasRepository, IMapper mapper)
    {
        _tabelaComprasMercadoriasRepository = tabelaComprasMercadoriasRepository;
        _mapper = mapper;
    }

    public async Task Post(CreateTabelaComprasMercadoriasDTO tabelaComprasMercadoriasDTO)
    {
        var tabelaComprasMercadorias = _mapper.Map<TabelaComprasMercadorias>(tabelaComprasMercadoriasDTO);

        await _tabelaComprasMercadoriasRepository.Post(tabelaComprasMercadorias);
    }

    public async Task<List<TabelaComprasMercadorias>> Get()
    {
        return await _tabelaComprasMercadoriasRepository.Get();
    }

    public async Task<TabelaComprasMercadorias?> GetById(int id)
    {
        return await _tabelaComprasMercadoriasRepository.GetById(id);
    }

    public async Task Put(TabelaComprasMercadorias tabelaComprasMercadorias)
    {
        await _tabelaComprasMercadoriasRepository.Put(tabelaComprasMercadorias);
    }

    public async Task Delete(int id)
    {
        await _tabelaComprasMercadoriasRepository.Delete(id);
    }
}
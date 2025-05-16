using AutoMapper;
using DAO.Interfaces;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace Service.Services;

public class TabelaComprasService : ITabelaComprasService
{
    private readonly ITabelaComprasRepository _tabelaComprasRepository;
    private readonly IMapper _mapper;

    public TabelaComprasService(ITabelaComprasRepository tabelaComprasRepository, IMapper mapper)
    {
        _tabelaComprasRepository = tabelaComprasRepository;
        _mapper = mapper;
    }

    public async Task Post(CreateTabelaComprasDTO tabelaComprasDTO)
    {
        var tabelaCompras = _mapper.Map<TabelaCompras>(tabelaComprasDTO);

        await _tabelaComprasRepository.Post(tabelaCompras);
    }

    public async Task<List<TabelaCompras>> Get()
    {
        return await _tabelaComprasRepository.Get();
    }

    public async Task<TabelaCompras?> GetById(int id)
    {
        return await _tabelaComprasRepository.GetById(id);
    }

    public async Task Put(TabelaCompras tabelaCompras)
    {
        await _tabelaComprasRepository.Put(tabelaCompras);
    }

    public async Task Delete(int id)
    {
        await _tabelaComprasRepository.Delete(id);
    }
}
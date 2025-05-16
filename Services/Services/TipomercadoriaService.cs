using AutoMapper;
using DAO.Interfaces;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace Service.Services;

public class TipomercadoriaService : ITipomercadoriaService
{
    private readonly ITipomercadoriaRepository _tipomercadoriaRepository;
    private readonly IMapper _mapper;

    public TipomercadoriaService(ITipomercadoriaRepository tipomercadoriaRepository, IMapper mapper)
    {
        _tipomercadoriaRepository = tipomercadoriaRepository;
        _mapper = mapper;
    }

    public async Task Post(CreateTipomercadoriaDTO tipoMercadoriaDTO)
    {
        var tipoMercadoria = _mapper.Map<Tipomercadoria>(tipoMercadoriaDTO);

        await _tipomercadoriaRepository.Post(tipoMercadoria);
    }

    public async Task<List<Tipomercadoria>> Get()
    {
        return await _tipomercadoriaRepository.Get();
    }

    public async Task<Tipomercadoria?> GetByTipomercadoriaId(int id)
    {
        return await _tipomercadoriaRepository.GetByTipomercadoriaId(id);
    }

    public async Task<Tipomercadoria?> GetByDepartamentoId(int id)
    {
        return await _tipomercadoriaRepository.GetByDepartamentoId(id);
    }

    public async Task<Tipomercadoria?> GetByEnderecoId(int id)
    {
        return await _tipomercadoriaRepository.GetByEnderecoId(id);
    }

    public async Task Put(Tipomercadoria tipoMercadoria)
    {
        await _tipomercadoriaRepository.Put(tipoMercadoria);
    }

    public async Task DeleteByTipomercadoriaId(int id)
    {
        await _tipomercadoriaRepository.DeleteByTipomercadoriaId(id);
    }

    public async Task DeleteByDepartamentoId(int id)
    {
        await _tipomercadoriaRepository.DeleteByDepartamentoId(id);
    }

    public async Task DeleteByEnderecoId(int id)
    {
        await _tipomercadoriaRepository.DeleteByEnderecoId(id);
    }
}
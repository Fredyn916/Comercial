using AutoMapper;
using DAO.Interfaces;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace Service.Services;

public class MercadoriasService : IMercadoriasService
{
    private readonly IMercadoriasRepository _mercadoriasRepository;
    private readonly IMapper _mapper;

    public MercadoriasService(IMercadoriasRepository mercadoriasRepository, IMapper mapper)
    {
        _mercadoriasRepository = mercadoriasRepository;
        _mapper = mapper;
    }

    public async Task Post(CreateMercadoriasDTO mercadoriaDTO)
    {
        var mercadoria = _mapper.Map<Mercadorias>(mercadoriaDTO);

        await _mercadoriasRepository.Post(mercadoria);
    }

    public async Task<List<Mercadorias>> Get()
    {
        return await _mercadoriasRepository.Get();
    }

    public async Task<Mercadorias?> GetById(int id)
    {
        return await _mercadoriasRepository.GetById(id);
    }

    public async Task Put(Mercadorias mercadoria)
    {
        await _mercadoriasRepository.Put(mercadoria);
    }

    public async Task Delete(int id)
    {
        await _mercadoriasRepository.Delete(id);
    }
}
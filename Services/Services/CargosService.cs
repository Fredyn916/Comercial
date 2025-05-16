using AutoMapper;
using DAO.Interfaces;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace Service.Services;

public class CargosService : ICargosService
{
    private readonly ICargosRepository _cargosRepository;
    private readonly IMapper _mapper;

    public CargosService(ICargosRepository cargosRepository, IMapper mapper)
    {
        _cargosRepository = cargosRepository;
        _mapper = mapper;
    }

    public async Task Post(CreateCargosDTO cargoDTO)
    {
        var cargo = _mapper.Map<Cargos>(cargoDTO);

        await _cargosRepository.Post(cargo);
    }

    public async Task<List<Cargos>> Get()
    {
        return await _cargosRepository.Get();
    }

    public async Task<Cargos?> GetById(int id)
    {
        return await _cargosRepository.GetById(id);
    }

    public async Task Put(Cargos cargo)
    {
        await _cargosRepository.Put(cargo);
    }

    public async Task Delete(int id)
    {
        await _cargosRepository.Delete(id);
    }
}
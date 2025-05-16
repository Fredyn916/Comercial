using AutoMapper;
using DAO.Interfaces;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace Service.Services;

public class DepartamentoService : IDepartamentoService
{
    private readonly IDepartamentoRepository _departamentoRepository;
    private readonly IMapper _mapper;

    public DepartamentoService(IDepartamentoRepository departamentoRepository, IMapper mapper)
    {
        _departamentoRepository = departamentoRepository;
        _mapper = mapper;
    }

    public async Task Post(CreateDepartamentoDTO departamentoDTO)
    {
        var departamento = _mapper.Map<Departamento>(departamentoDTO);

        await _departamentoRepository.Post(departamento);
    }

    public async Task<List<Departamento>> Get()
    {
        return await _departamentoRepository.Get();
    }

    public async Task<Departamento?> GetByDepartamentoId(int id)
    {
        return await _departamentoRepository.GetByDepartamentoId(id);
    }

    public async Task<Departamento?> GetByEnderecoId(int id)
    {
        return await _departamentoRepository.GetByEnderecoId(id);
    }

    public async Task Put(Departamento departamento)
    {
        await _departamentoRepository.Put(departamento);
    }

    public async Task DeleteByDepartamentoId(int id)
    {
        await _departamentoRepository.DeleteByDepartamentoId(id);
    }

    public async Task DeleteByEnderecoId(int id)
    {
        await _departamentoRepository.DeleteByEnderecoId(id);
    }
}
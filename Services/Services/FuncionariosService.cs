using AutoMapper;
using DAO.Interfaces;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace Service.Services;

public class FuncionariosService : IFuncionariosService
{
    private readonly IFuncionariosRepository _funcionariosRepository;
    private readonly IMapper _mapper;

    public FuncionariosService(IFuncionariosRepository funcionariosRepository, IMapper mapper)
    {
        _funcionariosRepository = funcionariosRepository;
        _mapper = mapper;
    }

    public async Task Post(CreateFuncionariosDTO funcionarioDTO)
    {
        var funcionario = _mapper.Map<Funcionarios>(funcionarioDTO);

        await _funcionariosRepository.Post(funcionario);
    }

    public async Task<List<Funcionarios>> Get()
    {
        return await _funcionariosRepository.Get();
    }

    public async Task<Funcionarios?> GetById(int id)
    {
        return await _funcionariosRepository.GetById(id);
    }

    public async Task Put(Funcionarios funcionario)
    {
        await _funcionariosRepository.Put(funcionario);
    }

    public async Task Delete(int id)
    {
        await _funcionariosRepository.Delete(id);
    }
}
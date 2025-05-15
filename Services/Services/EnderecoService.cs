using AutoMapper;
using DAO.Interfaces;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace Service.Services;

public class EnderecoService : IEnderecoService
{
    private readonly IEnderecoRepository _enderecoRepository;
    private readonly IMapper _mapper;

    public EnderecoService(IEnderecoRepository enderecoRepository, IMapper mapper)
    {
        _enderecoRepository = enderecoRepository;
        _mapper = mapper;
    }

    public async Task Post(CreateEnderecoDTO enderecoDTO)
    {
        var endereco = _mapper.Map<Endereco>(enderecoDTO);

        await _enderecoRepository.Post(endereco);
    }

    public async Task<List<Endereco>> Get()
    {
        return await _enderecoRepository.Get();
    }

    public async Task<Endereco?> GetById(int id)
    {
        return await _enderecoRepository.GetById(id);
    }

    public async Task Put(Endereco endereco)
    {
        await _enderecoRepository.Put(endereco);
    }

    public async Task Delete(int id)
    {
        await _enderecoRepository.Delete(id);
    }
}
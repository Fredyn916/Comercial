using AutoMapper;
using DAO.Interfaces;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace Service.Services;

public class FornecedorService : IFornecedorService
{
    private readonly IFornecedorRepository _fornecedorRepository;
    private readonly IMapper _mapper;

    public FornecedorService(IFornecedorRepository fornecedorRepository, IMapper mapper)
    {
        _fornecedorRepository = fornecedorRepository;
        _mapper = mapper;
    }

    public async Task Post(CreateFornecedorDTO fornecedorDTO)
    {
        var fornecedor = _mapper.Map<Fornecedor>(fornecedorDTO);

        await _fornecedorRepository.Post(fornecedor);
    }

    public async Task<List<Fornecedor>> Get()
    {
        return await _fornecedorRepository.Get();
    }

    public async Task<Fornecedor?> GetById(int id)
    {
        return await _fornecedorRepository.GetById(id);
    }

    public async Task Put(Fornecedor fornecedor)
    {
        await _fornecedorRepository.Put(fornecedor);
    }

    public async Task Delete(int id)
    {
        await _fornecedorRepository.Delete(id);
    }
}
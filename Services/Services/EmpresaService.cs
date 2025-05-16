using DAO.Interfaces;
using Model.Models;
using Service.Interfaces;

namespace Service.Services;

public class EmpresaService : IEmpresaService
{
    private readonly IEmpresaRepository _empresaRepository;

    public EmpresaService(IEmpresaRepository empresaRepository)
    {
        _empresaRepository = empresaRepository;
    }

    public async Task Post(Empresa empresa)
    {

        await _empresaRepository.Post(empresa);
    }

    public async Task<List<Empresa>> Get()
    {
        return await _empresaRepository.Get();
    }

    public async Task<Empresa?> GetByCNPJ(int cnpj)
    {
        return await _empresaRepository.GetByCNPJ(cnpj);
    }

    public async Task Put(Empresa empresa)
    {
        await _empresaRepository.Put(empresa);
    }

    public async Task Delete(int cnpj)
    {
        await _empresaRepository.Delete(cnpj);
    }
}
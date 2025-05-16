using AutoMapper;
using DAO.Interfaces;
using Model.DTO.Create;
using Model.Models;
using Service.Interfaces;

namespace Service.Services;

public class LognService : ILognService
{
    private readonly ILognRepository _lognRepository;
    private readonly IMapper _mapper;

    public LognService(ILognRepository lognRepository, IMapper mapper)
    {
        _lognRepository = lognRepository;
        _mapper = mapper;
    }

    public async Task Post(CreateLognDTO lognDTO)
    {
        var logn = _mapper.Map<Logn>(lognDTO);

        await _lognRepository.Post(logn);
    }

    public async Task<List<Logn>> Get()
    {
        return await _lognRepository.Get();
    }

    public async Task<Logn?> GetById(int id)
    {
        return await _lognRepository.GetById(id);
    }

    public async Task Put(Logn logn)
    {
        await _lognRepository.Put(logn);
    }

    public async Task Delete(int id)
    {
        await _lognRepository.Delete(id);
    }
}
using AutoMapper;
using Model.DTO.Create;
using Model.Models;

namespace Settings.AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateEnderecoDTO, Endereco>().ReverseMap();

    }
}
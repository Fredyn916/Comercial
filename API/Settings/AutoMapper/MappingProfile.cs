using AutoMapper;
using Model.DTO.Create;
using Model.Models;

namespace Settings.AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Create DTO
        CreateMap<CreateEnderecoDTO, Endereco>().ReverseMap();
        CreateMap<CreateDepartamentoDTO, Departamento>().ReverseMap();
        CreateMap<CreateCargosDTO, Cargos>().ReverseMap();
        CreateMap<CreateFuncionariosDTO, Funcionarios>().ReverseMap();
        CreateMap<CreateLognDTO, Logn>().ReverseMap();
        CreateMap<CreateTipomercadoriaDTO, Tipomercadoria>().ReverseMap();
        CreateMap<CreateMercadoriasDTO, Mercadorias>().ReverseMap();
        CreateMap<CreateFornecedorDTO, Fornecedor>().ReverseMap();
        CreateMap<CreateLoginclienteDTO, Logincliente>().ReverseMap();
        CreateMap<CreateTabelaComprasDTO, TabelaCompras>().ReverseMap();
        CreateMap<CreateTabelaComprasMercadoriasDTO, TabelaComprasMercadorias>().ReverseMap();
    }
}
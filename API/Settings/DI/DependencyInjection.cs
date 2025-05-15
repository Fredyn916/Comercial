using DAO.Interfaces;
using DAO.Repositories;
using Service.Interfaces;
using Service.Services;

namespace API.Settings.DI;

public static class DependencyInjection
{
    public static void Inject(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();
        builder.Services.AddScoped<IEmpresaRepository, EmpresaRepository>();
        builder.Services.AddScoped<IDepartamentoRepository, DepartamentoRepository>();
        builder.Services.AddScoped<ICargosRepository, CargosRepository>();
        builder.Services.AddScoped<IFuncionariosRepository, FuncionariosRepository>();
        builder.Services.AddScoped<ILognRepository, LognRepository>();
        builder.Services.AddScoped<ITipomercadoriaRepository, TipomercadoriaRepository>();
        builder.Services.AddScoped<IMercadoriasRepository, MercadoriasRepository>();
        builder.Services.AddScoped<IFornecedorRepository, FornecedorRepository>();
        builder.Services.AddScoped<IFornecedor_has_MercadoriasRepository, Fornecedor_has_MercadoriasRepository>();
        builder.Services.AddScoped<ILoginClienteRepository, LoginClienteRepository>();
        builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
        builder.Services.AddScoped<ITabelaComprasRepository, TabelaComprasRepository>();
        builder.Services.AddScoped<ITabelaComprasMercadoriasRepository, TabelaComprasMercadoriasRepository>();

        builder.Services.AddScoped<IEnderecoService, EnderecoService>();
    }
}
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
        builder.Services.AddScoped<ILoginclienteRepository, LoginclienteRepository>();
        builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
        builder.Services.AddScoped<ITabelaComprasRepository, TabelaComprasRepository>();
        builder.Services.AddScoped<ITabelaComprasMercadoriasRepository, TabelaComprasMercadoriasRepository>();

        builder.Services.AddScoped<IEnderecoService, EnderecoService>();
        builder.Services.AddScoped<IEmpresaService, EmpresaService>();
        builder.Services.AddScoped<IDepartamentoService, DepartamentoService>();
        builder.Services.AddScoped<ICargosService, CargosService>();
        builder.Services.AddScoped<IFuncionariosService, FuncionariosService>();
        builder.Services.AddScoped<ILognService, LognService>();
        builder.Services.AddScoped<ITipomercadoriaService, TipomercadoriaService>();
        builder.Services.AddScoped<IMercadoriasService, MercadoriasService>();
        builder.Services.AddScoped<IFornecedorService, FornecedorService>();
        builder.Services.AddScoped<IFornecedor_has_MercadoriasService, Fornecedor_has_MercadoriasService>();
        builder.Services.AddScoped<ILoginclienteService, LoginclienteService>();
        builder.Services.AddScoped<IClienteService, ClienteService>();
        builder.Services.AddScoped<ITabelaComprasService, TabelaComprasService>();
        builder.Services.AddScoped<ITabelaComprasMercadoriasService, TabelaComprasMercadoriasService>();
    }
}
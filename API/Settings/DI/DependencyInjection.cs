using DAO.Interfaces;
using DAO.Repositories;

namespace API.Settings.DI;

public static class DependencyInjection
{
    public static void Inject(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();
        builder.Services.AddScoped<IEmpresaRepository, EmpresaRepository>();

        // builder.Services.AddScoped<IUsuarioService, UsuarioService>();
    }
}
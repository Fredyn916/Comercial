using DAO.Interfaces;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Model.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO.Repositories;

public class EmpresaRepository : IEmpresaRepository
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;

    public EmpresaRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("DefaultConnection");
    }

    private IDbConnection _connection => new MySqlConnection(_connectionString);

    public async Task Post(Empresa empresa)
    {
        using var db = _connection;

        await db.InsertAsync(empresa);
    }

    public async Task<List<Empresa>> Get()
    {
        using var db = _connection;

        var empresas = await db.GetAllAsync<Empresa>();

        return empresas.ToList();
    }

    public async Task<Empresa?> GetByCNPJ(int cnpj)
    {
        using var db = _connection;

        return await db.GetAsync<Empresa>(cnpj);
    }

    public async Task Put(Empresa empresa)
    {
        using var db = _connection;

        await db.UpdateAsync(empresa);
    }

    public async Task Delete(int cnpj)
    {
        using var db = _connection;

        var empresa = await GetByCNPJ(cnpj);

        if (empresa != null) await db.DeleteAsync(empresa);
    }
}
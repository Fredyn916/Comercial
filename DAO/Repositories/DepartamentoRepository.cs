using DAO.Interfaces;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Model.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO.Repositories;

public  class DepartamentoRepository : IDepartamentoRepository
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;

    public DepartamentoRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("DefaultConnection");
    }

    private IDbConnection _connection => new MySqlConnection(_connectionString);

    public async Task Post(Departamento departamento)
    {
        using var db = _connection;

        await db.InsertAsync(departamento);
    }

    public async Task<List<Departamento>> Get()
    {
        using var db = _connection;

        var departamentos = await db.GetAllAsync<Departamento>();

        return departamentos.ToList();
    }

    public async Task<Departamento?> GetByDepartamentoId(int id)
    {
        using var db = _connection;

        var sql = "SELECT * FROM dbcomercial.departamento WHERE idDepartamento = @idDep;";

        return await db.QueryFirstOrDefaultAsync<Departamento>(sql, new { idDep = id });
    }

    public async Task<Departamento?> GetByEnderecoId(int id)
    {
        using var db = _connection;

        var sql = "SELECT * FROM dbcomercial.departamento WHERE Endereco_IdEndereco = @idEnd;";

        return await db.QueryFirstOrDefaultAsync<Departamento>(sql, new { idEnd = id });
    }

    public async Task Put(Departamento departamento)
    {
        using var db = _connection;

        await db.UpdateAsync(departamento);
    }

    public async Task Delete(int id)
    {
        using var db = _connection;

        var departamento = await GetByDepartamentoId(id);

        if (departamento != null) await db.DeleteAsync(departamento);
    }
}
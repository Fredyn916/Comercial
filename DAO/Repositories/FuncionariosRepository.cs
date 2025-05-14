using DAO.Interfaces;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Model.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO.Repositories;

public class FuncionariosRepository : IFuncionariosRepository
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;

    public FuncionariosRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("DefaultConnection");
    }

    private IDbConnection _connection => new MySqlConnection(_connectionString);

    public async Task Post(Funcionarios funcionario)
    {
        using var db = _connection;

        await db.InsertAsync(funcionario);
    }

    public async Task<List<Funcionarios>> Get()
    {
        using var db = _connection;

        var funcionarios = await db.GetAllAsync<Funcionarios>();

        return funcionarios.ToList();
    }

    public async Task<Funcionarios?> GetById(int id)
    {
        using var db = _connection;

        return await db.GetAsync<Funcionarios>(id);
    }

    public async Task Put(Funcionarios funcionario)
    {
        using var db = _connection;

        await db.UpdateAsync(funcionario);
    }

    public async Task Delete(int id)
    {
        using var db = _connection;

        var funcionario = await GetById(id);

        if (funcionario != null) await db.DeleteAsync(funcionario);
    }
}
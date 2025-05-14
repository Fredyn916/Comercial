using DAO.Interfaces;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Model.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO.Repositories;

public  class CargosRepository : ICargosRepository
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;

    public CargosRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("DefaultConnection");
    }

    private IDbConnection _connection => new MySqlConnection(_connectionString);

    public async Task Post(Cargos cargo)
    {
        using var db = _connection;

        await db.InsertAsync(cargo);
    }

    public async Task<List<Cargos>> Get()
    {
        using var db = _connection;

        var cargos = await db.GetAllAsync<Cargos>();

        return cargos.ToList();
    }

    public async Task<Cargos?> GetById(int id)
    {
        using var db = _connection;

        return await db.GetAsync<Cargos>(id);
    }

    public async Task Put(Cargos cargo)
    {
        using var db = _connection;

        await db.UpdateAsync(cargo);
    }

    public async Task Delete(int id)
    {
        using var db = _connection;

        var cargo = await GetById(id);

        if (cargo != null) await db.DeleteAsync(cargo);
    }
}
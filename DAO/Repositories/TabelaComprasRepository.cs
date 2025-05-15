using DAO.Interfaces;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Model.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO.Repositories;

public class TabelaComprasRepository : ITabelaComprasRepository
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;

    public TabelaComprasRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("DefaultConnection");
    }

    private IDbConnection _connection => new MySqlConnection(_connectionString);

    public async Task Post(TabelaCompras tabelaCompras)
    {
        using var db = _connection;

        await db.InsertAsync(tabelaCompras);
    }

    public async Task<List<TabelaCompras>> Get()
    {
        using var db = _connection;

        var tabelasCompras = await db.GetAllAsync<TabelaCompras>();

        return tabelasCompras.ToList();
    }

    public async Task<TabelaCompras?> GetById(int id)
    {
        using var db = _connection;

        return await db.GetAsync<TabelaCompras>(id);
    }

    public async Task Put(TabelaCompras tabelaCompras)
    {
        using var db = _connection;

        await db.UpdateAsync(tabelaCompras);
    }

    public async Task Delete(int id)
    {
        using var db = _connection;

        var tabelaCompras = await GetById(id);

        if (tabelaCompras != null) await db.DeleteAsync(tabelaCompras);
    }
}
using DAO.Interfaces;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Model.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO.Repositories;

public class TabelaComprasMercadoriasRepository : ITabelaComprasMercadoriasRepository
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;

    public TabelaComprasMercadoriasRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("DefaultConnection");
    }

    private IDbConnection _connection => new MySqlConnection(_connectionString);

    public async Task Post(TabelaComprasMercadorias tabelaComprasMercadorias)
    {
        using var db = _connection;

        await db.InsertAsync(tabelaComprasMercadorias);
    }

    public async Task<List<TabelaComprasMercadorias>> Get()
    {
        using var db = _connection;

        var tabelasComprasMercadorias = await db.GetAllAsync<TabelaComprasMercadorias>();

        return tabelasComprasMercadorias.ToList();
    }

    public async Task<TabelaComprasMercadorias?> GetById(int id)
    {
        using var db = _connection;

        return await db.GetAsync<TabelaComprasMercadorias>(id);
    }

    public async Task Put(TabelaComprasMercadorias tabelaComprasMercadorias)
    {
        using var db = _connection;

        await db.UpdateAsync(tabelaComprasMercadorias);
    }

    public async Task Delete(int id)
    {
        using var db = _connection;

        var tabelaComprasMercadorias = await GetById(id);

        if (tabelaComprasMercadorias != null) await db.DeleteAsync(tabelaComprasMercadorias);
    }
}
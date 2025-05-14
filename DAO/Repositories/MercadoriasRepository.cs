using DAO.Interfaces;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Model.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO.Repositories;

public class MercadoriasRepository : IMercadoriasRepository
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;

    public MercadoriasRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("DefaultConnection");
    }

    private IDbConnection _connection => new MySqlConnection(_connectionString);

    public async Task Post(Mercadorias mercadoria)
    {
        using var db = _connection;

        await db.InsertAsync(mercadoria);
    }

    public async Task<List<Mercadorias>> Get()
    {
        using var db = _connection;

        var mercadorias = await db.GetAllAsync<Mercadorias>();

        return mercadorias.ToList();
    }

    public async Task<Mercadorias?> GetById(int id)
    {
        using var db = _connection;

        return await db.GetAsync<Mercadorias>(id);
    }

    public async Task Put(Mercadorias mercadoria)
    {
        using var db = _connection;

        await db.UpdateAsync(mercadoria);
    }

    public async Task Delete(int id)
    {
        using var db = _connection;

        var mercadoria = await GetById(id);

        if (mercadoria != null) await db.DeleteAsync(mercadoria);
    }
}
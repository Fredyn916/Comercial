using DAO.Interfaces;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Model.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO.Repositories;

public class LognRepository : ILognRepository
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;

    public LognRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("DefaultConnection");
    }

    private IDbConnection _connection => new MySqlConnection(_connectionString);

    public async Task Post(Logn logn)
    {
        using var db = _connection;

        await db.InsertAsync(logn);
    }

    public async Task<List<Logn>> Get()
    {
        using var db = _connection;

        var logns = await db.GetAllAsync<Logn>();

        return logns.ToList();
    }

    public async Task<Logn?> GetById(int id)
    {
        using var db = _connection;

        return await db.GetAsync<Logn>(id);
    }

    public async Task Put(Logn logn)
    {
        using var db = _connection;

        await db.UpdateAsync(logn);
    }

    public async Task Delete(int id)
    {
        using var db = _connection;

        var logn = await GetById(id);

        if (logn != null) await db.DeleteAsync(logn);
    }
}
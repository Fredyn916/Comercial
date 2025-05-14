using DAO.Interfaces;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Model.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO.Repositories;

public class LoginClienteRepository : ILoginClienteRepository
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;

    public LoginClienteRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("DefaultConnection");
    }

    private IDbConnection _connection => new MySqlConnection(_connectionString);

    public async Task Post(LoginCliente loginCliente)
    {
        using var db = _connection;

        await db.InsertAsync(loginCliente);
    }

    public async Task<List<LoginCliente>> Get()
    {
        using var db = _connection;

        var loginsCliente = await db.GetAllAsync<LoginCliente>();

        return loginsCliente.ToList();
    }

    public async Task<LoginCliente?> GetById(int id)
    {
        using var db = _connection;

        return await db.GetAsync<LoginCliente>(id);
    }

    public async Task Put(LoginCliente loginCliente)
    {
        using var db = _connection;

        await db.UpdateAsync(loginCliente);
    }

    public async Task Delete(int id)
    {
        using var db = _connection;

        var loginCliente = await GetById(id);

        if (loginCliente != null) await db.DeleteAsync(loginCliente);
    }
}
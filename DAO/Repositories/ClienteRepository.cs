using DAO.Interfaces;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Model.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;

    public ClienteRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("DefaultConnection");
    }

    private IDbConnection _connection => new MySqlConnection(_connectionString);

    public async Task Post(Cliente cliente)
    {
        using var db = _connection;

        await db.InsertAsync(cliente);
    }

    public async Task<List<Cliente>> Get()
    {
        using var db = _connection;

        var clientes = await db.GetAllAsync<Cliente>();

        return clientes.ToList();
    }

    public async Task<Cliente?> GetByCPF(int cpf)
    {
        using var db = _connection;

        return await db.GetAsync<Cliente>(cpf);
    }

    public async Task Put(Cliente cliente)
    {
        using var db = _connection;

        await db.UpdateAsync(cliente);
    }

    public async Task Delete(int cpf)
    {
        using var db = _connection;

        var cliente = await GetByCPF(cpf);

        if (cliente != null) await db.DeleteAsync(cliente);
    }
}
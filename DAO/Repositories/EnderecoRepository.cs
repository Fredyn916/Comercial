using DAO.Interfaces;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Model.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO.Repositories;

public class EnderecoRepository : IEnderecoRepository
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;

    public EnderecoRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("DefaultConnection");
    }

    private IDbConnection _connection => new MySqlConnection(_connectionString);

    public async Task Post(Endereco endereco)
    {
        using var db = _connection;

        await db.InsertAsync(endereco);
    }

    public async Task<List<Endereco>> Get()
    {
        using var db = _connection;

        var enderecos = await db.GetAllAsync<Endereco>();

        return enderecos.ToList();
    }

    public async Task<Endereco?> GetById(int id)
    {
        using var db = _connection;

        return await db.GetAsync<Endereco>(id);
    }

    public async Task Put(Endereco endereco)
    {
        using var db = _connection;

        await db.UpdateAsync (endereco);
    }

    public async Task Delete(int id)
    {
        using var db = _connection;

        var endereco = await GetById(id);

        if (endereco != null) await db.DeleteAsync(endereco);
    }
}
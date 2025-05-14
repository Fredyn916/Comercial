using DAO.Interfaces;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Model.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO.Repositories;

public class FornecedorRepository : IFornecedorRepository
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;

    public FornecedorRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("DefaultConnection");
    }

    private IDbConnection _connection => new MySqlConnection(_connectionString);

    public async Task Post(Fornecedor fornecedor)
    {
        using var db = _connection;

        await db.InsertAsync(fornecedor);
    }

    public async Task<List<Fornecedor>> Get()
    {
        using var db = _connection;

        var fornecedores = await db.GetAllAsync<Fornecedor>();

        return fornecedores.ToList();
    }

    public async Task<Fornecedor?> GetById(int id)
    {
        using var db = _connection;

        return await db.GetAsync<Fornecedor>(id);
    }

    public async Task Put(Fornecedor fornecedor)
    {
        using var db = _connection;

        await db.UpdateAsync(fornecedor);
    }

    public async Task Delete(int id)
    {
        using var db = _connection;

        var fornecedor = await GetById(id);

        if (fornecedor != null) await db.DeleteAsync(fornecedor);
    }
}
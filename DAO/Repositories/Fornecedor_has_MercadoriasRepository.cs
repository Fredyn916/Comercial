using DAO.Interfaces;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Model.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO.Repositories;

public class Fornecedor_has_MercadoriasRepository : IFornecedor_has_MercadoriasRepository
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;

    public Fornecedor_has_MercadoriasRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("DefaultConnection");
    }

    private IDbConnection _connection => new MySqlConnection(_connectionString);

    public async Task Post(Fornecedor_has_Mercadorias fornecedorHasMercadorias)
    {
        using var db = _connection;

        await db.InsertAsync(fornecedorHasMercadorias);
    }

    public async Task<List<Fornecedor_has_Mercadorias>> Get()
    {
        using var db = _connection;

        var sql = "SELECT * FROM fornecedor_has_mercadorias";

        var result = await _connection.QueryAsync<Fornecedor_has_Mercadorias>(sql);

        return result.ToList();
    }

    public async Task<Fornecedor_has_Mercadorias?> GetByFornecedorId(int id)
    {
        using var db = _connection;

        var sql = "SELECT * FROM dbcomercial.fornecedor_has_mercadorias WHERE Fornecedor_idFornecedor = @idFor;";

        return await db.QueryFirstOrDefaultAsync<Fornecedor_has_Mercadorias>(sql, new { idFor = id });
    }

    public async Task<Fornecedor_has_Mercadorias?> GetByMercadoriasId(int id)
    {
        using var db = _connection;

        var sql = "SELECT * FROM dbcomercial.fornecedor_has_mercadorias WHERE Mercadorias_idMercadorias = @idMer;";

        return await db.QueryFirstOrDefaultAsync<Fornecedor_has_Mercadorias>(sql, new { idMer = id });
    }

    public async Task Put(Fornecedor_has_Mercadorias fornecedorHasMercadorias)
    {
        using var db = _connection;

        await db.UpdateAsync(fornecedorHasMercadorias);
    }

    public async Task DeleteByFornecedorId(int id)
    {
        using var db = _connection;

        var fornecedorHasMercadorias = await GetByFornecedorId(id);

        if (fornecedorHasMercadorias != null) await db.DeleteAsync(fornecedorHasMercadorias);
    }

    public async Task DeleteByMercadoriasId(int id)
    {
        using var db = _connection;

        var fornecedorHasMercadorias = await GetByMercadoriasId(id);

        if (fornecedorHasMercadorias != null) await db.DeleteAsync(fornecedorHasMercadorias);
    }
}
using Dapper.Contrib.Extensions;
using Dapper;
using Microsoft.Extensions.Configuration;
using Model.Models;
using MySql.Data.MySqlClient;
using System.Data;
using DAO.Interfaces;

namespace DAO.Repositories;

public class TipomercadoriaRepository : ITipomercadoriaRepository
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;

    public TipomercadoriaRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("DefaultConnection");
    }

    private IDbConnection _connection => new MySqlConnection(_connectionString);

    public async Task Post(Tipomercadoria tipoMercadoria)
    {
        using var db = _connection;

        await db.InsertAsync(tipoMercadoria);
    }

    public async Task<List<Tipomercadoria>> Get()
    {
        using var db = _connection;

        var tiposMercadoria = await db.GetAllAsync<Tipomercadoria>();

        return tiposMercadoria.ToList();
    }

    public async Task<Tipomercadoria?> GetByTipomercadoriaId(int id)
    {
        using var db = _connection;

        var sql = "SELECT * FROM dbcomercial.tipomercadoria WHERE idTipoMercadoria = @idTip;";

        return await db.QueryFirstOrDefaultAsync<Tipomercadoria>(sql, new { idTip = id });
    }

    public async Task<Tipomercadoria?> GetByDepartamentoId(int id)
    {
        using var db = _connection;

        var sql = "SELECT * FROM dbcomercial.tipomercadoria WHERE Departamento_idDepartamento = @idDep;";

        return await db.QueryFirstOrDefaultAsync<Tipomercadoria>(sql, new { idDep = id });
    }

    public async Task<Tipomercadoria?> GetByEnderecoId(int id)
    {
        using var db = _connection;

        var sql = "SELECT * FROM dbcomercial.tipomercadoria WHERE Departamento_Endereco_IdEndereco = @idEnd;";

        return await db.QueryFirstOrDefaultAsync<Tipomercadoria>(sql, new { idEnd = id });
    }

    public async Task Put(Tipomercadoria tipoMercadoria)
    {
        using var db = _connection;

        await db.UpdateAsync(tipoMercadoria);
    }

    public async Task DeleteByTipomercadoriaId(int id)
    {
        using var db = _connection;

        var tipoMercadoria = await GetByTipomercadoriaId(id);

        if (tipoMercadoria != null) await db.DeleteAsync(tipoMercadoria);
    }

    public async Task DeleteByDepartamentoId(int id)
    {
        using var db = _connection;

        var tipoMercadoria = await GetByDepartamentoId(id);

        if (tipoMercadoria != null) await db.DeleteAsync(tipoMercadoria);
    }

    public async Task DeleteByEnderecoId(int id)
    {
        using var db = _connection;

        var tipoMercadoria = await GetByEnderecoId(id);

        if (tipoMercadoria != null) await db.DeleteAsync(tipoMercadoria);
    }
}
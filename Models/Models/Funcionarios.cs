﻿using Dapper.Contrib.Extensions;

namespace Model.Models;

[Table("funcionarios")]
public class Funcionarios
{
    [Key]
    public int idFuncionarios { get; set; }
    public string? NomeFuncionario { get; set; }
    public required string CPFFuncionario { get; set; }
    public required DateTime DataNascimento { get; set; }
    public required DateTime DataContrato { get; set; }
    public DateTime? DataDemissao { get; set; }
    public string? CEPFuncionario { get; set; }
    public string? RuaFuncionario { get; set; }
    public string? BairroFuncionario { get; set; }
    public string? NumResidenciaFuncionario { get; set; }
    public string? ComplFuncionario { get; set; }
    public string? UFFuncionario { get; set; }
    public string? TelefoneFuncionario { get; set; }
    public string? CelularFuncionario { get; set; }
    public int? IdDepartamentoFuncionario { get; set; }
    public required int Cargos_idCargos { get; set; }
    public string? EmailFuncionario { get; set; }
    public required int Departamento_idDepartamento { get; set; }
    public required int Departamento_Endereco_IdEndereco { get; set; }
}
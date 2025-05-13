using Dapper.Contrib.Extensions;

namespace Model.Models;

[Table("empresa")]
public class Empresa
{
    [ExplicitKey]
    public required int CNPJ { get; set; }
    public string? RazaoSocial { get; set; }
    public string? NomeFantasia { get; set; }
    public string? TelefoneEmpresa { get; set; }
    public string? CelularEmpresa { get; set; }
    public required int Endereco_IdEndereco { get; set; }
    public string? EmailEmpresa { get; set; }
}
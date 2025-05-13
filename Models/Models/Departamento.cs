using Dapper.Contrib.Extensions;

namespace Model.Models;

[Table("departamento")]
public class Departamento
{
    [Key]
    public int idDepartamento { get; set; }
    public string? NomeDepartamento { get; set; }
    public string? TelefoneDepartamento { get; set; }
    public string? CelularDepartamento { get; set; }
    public string? EmailDepartamento { get; set; }
    [ExplicitKey]
    public required int Endereco_IdEndereco { get; set; }
}
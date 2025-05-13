using Dapper.Contrib.Extensions;

namespace Model.Models;

[Table("logn")]
public class Logn
{
    [Key]
    public int idLogn { get; set; }
    public required string LognFuncionario { get; set; }
    public required string SenhaFuncionario { get; set; }
    public required int Funcionarios_idFuncionarios { get; set; }
}
using Dapper.Contrib.Extensions;

namespace Model.Models;

[Table("cargos")]
public class Cargos
{
    [Key]
    public int idCargos { get; set; }
    public required string Cargo { get; set; }
}
using Dapper.Contrib.Extensions;

namespace Model.Models;

[Table("logincliente")]
public class Logincliente
{
    [Key]
    public int idLoginCliente { get; set; }
    public string? LoginCliente { get; set; }
    public string? SenhaCliente { get; set; }
}
using Dapper.Contrib.Extensions;

namespace Model.Models;

[Table("logincliente")]
public class LoginCliente
{
    [Key]
    public int idLoginCliente { get; set; }
    public string? MyProperty { get; set; }
    public string? SenhaCliente { get; set; }
}
using Dapper.Contrib.Extensions;

namespace Model.Models;

[Table("cliente")]
public class Cliente
{
    [ExplicitKey]
    public required int CPFCliente { get; set; }
    public required string NomeCliente { get; set; }
    public DateOnly? DtNascimentoCliente { get; set; }
    public required string ViaCliente { get; set; }
    public required string NumCliente { get; set; }
    public required string ComplCliente { get; set; }
    public required string BairroCliente { get; set; }
    public required string CidadeCliente { get; set; }
    public required string UFCliente { get; set; }
    public required string CEPCliente { get; set; }
    public required string TelefoneCliente { get; set; }
    public required string CelularCliente { get; set; }
    public required string EmailCliente { get; set; }
    public required int Empresa_CNPJ { get; set; }
    public required int LoginCliente_idLoginCliente { get; set; }
}
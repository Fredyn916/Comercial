using Dapper.Contrib.Extensions;

namespace Model.Models;

[Table("fornecedor_has_mercadorias")]
public class Fornecedor_has_Mercadorias
{
    [Key]
    public int Fornecedor_idFornecedor { get; set; }
    [ExplicitKey]
    public required int Mercadorias_idMercadorias { get; set; }
}
using Dapper.Contrib.Extensions;

namespace Model.Models;

[Table("tabelacompras")]
public class TabelaCompras
{
    [Key]
    public int idTabelaCompras { get; set; }
    public float? PrecoMercadoria { get; set; }
    public int? QtdMercadoria { get; set; }
    public required int Cliente_CPFCliente { get; set; }
}
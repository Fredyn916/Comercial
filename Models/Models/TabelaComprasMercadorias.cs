using Dapper.Contrib.Extensions;

namespace Model.Models;

[Table("tabelacomprasmercadorias")]
public class TabelaComprasMercadorias
{
    [Key]
    public int idTabelaComprasMercadorias { get; set; }
    public required int idCompraMercadoria { get; set; }
    public required float PrecoCompraMercadoria { get; set; }
    public required int QtdCompraMercadoria { get; set; }
    public required int TabelaCompras_idTabelaCompras { get; set; }
    public required int Mercadorias_idMercadorias { get; set; }
}
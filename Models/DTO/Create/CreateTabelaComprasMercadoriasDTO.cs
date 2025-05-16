namespace Model.DTO.Create;

public class CreateTabelaComprasMercadoriasDTO
{
    public required int idCompraMercadoria { get; set; }
    public required float PrecoCompraMercadoria { get; set; }
    public required int QtdCompraMercadoria { get; set; }
    public required int TabelaCompras_idTabelaCompras { get; set; }
    public required int Mercadorias_idMercadorias { get; set; }
}
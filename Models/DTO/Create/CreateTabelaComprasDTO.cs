namespace Model.DTO.Create;

public class CreateTabelaComprasDTO
{
    public float? PrecoMercadoria { get; set; }
    public int? QtdMercadoria { get; set; }
    public required int Cliente_CPFCliente { get; set; }
}
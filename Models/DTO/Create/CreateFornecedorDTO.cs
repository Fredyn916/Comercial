namespace Model.DTO.Create;

public class CreateFornecedorDTO
{
    public required string NomeFornecedor { get; set; }
    public required string CNPJFornecedor { get; set; }
    public required string CEPFornecedor { get; set; }
    public required string RuaFornecedor { get; set; }
    public required string NumFornecedor { get; set; }
    public string? ComplFornecedor { get; set; }
    public string? BairroFornecedor { get; set; }
    public string? CidadeFornecedor { get; set; }
    public string? UFFornecedor { get; set; }
    public required string TelefoneFornecedor { get; set; }
    public required string CelularFornecedor { get; set; }
    public string? EmailFornecedor { get; set; }
}
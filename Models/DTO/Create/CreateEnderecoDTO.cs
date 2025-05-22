namespace Model.DTO.Create;

public class CreateEnderecoDTO
{
    public required string CEP { get; set; }
    public int? TipoVia { get; set; }
    public string? NomeVia { get; set; }
    public string? Numero { get; set; }
    public string? Complemento { get; set; }
    public string? Bairro { get; set; }
    public string? Cidade { get; set; }
    public string? UF { get; set; }
}
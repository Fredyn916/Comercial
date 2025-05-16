namespace Model.DTO.Create;

public class CreateDepartamentoDTO
{
    public string? NomeDepartamento { get; set; }
    public string? TelefoneDepartamento { get; set; }
    public string? CelularDepartamento { get; set; }
    public string? EmailDepartamento { get; set; }
    public required int Endereco_IdEndereco { get; set; }
}
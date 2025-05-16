namespace Model.DTO.Create;

public class CreateTipomercadoriaDTO
{
    public required string TipoMercadoria { get; set; }
    public required int Departamento_idDepartamento { get; set; }
    public required int Departamento_Endereco_IdEndereco { get; set; }
}
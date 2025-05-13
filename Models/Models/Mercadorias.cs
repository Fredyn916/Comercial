using Dapper.Contrib.Extensions;

namespace Model.Models;

[Table("mercadorias")]
public class Mercadorias
{
    [Key]
    public int idMercadorias { get; set; }
    public required string TituloMercadoria { get; set; }
    public string? DescricaoMercadoria { get; set; }
    public string? FabricanteFornecedorMercadoria { get; set; }
    public required float PrecoCompraMercadoria { get; set; }
    public required float PrecoVendaMercadoria { get; set; }
    public string? LoteMercadoria { get; set; }
    public int? QtdMercadoria { get; set; }
    public required int QtdMinMercadoria { get; set; }
    public int? QtdMaxMercadoria { get; set; }
    public required int TipoMercadoria_idTipoMercadoria { get; set; }
    public required int TipoMercadoria_Departamento_idDepartamento { get; set; }
    public required int TipoMercadoria_Departamento_Endereco_IdEndereco { get; set; }
    public required int Empresa_CNPJ { get; set; }
}
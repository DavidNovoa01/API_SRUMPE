namespace Shared.DataTransferObjects;

public record CandidatoEstudianteDto
{
    public Guid CandidatoEstudianteId { get; set; }
    public string Nombre { get; set; } = null!;
    public string Apellido { get; set; } = null!;
    public DateTime? FechaNacimiento { get; set; }
    public string? TipoPersona { get; set; }
    public string? TipoDocumento { get; set; }
    public long NumeroDocumento { get; set; }
    public long NumeroContacto { get; set; }
    public string? Direccion { get; set; }
    public string? Genero { get; set; }
    public string AdjuntarDocumentos { get; set; }
}

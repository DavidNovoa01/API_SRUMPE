namespace Shared.DataTransferObjects
{
    public record EstudianteDocumentosDto(
        Guid EstudianteDocumentosId,
        string NombreDocumento,
        string TipoDocumento,
        int NumeroDocumento,
        bool Estado,
        string Observaciones,
        DateTime? FechaActualizacion,
        string Ubicacion,
        int Tamaño)
    {
        public EstudianteDocumentosDto() : this(default, string.Empty, string.Empty, 0, false, string.Empty, null, string.Empty, 0)
        {
            // Constructor sin argumentos
        }
    }
}

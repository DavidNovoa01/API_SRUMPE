using Entities.Models.D_Estudiante;


namespace Shared.DataTransferObjects
{
    public record CandidatoEstudianteForUpdateDto(string Nombre, string Apellido, DateTime? FechaNacimiento, string? TipoPersona, string? TipoDocumento, long NumeroDocumento, long NumeroContacto, string? Direccion,  string? Genero,  string AdjuntarDocumentos);


    public static class CandidatoEstudianteMapper
    {
        public static CandidatoEstudiante MapToCandidatoEstudiante(CandidatoEstudianteForUpdateDto dto)
        {
            return new CandidatoEstudiante
            {
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                FechaNacimiento = dto.FechaNacimiento,
                TipoPersona = dto.TipoPersona,
                TipoDocumento = dto.TipoDocumento,
                NumeroContacto = dto.NumeroContacto,
                NumeroDocumento = dto.NumeroDocumento,
                Direccion = dto.Direccion,
                Genero = dto.Genero,    
                AdjuntarDocumentos = dto.AdjuntarDocumentos
            };
        }
    }
}

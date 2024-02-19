namespace Shared.DataTransferObjects;

public record DocenteForCreationDto(Guid DocenteId, string Nombre, DateTime FechaNacimiento, string Genero, string Direccion,  string CorreoElectronico, string NumeroTelefono, DateTime FechaContratacion, string CursosAsignados, string HorarioClases,string EstadoLaboral, string NumeroIdentificacion,string ComentariosNotas,string NivelExperiencia,
IEnumerable<DocenteForCreationDto>? Docentes);



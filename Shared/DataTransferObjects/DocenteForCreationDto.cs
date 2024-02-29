﻿namespace Shared.DataTransferObjects;

public record DocenteForCreationDto(
    string Nombre,
    DateTime FechaNacimiento,
    string Genero,
    string Direccion,
    string CorreoElectronico,
    string NumeroTelefono,
    DateTime FechaContratacion,
    string CursosAsignados,
    string HorarioClases,
    string EstadoLaboral,
    string NumeroIdentificacion,
    string ComentariosNotas,
    string NivelExperiencia,
    ICollection<Guid>? CursoIds,
    ICollection<Guid>? MateriaIds,
    Guid HorarioId,
    Guid AulaId
);

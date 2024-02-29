﻿using Entities.Models.D_DepartamentoAcademico;
using Entities.Models.D_Docente;


namespace Shared.DataTransferObjects;

public record DocenteForUpdateDto(
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
    ICollection<Guid> CursoIds,
    ICollection<Guid> MateriaIds,
    Guid HorarioId,
    Guid AulaId
)

{
    public static Docente MapToDocente(DocenteForUpdateDto dto)
    {
        return new Docente
        {
            Nombre = dto.Nombre,
            FechaNacimiento = dto.FechaNacimiento,
            Genero = dto.Genero,
            Direccion = dto.Direccion,
            CorreoElectronico = dto.CorreoElectronico,
            NumeroTelefono = dto.NumeroTelefono,
            FechaContratacion = dto.FechaContratacion,
            CursosAsignados = dto.CursosAsignados,
            HorarioClases = dto.HorarioClases,
            EstadoLaboral = dto.EstadoLaboral,
            NumeroIdentificacion = dto.NumeroIdentificacion,
            ComentariosNotas = dto.ComentariosNotas,
            NivelExperiencia = dto.NivelExperiencia,
        };
    }
}
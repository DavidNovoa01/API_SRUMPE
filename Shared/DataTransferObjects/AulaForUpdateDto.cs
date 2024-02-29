﻿using Entities.Models.D_DepartamentoAcademico;
using Entities.Models.D_Docente;

namespace Shared.DataTransferObjects
{
    public record AulaForUpdateDto
    (
        string NombreNumero,
        string Ubicacion,
        int Capacidad,
        string TipoAula,
        string EstadoAula,
        string HorarioDisponibilidad,
        string NotasAdicionales,
        DateTime UltimaActualizacion,
        string ResponsableAula,
        string RegistrosIncidentesProblemas,

        string? DocenteNombre
    );

    public static class AulaMapper
    {
        public static Aulas MapToCandidatoEstudiante(AulaForUpdateDto dto)
        {
            return new Aulas
            {
                NombreNumero = dto.NombreNumero,
                Ubicacion = dto.Ubicacion,
                Capacidad = dto.Capacidad,
                TipoAula = dto.TipoAula,
                EstadoAula = dto.EstadoAula,
                HorarioDisponibilidad = dto.HorarioDisponibilidad,
                NotasAdicionales = dto.NotasAdicionales,
                UltimaActualizacion = dto.UltimaActualizacion,
                RegistrosIncidentesProblemas = dto.RegistrosIncidentesProblemas,
                Docente = new Docente { Nombre = dto.DocenteNombre }
            };
        }
    }
}



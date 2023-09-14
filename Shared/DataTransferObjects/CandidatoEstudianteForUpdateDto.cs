using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record CandidatoEstudianteForUpdateDto(string Nombre, string Apellido, DateTime? FechaNacimiento, string? TipoPersona);

    public static class CandidatoEstudianteMapper
    {
        public static CandidatoEstudiante MapToCandidatoEstudiante(CandidatoEstudianteForUpdateDto dto)
        {
            return new CandidatoEstudiante
            {
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                FechaNacimiento = dto.FechaNacimiento,
                TipoPersona = dto.TipoPersona
            };
        }
    }
}

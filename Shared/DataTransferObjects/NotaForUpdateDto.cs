using Entities.Models.D_Notas;

namespace Shared.DataTransferObjects
{
    public record NotaForUpdateDto(string Titulo, int Valor, DateTime FechaCreacion, string Materia, string Periodo)
    {
        public static Notas MapToNotas(NotaForUpdateDto dto)
        {
            return new Notas
            {
                Titulo = dto.Titulo,
                Valor = dto.Valor,
                FechaCreacion = dto.FechaCreacion,
                Materia = dto.Materia,
                Periodo = dto.Periodo
            };
        }
    }
}

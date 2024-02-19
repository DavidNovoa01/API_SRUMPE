namespace Shared.DataTransferObjects
{
    public record NotaForCreationDto(string Titulo,int Valor,DateTime FechaCreacion,string Materia,string Periodo,
        IEnumerable<NotaForCreationDto>? Notas
    );
}

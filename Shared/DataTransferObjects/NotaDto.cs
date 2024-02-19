namespace Shared.DataTransferObjects;

public partial class NotaDto
{
    public int NotaId { get; set; }
    public string Titulo { get; set; }
    public int Valor { get; set; }
    public DateTime FechaCreacion { get; set; }
    public string Materia { get; set; }
    public string Periodo { get; set; }

    //Estudiante
    //Curso
    //Docente
}
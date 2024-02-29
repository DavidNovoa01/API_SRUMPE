namespace Shared.DataTransferObjects;

public class DocenteDto
{
    public Guid DocenteId { get; set; }
    public string Nombre { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Genero { get; set; }
    public string Direccion { get; set; }
    public string CorreoElectronico { get; set; }
    public string NumeroTelefono { get; set; }
    public DateTime FechaContratacion { get; set; }
    public string CursosAsignados { get; set; }
    public string HorarioClases { get; set; }
    public string EstadoLaboral { get; set; }
    public string NumeroIdentificacion { get; set; }
    public string ComentariosNotas { get; set; }
    public string NivelExperiencia { get; set; }

    public ICollection<CursoDto> Cursos { get; set; }
    public ICollection<MateriaDto> Materias { get; set; }
    public HorarioDto Horario { get; set; }
    public AulaDto Aula { get; set; }
}

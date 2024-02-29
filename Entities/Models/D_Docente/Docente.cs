using Entities.Models.D_DepartamentoAcademico;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models.D_Docente;

public partial class Docente
{
    public Docente()
    {
        Cursos = new HashSet<Cursos>();
        Materias = new HashSet<Materias>();
    }

    [Key]
    public Guid DocenteId { get; set; }
    public string Nombre { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Genero { get; set; }
    public string Direccion { get; set; }
    public string CorreoElectronico { get; set; }
    public string NumeroTelefono { get; set; }
    public DateTime FechaContratacion { get; set; }
    public string? CursosAsignados { get; set; }
    public string HorarioClases { get; set; }
    public string EstadoLaboral { get; set; }
    public string NumeroIdentificacion { get; set; }
    public string ComentariosNotas { get; set; }
    public string NivelExperiencia { get; set; }

    public ICollection<Cursos> Cursos { get; set; }
    public ICollection<Materias> Materias { get; set; }

    public Guid HorarioId { get; set; }
    public Horarios Horario { get; set; } // Referencia a la entidad Horarios
    public Guid AulaId { get; set; }
    public Aulas Aula { get; set; }
}


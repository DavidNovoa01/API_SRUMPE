using Entities.Models.D_Acudiente;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.D_Estudiante;

public partial class CandidatoEstudiante
{
    public Guid CandidatoEstudianteId { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime? FechaNacimiento { get; set; }
    public string TipoPersona { get; set; }
    public string TipoDocumento { get; set; }
    public long NumeroDocumento { get; set; }
    public long NumeroContacto { get; set; }
    public string Direccion { get; set; }
    public string Genero { get; set; }
    public string AdjuntarDocumentos { get; set; }

    public long NumeroIdentificacionAcudiente { get; set; } // Cambio de nombre
    public ICollection<Acudiente> Acudientes { get; set; }
}


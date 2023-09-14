using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entities.Models
{
    public partial class Acudiente
    {
        public Guid AcudienteId { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public int NumeroIdentificacion { get; set; }
        public string? Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string? CorreoElectronico { get; set; }
        public string? RelacionConEstudiante { get; set; }
        public string? EstadoCivil { get; set; }
        public string? Ocupacion { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }



        //public virtual ICollection<AcudienteEstudiante1> AcudienteEstudiante1s { get; set; } = new List<AcudienteEstudiante1>();

        //public virtual ICollection<DireccionAcudiente> DireccionAcudientes { get; set; } = new List<DireccionAcudiente>();

        //public virtual ICollection<TelefonoAcudiente1> TelefonoAcudiente1s { get; set; } = new List<TelefonoAcudiente1>();
    }

}

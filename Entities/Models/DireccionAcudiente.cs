using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public partial class DireccionAcudiente
    {
        [Key]
        public Guid DireccionAcudienteId { get; set; } // ID de Dirección

        [Required]
        public Guid AcudienteId { get; set; } // ID de Acudiente

        [Required]
        [StringLength(100)]
        public string Calle { get; set; } // Calle

        [StringLength(100)]
        public string ColoniaBarrio { get; set; } // Colonia o Barrio

        [StringLength(100)]
        public string CiudadLocalidad { get; set; } // Ciudad o Localidad

        [StringLength(20)]
        public string CodigoPostal { get; set; } // Código Postal

        [StringLength(100)]
        public string EstadoProvincia { get; set; } // Estado o Provincia

        [StringLength(100)]
        public string Pais { get; set; } // País
    }
}

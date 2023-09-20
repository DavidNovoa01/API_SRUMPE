using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.D_Acudiente;

public partial class DireccionAcudiente
{
    [Key]
    public Guid DireccionAcudienteId { get; set; } // ID de Dirección
    //public Guid AcudienteId { get; set; } // ID de Acudiente
    public string Calle { get; set; } // Calle
    public string ColoniaBarrio { get; set; } // Colonia o Barrio
    public string CiudadLocalidad { get; set; } // Ciudad o Localidad
    public string CodigoPostal { get; set; } // Código Postal
    public string EstadoProvincia { get; set; } // Estado o Provincia
    public string Pais { get; set; } // País
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public partial class TelefonoAcudiente
    {
        [Key]
        public Guid TelefonoAcudienteId { get; set; }

        [Required]
        [MaxLength(20)]
        public int Numero { get; set; }

        [Required]
        [MaxLength(20)]
        public string? Tipo { get; set; }

        public string Indicativo { get; set; } = null!;

        // Foreign Key
        public int? AcudienteId { get; set; }
    }
}

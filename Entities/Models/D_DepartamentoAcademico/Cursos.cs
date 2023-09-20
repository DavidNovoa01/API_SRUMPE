using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.D_DepartamentoAcademico
{
    public partial class Cursos
    {
        public Guid CursoId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string DepartamentoAcademico { get; set; }
        public string Nivel { get; set; }
        public string ProfesorAsignado { get; set; }

        //public string HorarioClases { get; set; }
        public string AulasAsignadas { get; set; }
        public DateTime FechaLimiteInscripcion { get; set; }
        public string MetodosEnsenanza { get; set; }

    }
}

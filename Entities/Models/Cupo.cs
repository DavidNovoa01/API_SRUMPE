﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public partial class Cupo
    {
        public Guid CupoId { get; set; }
        public int CantidadDisponible { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string? Descripcion { get; set; }
        public string? Ubicacion { get; set; }
        public bool Estado { get; set; }
        public TimeSpan Duracion { get; set; }
        public Guid CandidatoEstudianteId { get; set; }
        public string? Comentarios { get; set; }
    }
}

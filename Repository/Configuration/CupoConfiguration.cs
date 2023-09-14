﻿using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration;

public class CupoConfiguration : IEntityTypeConfiguration<Cupo>
{
    public void Configure(EntityTypeBuilder<Cupo> builder)
    {
        builder.HasData
            (
        
            new Cupo
       
                {
                CupoId = Guid.NewGuid(),
                CantidadDisponible = 10,
                FechaInicio = DateTime.Now,
                FechaFin = DateTime.Now.AddMonths(1),
                Descripcion = "Cupo para el evento principal",
                Ubicacion = "Salón principal",
                Estado = true,
                Duracion = TimeSpan.FromHours(2),
                CandidatoEstudianteId = Guid.NewGuid(),
                Comentarios = "Cupo para estudiantes universitarios"
            },
            new Cupo
            {
                CupoId = Guid.NewGuid(),
                CantidadDisponible = 5,
                FechaInicio = DateTime.Now,
                FechaFin = DateTime.Now.AddMonths(2),
                Descripcion = "Cupo para el taller de programación",
                Ubicacion = "Aula 101",
                Estado = true,
                Duracion = TimeSpan.FromHours(3),
                CandidatoEstudianteId = Guid.NewGuid(),
                Comentarios = "Cupo para desarrolladores junior"
            },
            new Cupo
            {
                CupoId = Guid.NewGuid(),
                CantidadDisponible = 20,
                FechaInicio = DateTime.Now,
                FechaFin = DateTime.Now.AddMonths(3),
                Descripcion = "Cupo para el seminario de marketing",
                Ubicacion = "Aula 102",
                Estado = true,
                Duracion = TimeSpan.FromHours(4),
                CandidatoEstudianteId = Guid.NewGuid(),
                Comentarios = "Cupo para profesionales de marketing"
            },
            new Cupo
            {
                CupoId = Guid.NewGuid(),
                CantidadDisponible = 15,
                FechaInicio = DateTime.Now,
                FechaFin = DateTime.Now.AddMonths(4),
                Descripcion = "Cupo para el curso de diseño gráfico",
                Ubicacion = "Aula 103",
                Estado = true,
                Duracion = TimeSpan.FromHours(2),
                CandidatoEstudianteId = Guid.NewGuid(),
                Comentarios = "Cupo para diseñadores creativos"
            },

            new Cupo
            {
                CupoId = Guid.NewGuid(),
                CantidadDisponible = 30,
                FechaInicio = DateTime.Now,
                FechaFin = DateTime.Now.AddMonths(5),
                Descripcion = "Cupo para el evento de networking",
                Ubicacion = "Aula 104",
                Estado = true,
                Duracion = TimeSpan.FromHours(1),
                CandidatoEstudianteId = Guid.NewGuid(),
                Comentarios = "Cupo para establecer contactos profesionales"
            }
        );
    }
}
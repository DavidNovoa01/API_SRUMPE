using Entities.Models.D_Notas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    internal class NotaConfiguration : IEntityTypeConfiguration<Notas>
    {
        public void Configure(EntityTypeBuilder<Notas> builder)

        {
            builder.HasData(
            new Notas
            {
                NotaId = 1,
                Titulo = "Examen de Matemáticas",
                Valor = 85,
                FechaCreacion = DateTime.Now,
                Materia = "Matemáticas",
                Periodo = "Primer Semestre"
            },

            new Notas
            {
                NotaId = 2,
                Titulo = "Proyecto de Ciencias",
                Valor = 92,
                FechaCreacion = DateTime.Now.AddDays(-5),
                Materia = "Ciencias",
                Periodo = "Segundo Semestre"
            },

            new Notas
            {
                NotaId = 3,
                Titulo = "Tarea de Historia",
                Valor = 75,
                FechaCreacion = DateTime.Now.AddDays(-10),
                Materia = "Historia",
                Periodo = "Primer Semestre"
            },

            new Notas
            {
                NotaId = 4,
                Titulo = "Presentación de Español",
                Valor = 88,
                FechaCreacion = DateTime.Now.AddDays(-2),
                Materia = "Español",
                Periodo = "Segundo Semestre"
            },

            new Notas
            {
                NotaId = 5,
                Titulo = "Prueba de Inglés",
                Valor = 95,
                FechaCreacion = DateTime.Now.AddDays(-7),
                Materia = "Inglés",
                Periodo = "Primer Semestre"
            }

        );
        }
    }
}

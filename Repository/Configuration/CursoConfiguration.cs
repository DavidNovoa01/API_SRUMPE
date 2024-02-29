using Entities.Models.D_DepartamentoAcademico;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Repository.Configuration;

public class CursoConfiguration : IEntityTypeConfiguration<Cursos>
{
    public void Configure(EntityTypeBuilder<Cursos> builder)
    {
        builder.HasData(
            new Cursos
            {
                CursoId = Guid.NewGuid(),
                Descripcion = "Introducción a la Programación",
                DepartamentoAcademico = "Ciencias de la Computación",
                Nivel = "Primer Semestre",
                FechaLimiteInscripcion = new DateTime(2023, 09, 30),
                MetodosEnsenanza = "Clases magistrales, laboratorios prácticos"
            },
            new Cursos
            {
                CursoId = Guid.NewGuid(),
                Descripcion = "Advanced English Composition",
                DepartamentoAcademico = "English Department",
                Nivel = "Second Semester",
                FechaLimiteInscripcion = new DateTime(2023, 10, 10),
                MetodosEnsenanza = "Lectures, writing assignments, group discussions"
            },
            new Cursos
            {
                CursoId = Guid.NewGuid(),
                Descripcion = "Advanced Calculus",
                DepartamentoAcademico = "Mathematics Department",
                Nivel = "Third Semester",
                FechaLimiteInscripcion = new DateTime(2023, 09, 25),
                MetodosEnsenanza = "Lectures, problem sets, exams"
            },
            new Cursos
            {
                CursoId = Guid.NewGuid(),
                Descripcion = "Organic Chemistry",
                DepartamentoAcademico = "Chemistry Department",
                Nivel = "Second Semester",
                FechaLimiteInscripcion = new DateTime(2023, 10, 5),
                MetodosEnsenanza = "Lectures, laboratory experiments"
            },
            new Cursos
            {
                CursoId = Guid.NewGuid(),
                Descripcion = "Introduction to History",
                DepartamentoAcademico = "History Department",
                Nivel = "First Semester",
                FechaLimiteInscripcion = new DateTime(2023, 09, 20),
                MetodosEnsenanza = "Lectures, discussions, research papers"
            }
        );
    }
}



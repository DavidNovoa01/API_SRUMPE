using Entities.Models.D_Estudiante;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class CandidatoEstudianteConfiguration : IEntityTypeConfiguration<CandidatoEstudiante>
{
    public void Configure(EntityTypeBuilder<CandidatoEstudiante> builder)
    {
        builder.HasData
        (
            new CandidatoEstudiante
            {
                CandidatoEstudianteId = Guid.NewGuid(),
                Nombre = "John",
                Apellido = "Doe",
                FechaNacimiento = null,
                TipoPersona = "Persona",
                TipoDocumento = "cedula",
                NumeroDocumento = 123456789,
                NumeroContacto = 987654321,
                Direccion = "123 Main Street",
                Genero = "Masculino",
                AdjuntarDocumentos = "Si"
            },
            new CandidatoEstudiante
            {
                CandidatoEstudianteId = Guid.NewGuid(),
                Nombre = "Jane",
                Apellido = "Smith",
                FechaNacimiento = new DateTime(1985, 8, 25),
                TipoPersona = "Persona",
                TipoDocumento = "Cedula",
                NumeroDocumento = 987654321,
                NumeroContacto = 123456789,
                Direccion = "456 Oak Avenue",
                Genero = "Femenino",
                AdjuntarDocumentos = "Si"
            },
            new CandidatoEstudiante
            {
                CandidatoEstudianteId = Guid.NewGuid(),
                Nombre = "Bob",
                Apellido = "Johnson",
                FechaNacimiento = new DateTime(1995, 3, 10),
                TipoPersona = "Persona",
                TipoDocumento = "Tarjeta de Identidad",
                NumeroDocumento = 456789012,
                NumeroContacto = 555555555,
                Direccion = "789 Pine Road",
                Genero = "No binario",
                AdjuntarDocumentos = "Si"
            },
            new CandidatoEstudiante
            {
                CandidatoEstudianteId = Guid.NewGuid(),
                Nombre = "Alice",
                Apellido = "Williams",
                FechaNacimiento = new DateTime(1980, 12, 5),
                TipoPersona = "Persona",
                TipoDocumento = "Tarjeta de Identidad",
                NumeroDocumento = 333222111,
                NumeroContacto = 444555666,
                Direccion = "101 Cedar Lane",
                Genero = "Otro",
                AdjuntarDocumentos = "No"
            },
            new CandidatoEstudiante
            {
                CandidatoEstudianteId = Guid.NewGuid(),
                Nombre = "Charlie",
                Apellido = "Brown",
                FechaNacimiento = new DateTime(1992, 7, 20),
                TipoPersona = "Persona",
                TipoDocumento = "Tarjeta de Identidad",
                NumeroDocumento = 999888777,
                NumeroContacto = 111222333,
                Direccion = "202 Elm Street",
                Genero = "Masculino",
                AdjuntarDocumentos = "Si"
            }
        );
    }
}
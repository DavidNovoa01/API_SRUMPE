using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Entities.Models.D_Acudiente;

namespace Repository.Configuration;

internal class DireccionAcudienteConfiguration : IEntityTypeConfiguration<DireccionAcudiente>
{
    public void Configure(EntityTypeBuilder<DireccionAcudiente> builder)
    {
        builder.HasData(
            new DireccionAcudiente
            {
                DireccionAcudienteId = Guid.NewGuid(),
                AcudienteId = Guid.Parse("49b5de78-1d3f-494e-a912-90f179c32853"), // Reemplazar con el ID real del Acudiente
                Calle = "Calle 100",
                ColoniaBarrio = "Norte",
                CiudadLocalidad = "Bogotá",
                CodigoPostal = "110111",
                EstadoProvincia = "Bogotá",
                Pais = "Colombia"
            },
            new DireccionAcudiente
            {
                DireccionAcudienteId = Guid.NewGuid(),
                AcudienteId = Guid.Parse("dac65adb-1b26-49a8-b61f-5bacbf6b2708"), // Reemplazar con el ID real del Acudiente
                Calle = "Carrera 50",
                ColoniaBarrio = "Sur",
                CiudadLocalidad = "Bogotá",
                CodigoPostal = "110221",
                EstadoProvincia = "Bogotá",
                Pais = "Colombia"
            }
        );
    }
}
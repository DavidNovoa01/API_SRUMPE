using Entities.Models;
using Entities.Models.D_Acudiente;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;
public class TelefonoAcudienteConfiguration : IEntityTypeConfiguration<TelefonoAcudiente>
{
    public void Configure(EntityTypeBuilder<TelefonoAcudiente> builder)
    {
        builder.HasData
        (
            new TelefonoAcudiente
            {
                TelefonoAcudienteId = Guid.NewGuid(),
                Numero = 555-123-4567,
                Tipo = "Móvil",
                Indicativo = "+1",
                AcudienteId = Guid.Parse("49b5de78-1d3f-494e-a912-90f179c32853"), // Reemplazar con el ID real del Acudiente
            },
            new TelefonoAcudiente
            {
                TelefonoAcudienteId = Guid.NewGuid(),
                Numero = 555-987-6543,
                Tipo = "Móvil",
                Indicativo = "+1",
                AcudienteId = Guid.Parse("dac65adb-1b26-49a8-b61f-5bacbf6b2708"), // Reemplazar con el ID real del Acudiente
            }
        );
    }
}
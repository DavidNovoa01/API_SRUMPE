using Entities.Models.D_Acudiente;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    internal class AcudienteConfiguration : IEntityTypeConfiguration<Acudiente>
    {
        public void Configure(EntityTypeBuilder<Acudiente> builder)
        
        {
            builder.HasData (
            new Acudiente
            {
                AcudienteId = Guid.NewGuid(),
                Nombres = "María",
                Apellidos = "Pérez",
                NumeroIdentificacion = 12345,
                CorreoElectronico = "maria.perez@email.com",
                RelacionConEstudiante = "Madre",
                EstadoCivil = "Casada",
                Ocupacion = "Ingeniera",
                Edad = 12,
                FechaRegistro = DateTime.Now
            },

          new Acudiente
          {
              AcudienteId = Guid.NewGuid(),
              Nombres = "Juan",
              Apellidos = "González",
              NumeroIdentificacion = 67890,
              Edad = 12,
              CorreoElectronico = "juan.gonzalez@email.com",
              RelacionConEstudiante = "Padre",
              EstadoCivil = "Soltero",
              Ocupacion = "Abogado",
              FechaRegistro = DateTime.Now
          },

          new Acudiente
            {
              AcudienteId = Guid.NewGuid(),
              Nombres = "Ana",
              Apellidos = "López",
              NumeroIdentificacion = 54321,
              CorreoElectronico = "ana.lopez@email.com",
              RelacionConEstudiante = "Tutor Legal",
              EstadoCivil = "Divorciada",
              Ocupacion = "Médica",
              Edad = 12,
              FechaRegistro = DateTime.Now
            },

           new Acudiente
            {
               AcudienteId = Guid.NewGuid(),
               Nombres = "Pedro",
               Apellidos = "Martínez",
               NumeroIdentificacion = 98765,
               CorreoElectronico = "pedro.martinez@email.com",
               RelacionConEstudiante = "Padre",
               EstadoCivil = "Casado",
               Ocupacion = "Profesor",
               Edad = 12,
               FechaRegistro = DateTime.Now
            },

            new Acudiente
            {
                AcudienteId = Guid.NewGuid(),
                Nombres = "Sofía",
                Apellidos = "Díaz",
                NumeroIdentificacion = 75319,
                CorreoElectronico = "sofia.diaz@email.com",
                RelacionConEstudiante = "Tía",
                EstadoCivil = "Soltera",
                Ocupacion = "Profesora",
                Edad = 12,
                FechaRegistro = DateTime.Now
            },

            new Acudiente
            {
                AcudienteId = Guid.NewGuid(),
                Nombres = "Roberto",
                Apellidos = "Luna",
                NumeroIdentificacion = 10293,
                CorreoElectronico = "roberto.luna@email.com",
                RelacionConEstudiante = "Abuelo",
                EstadoCivil = "Viudo",
                Ocupacion = "Jubilado",
                Edad = 12,
                FechaRegistro = DateTime.Now
            }

        );
    }
  }
}

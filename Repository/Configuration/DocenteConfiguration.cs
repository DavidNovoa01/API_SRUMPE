using Entities.Models.D_Acudiente;
using Entities.Models.D_Docente;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Repository.Configuration
{
    internal class DocenteConfiguration : IEntityTypeConfiguration<Docente>
    {
        public void Configure(EntityTypeBuilder<Docente> builder)

        {

            builder.HasData(

            new Docente
            {
                DocenteId = new Guid("a007fb2e-89c1-433a-609b-81a34b070e20"),
                Nombre = "John Smith",
                FechaNacimiento = new DateTime(1980, 5, 15),
                Genero = "Male",
                Direccion = "123 Main Street, Cityville",
                CorreoElectronico = "john.smith@example.com",
                NumeroTelefono = "+1 (555) 123-4567",
                FechaContratacion = new DateTime(2010, 8, 20),
                CursosAsignados = "Mathematics, Physics",
                HorarioClases = "Mon-Fri: 8 am - 4 pm",
                EstadoLaboral = "Active",
                NumeroIdentificacion = "D123456789",
                ComentariosNotas = "Excellent teacher with great communication skills.",
                NivelExperiencia = "Senior",
                AulaId = new Guid("bd249220-eec2-4bbd-c57e-8619cb666ece"), // Asignar un nuevo ID de Aula
                HorarioId = new Guid("17793c65-0075-4b33-f071-f84a0774be25") // Asignar un nuevo ID de Horario
            },

            new Docente
            {
                DocenteId = new Guid ("57aa9a84-70b2-4e68-235d-987650f3b246"),
                Nombre = "Alice Johnson",
                FechaNacimiento = new DateTime(1985, 10, 25),
                Genero = "Female",
                Direccion = "456 Oak Avenue, Townsville",
                CorreoElectronico = "alice.johnson@example.com",
                NumeroTelefono = "+1 (555) 987-6543",
                FechaContratacion = new DateTime(2015, 3, 10),
                CursosAsignados = "Literature, History",
                HorarioClases = "Tue-Thu: 10 am - 6 pm",
                EstadoLaboral = "Active",
                NumeroIdentificacion = "D987654321",
                ComentariosNotas = "Passionate about her subject and dedicated to student success.",
                NivelExperiencia = "Intermediate",
                AulaId = new Guid("53c29e9a-f7b8-433b-983f-a85b823c4733"), // Asignar un nuevo ID de Aula
                HorarioId = new Guid("75acf5e1-58d1-43e5-2385-76f0a8f0f464") // Asignar un nuevo ID de Horario
            }

        );
        }
    }
}

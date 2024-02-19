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
                DocenteId = Guid.NewGuid(),
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
                Fotografia = null // You can set the byte array for the photo if available
            },

            new Docente
            {
                DocenteId = Guid.NewGuid(),
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
                Fotografia = null
            },

            new Docente
            {
                DocenteId = Guid.NewGuid(),
                Nombre = "Carlos Rodriguez",
                FechaNacimiento = new DateTime(1992, 8, 8),
                Genero = "Male",
                Direccion = "789 Pine Lane, Villagetown",
                CorreoElectronico = "carlos.rodriguez@example.com",
                NumeroTelefono = "+1 (555) 876-5432",
                FechaContratacion = new DateTime(2020, 2, 5),
                CursosAsignados = "Computer Science, Programming",
                HorarioClases = "Mon-Wed-Fri: 9 am - 3 pm",
                EstadoLaboral = "Active",
                NumeroIdentificacion = "D555111222",
                ComentariosNotas = "Brings real-world experience to the classroom.",
                NivelExperiencia = "Junior",
                Fotografia = null
            },

            new Docente
            {
                DocenteId = Guid.NewGuid(),
                Nombre = "Emily White",
                FechaNacimiento = new DateTime(1988, 3, 12),
                Genero = "Female",
                Direccion = "234 Elm Street, Hamletville",
                CorreoElectronico = "emily.white@example.com",
                NumeroTelefono = "+1 (555) 234-5678",
                FechaContratacion = new DateTime(2018, 6, 15),
                CursosAsignados = "Chemistry, Biology",
                HorarioClases = "Thu-Fri: 11 am - 5 pm",
                EstadoLaboral = "Active",
                NumeroIdentificacion = "D333444555",
                ComentariosNotas = "Encourages critical thinking and curiosity in students.",
                NivelExperiencia = "Senior",
                Fotografia = null
            }

        );
        }
    }
}

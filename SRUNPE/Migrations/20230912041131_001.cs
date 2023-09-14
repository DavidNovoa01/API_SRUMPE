using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SRUNPE.Migrations
{
    /// <inheritdoc />
    public partial class _001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acudiente",
                columns: table => new
                {
                    AcudienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroIdentificacion = table.Column<int>(type: "int", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelacionConEstudiante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoCivil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ocupacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acudiente", x => x.AcudienteId);
                });

            migrationBuilder.CreateTable(
                name: "CandidatoEstudiantes",
                columns: table => new
                {
                    CandidatoEstudianteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TipoPersona = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidatoEstudiantes", x => x.CandidatoEstudianteId);
                });

            migrationBuilder.CreateTable(
                name: "DireccionAcudiente",
                columns: table => new
                {
                    DireccionAcudienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AcudienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Calle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ColoniaBarrio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CiudadLocalidad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CodigoPostal = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EstadoProvincia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DireccionAcudiente", x => x.DireccionAcudienteId);
                });

            migrationBuilder.CreateTable(
                name: "EstudianteDocumentos",
                columns: table => new
                {
                    EstudianteDocumentosId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroDocumento = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tamaño = table.Column<int>(type: "int", nullable: false),
                    CandidatoEstudianteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstudianteDocumentos", x => x.EstudianteDocumentosId);
                });

            migrationBuilder.CreateTable(
                name: "TelefonoAcudiente",
                columns: table => new
                {
                    TelefonoAcudienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Numero = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Indicativo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcudienteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelefonoAcudiente", x => x.TelefonoAcudienteId);
                });

            migrationBuilder.InsertData(
                table: "Acudiente",
                columns: new[] { "AcudienteId", "Apellidos", "CorreoElectronico", "Estado", "EstadoCivil", "FechaNacimiento", "FechaRegistro", "Genero", "Nombres", "NumeroIdentificacion", "Ocupacion", "RelacionConEstudiante" },
                values: new object[,]
                {
                    { new Guid("342b7f2f-dcdc-456e-a0f5-2e9a19a15945"), "Martínez", "pedro.martinez@email.com", true, "Casado", new DateTime(1988, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(538), "Masculino", "Pedro", 98765, "Profesor", "Padre" },
                    { new Guid("50b0b0e2-3bfc-4417-8349-e1ee43a9904b"), "Luna", "roberto.luna@email.com", true, "Viudo", new DateTime(1970, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(553), "Masculino", "Roberto", 10293, "Jubilado", "Abuelo" },
                    { new Guid("5b405adf-f5c0-4c7b-8432-f0ae6bd98e03"), "Sánchez", "luis.sanchez@email.com", true, "Casado", new DateTime(1972, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(541), "Masculino", "Luis", 13579, "Contador", "Padre" },
                    { new Guid("5d59c8c9-8b62-41e7-937e-0a1921d259c7"), "Gómez", "laura.gomez@email.com", true, "Divorciada", new DateTime(1992, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(547), "Femenino", "Laura", 86420, "Médica", "Madre" },
                    { new Guid("68edddb3-d75e-4c8e-a38f-5f32d8493372"), "Rodríguez", "carlos.rodriguez@email.com", true, "Soltero", new DateTime(1985, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(545), "Masculino", "Carlos", 24680, "Ingeniero Civil", "Tío" },
                    { new Guid("9c35e92e-f81f-4a1e-836c-41fb42a7e747"), "Pérez", "maria.perez@email.com", true, "Casada", new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(531), "Femenino", "María", 12345, "Ingeniera", "Madre" },
                    { new Guid("a3993809-24cf-487f-a2f5-b4b278172693"), "Hernández", "andres.hernandez@email.com", true, "Casado", new DateTime(1979, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(549), "Masculino", "Andrés", 97531, "Arquitecto", "Padrino" },
                    { new Guid("cd09b4cf-b30f-434e-9d7e-740755a8422b"), "González", "juan.gonzalez@email.com", true, "Soltero", new DateTime(1975, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(534), "Masculino", "Juan", 67890, "Abogado", "Padre" },
                    { new Guid("e73fa287-9f93-436d-a345-32063ed2fb59"), "Díaz", "sofia.diaz@email.com", true, "Soltera", new DateTime(1987, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(551), "Femenino", "Sofía", 75319, "Profesora", "Tía" },
                    { new Guid("f6d8842e-ceef-44fe-98eb-60b11cdb44d0"), "López", "ana.lopez@email.com", true, "Divorciada", new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(536), "Femenino", "Ana", 54321, "Médica", "Tutor Legal" }
                });

            migrationBuilder.InsertData(
                table: "CandidatoEstudiantes",
                columns: new[] { "CandidatoEstudianteId", "Apellido", "FechaNacimiento", "Nombre", "TipoPersona" },
                values: new object[,]
                {
                    { new Guid("05bd4290-441c-47c3-a4d4-b9e02e89099f"), "Martínez", new DateTime(1993, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana", "Estudiante" },
                    { new Guid("0fff11ac-ba5c-479a-9318-37f3105fd505"), "Fernández", new DateTime(1989, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roberto", "Estudiante" },
                    { new Guid("20e33cc5-82f9-45f1-9d40-5c92a5b6c5d3"), "Acuña", new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Axl", "Estudiante" },
                    { new Guid("257a9c55-8e1e-41ef-8d55-45bb568e5972"), "Sánchez", new DateTime(1987, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos", "Estudiante" },
                    { new Guid("26f1006d-bd44-4f4f-bf13-ae3d600a8304"), "Gómez", new DateTime(1996, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isabel", "Estudiante" },
                    { new Guid("5f42e233-0b6c-446d-93c8-9a2d506a4a51"), "Hernández", new DateTime(1994, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sofía", "Estudiante" },
                    { new Guid("983b7cb3-a514-4db3-bac8-a28386d33f5a"), "Castro", new DateTime(1990, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan", "Estudiante" },
                    { new Guid("a7acbe46-b834-408f-8e53-f3a43de930fe"), "Ramírez", new DateTime(1998, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pedro", "Estudiante" },
                    { new Guid("c0a0888f-59fd-4578-8dd5-903505548e6c"), "López", new DateTime(2000, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura", "Estudiante" },
                    { new Guid("fccf74e2-8329-4e38-89f1-4a4e46731ca1"), "Díaz", new DateTime(1991, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Francisco", "Estudiante" }
                });

            migrationBuilder.InsertData(
                table: "DireccionAcudiente",
                columns: new[] { "DireccionAcudienteId", "AcudienteId", "Calle", "CiudadLocalidad", "CodigoPostal", "ColoniaBarrio", "EstadoProvincia", "Pais" },
                values: new object[,]
                {
                    { new Guid("27cd64fb-fecb-43d1-a47c-a2d9c20846cc"), new Guid("00000000-0000-0000-0000-000000000000"), "Calle 72", "Bogotá", "110231", "Chapinero", "Bogotá D.C.", "Colombia" },
                    { new Guid("2df493e2-a7fb-4bf8-a80b-81f33e79711a"), new Guid("00000000-0000-0000-0000-000000000000"), "Calle 80", "Bogotá", "110841", "Engativá", "Bogotá D.C.", "Colombia" },
                    { new Guid("7188955c-9894-41f2-a952-d68c195e03b6"), new Guid("00000000-0000-0000-0000-000000000000"), "Carrera 10", "Bogotá", "110321", "La Candelaria", "Bogotá D.C.", "Colombia" },
                    { new Guid("8569a8d7-0ada-480b-bcac-5e50c8958f90"), new Guid("00000000-0000-0000-0000-000000000000"), "Avenida Boyacá", "Bogotá", "110511", "Fontibón", "Bogotá D.C.", "Colombia" },
                    { new Guid("9bb56f72-213d-4af1-bcae-8f0050c3e04e"), new Guid("00000000-0000-0000-0000-000000000000"), "Avenida 68", "Bogotá", "110841", "Kennedy", "Bogotá D.C.", "Colombia" },
                    { new Guid("be660767-5179-475e-9794-32ced91e80e1"), new Guid("00000000-0000-0000-0000-000000000000"), "Carrera 7", "Bogotá", "110171", "Usaquén", "Bogotá D.C.", "Colombia" },
                    { new Guid("fae3ad1c-7ec1-48db-874b-81a404003404"), new Guid("00000000-0000-0000-0000-000000000000"), "Calle 72", "Bogotá", "110231", "Chapinero", "Bogotá D.C.", "Colombia" }
                });

            migrationBuilder.InsertData(
                table: "EstudianteDocumentos",
                columns: new[] { "EstudianteDocumentosId", "CandidatoEstudianteId", "Estado", "FechaActualizacion", "NombreDocumento", "NumeroDocumento", "Observaciones", "Tamaño", "TipoDocumento", "Ubicacion" },
                values: new object[,]
                {
                    { new Guid("10a5e754-1570-4be0-8650-2c53d7cfb4d3"), new Guid("b3b5a5a7-5b82-4f76-98c1-654589db8f61"), true, new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(326), "Fotografía del Estudiante", 1111111, "Foto de perfil", 1024, "Identificación", "ruta/al/documento10" },
                    { new Guid("2d54a999-187f-4a8c-99db-d17841e7938c"), new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), true, new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(292), "Diploma", 987654, "Logros académicos", 2048, "Educativo", "ruta/al/documento2" },
                    { new Guid("3e68515e-3a47-4a62-a8c7-9f12242d020e"), new Guid("4f3657e5-5824-47b8-b4cd-6f49a3f4dbf1"), false, new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(307), "Certificado de Graduación", 123456, "Graduación universitaria", 1536, "Educativo", "ruta/al/documento3" },
                    { new Guid("4a303cce-8c0e-4ae7-89c1-067d0b7741b6"), new Guid("3e68515e-3a47-4a62-a8c7-9f12242d020e"), true, new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(310), "Certificado de Matrícula", 789012, "Matrícula escolar", 8192, "Educativo", "ruta/al/documento4" },
                    { new Guid("5f78d0e1-579e-4dfc-82a1-92010b4191d3"), new Guid("31eb541a-9419-4eac-bf1b-0289a6c6f6f0"), true, new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(312), "Cédula de Identidad", 555555, "Documento oficial", 4096, "Identificación", "ruta/al/documento5" },
                    { new Guid("6a30c846-4b9d-4cf5-bb17-051a3e9d1b72"), new Guid("c9d4c053-49b6-410c-bc78-2d54a999187f"), true, null, "Certificado de Nacimiento", 61464465, "Ninguna", 1024, "Identificación", "ruta/al/documento1" },
                    { new Guid("7e15d9a4-98cb-4d14-9a35-862f8c202725"), new Guid("bb9b0679-4f04-4ac4-9ddc-5c3e50e81298"), true, new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(319), "Boleta de Calificaciones", 9876543, "Registro académico", 5120, "Educativo", "ruta/al/documento7" },
                    { new Guid("8f4a67c2-fd5e-4316-8c50-7249f159d0f1"), new Guid("a6509bea-688e-43b5-a870-6ee461ccf601"), true, new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(321), "Pasaporte", 1234567, "Documento de viaje", 4096, "Identificación", "ruta/al/documento8" },
                    { new Guid("9b9d6d8f-72f0-4f0a-8e18-1e75b0182e3f"), new Guid("db9fcac5-8654-45c3-87c7-8b5e13e9e6c2"), true, new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(324), "Certificado Médico", 543210, "Informe médico", 2048, "Salud", "ruta/al/documento9" },
                    { new Guid("f38f6b1a-86e9-4d9d-8a7a-62f17e6f1ba2"), new Guid("7f255218-f8e0-45a9-9807-12e1bcfd438c"), true, new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(315), "Carné de Estudiante", 7890123, "Carné escolar", 3072, "Identificación", "ruta/al/documento6" }
                });

            migrationBuilder.InsertData(
                table: "TelefonoAcudiente",
                columns: new[] { "TelefonoAcudienteId", "AcudienteId", "Indicativo", "Numero", "Tipo" },
                values: new object[,]
                {
                    { new Guid("0dbf82f2-169e-48ba-88c1-5a4d107cb43a"), 5, "+1", -5555, "Emergencia" },
                    { new Guid("155f850c-8cba-4810-8718-eabb4254df85"), 4, "+1", -5753, "Móvil" },
                    { new Guid("37c25930-9abf-4a35-a690-035c82f7a3e5"), 5, "+1", 911, "Emergencia" },
                    { new Guid("7f65b603-3b9f-4d4f-a730-092917444e8e"), 2, "+1", -1889, "Móvil" },
                    { new Guid("80d8b3cd-494d-4485-8a01-ec7c70adff20"), 1, "+1", -667, "Móvil" },
                    { new Guid("8da69459-418f-4546-ab99-70d48018b711"), 4, "+1", -4333, "Móvil" },
                    { new Guid("af4c6a95-2e4d-459c-a894-7429479ea871"), 3, "+1", -5357, "Fijo" },
                    { new Guid("bb67f88d-4398-4683-a9f8-1f2a31491d58"), 1, "+1", -4135, "Móvil" },
                    { new Guid("c47a9f4f-11a6-4eb4-aecd-6e61d62f4b83"), 3, "+1", -3111, "Fijo" },
                    { new Guid("f5fa2927-2833-4948-b0ae-f2c937e7f62c"), 2, "+1", -6975, "Móvil" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acudiente");

            migrationBuilder.DropTable(
                name: "CandidatoEstudiantes");

            migrationBuilder.DropTable(
                name: "DireccionAcudiente");

            migrationBuilder.DropTable(
                name: "EstudianteDocumentos");

            migrationBuilder.DropTable(
                name: "TelefonoAcudiente");
        }
    }
}

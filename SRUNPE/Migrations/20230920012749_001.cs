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
                name: "Cupo",
                columns: table => new
                {
                    CupoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CantidadDisponible = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Duracion = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cupo", x => x.CupoId);
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
                    NombreDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroDocumento = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tamaño = table.Column<int>(type: "int", nullable: false),
                    CandidatoEstudianteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstudianteDocumentos", x => x.EstudianteDocumentosId);
                });

            migrationBuilder.CreateTable(
                name: "Matricula",
                columns: table => new
                {
                    MatriculaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaMatricula = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoMatricula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoMatricula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PeriodoAcademico = table.Column<int>(type: "int", nullable: false),
                    Comentarios = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriaMatricula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformacionPlanEstudios = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroCambios = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matricula", x => x.MatriculaId);
                });

            migrationBuilder.CreateTable(
                name: "PreMatricula",
                columns: table => new
                {
                    PreMatriculaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GradoONivel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Turno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoPreMatricula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequisitosDocumentacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreMatricula", x => x.PreMatriculaId);
                });

            migrationBuilder.CreateTable(
                name: "RespuestaCupo",
                columns: table => new
                {
                    RespuestaCupoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaRespuesta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoRespuesta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MensajeRespuesta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioRespuesta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoRespuesta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DuracionRespuesta = table.Column<TimeSpan>(type: "time", nullable: false),
                    Prioridad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespuestaCupo", x => x.RespuestaCupoId);
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
                    { new Guid("1920292c-81e7-4ee5-805a-69b825d9334b"), "Martínez", "pedro.martinez@email.com", true, "Casado", new DateTime(1988, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(6137), "Masculino", "Pedro", 98765, "Profesor", "Padre" },
                    { new Guid("1f2cda1f-ba19-43d4-b541-4c0736d29b1f"), "Rodríguez", "carlos.rodriguez@email.com", true, "Soltero", new DateTime(1985, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(6144), "Masculino", "Carlos", 24680, "Ingeniero Civil", "Tío" },
                    { new Guid("3733d293-982c-4d4f-b9fd-888f9814519b"), "Pérez", "maria.perez@email.com", true, "Casada", new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(6130), "Femenino", "María", 12345, "Ingeniera", "Madre" },
                    { new Guid("454d7f5a-d08b-4fc8-b6e5-74987e34cc21"), "Gómez", "laura.gomez@email.com", true, "Divorciada", new DateTime(1992, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(6146), "Femenino", "Laura", 86420, "Médica", "Madre" },
                    { new Guid("7321966a-d8b2-4fdf-968f-76b7c03fd889"), "Sánchez", "luis.sanchez@email.com", true, "Casado", new DateTime(1972, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(6139), "Masculino", "Luis", 13579, "Contador", "Padre" },
                    { new Guid("934f5cc7-b6d3-4eab-ac31-bfe5dc6d7de8"), "López", "ana.lopez@email.com", true, "Divorciada", new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(6135), "Femenino", "Ana", 54321, "Médica", "Tutor Legal" },
                    { new Guid("a94c409c-0b06-49a0-a418-140b34431819"), "Díaz", "sofia.diaz@email.com", true, "Soltera", new DateTime(1987, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(6150), "Femenino", "Sofía", 75319, "Profesora", "Tía" },
                    { new Guid("cd4cc3de-a4b3-47cc-a791-753e49950d94"), "Hernández", "andres.hernandez@email.com", true, "Casado", new DateTime(1979, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(6148), "Masculino", "Andrés", 97531, "Arquitecto", "Padrino" },
                    { new Guid("d4d69f50-f672-4b72-91eb-4587f734998a"), "Luna", "roberto.luna@email.com", true, "Viudo", new DateTime(1970, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(6152), "Masculino", "Roberto", 10293, "Jubilado", "Abuelo" },
                    { new Guid("dd371b4b-76f7-4ed2-801a-918b823b0987"), "González", "juan.gonzalez@email.com", true, "Soltero", new DateTime(1975, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(6133), "Masculino", "Juan", 67890, "Abogado", "Padre" }
                });

            migrationBuilder.InsertData(
                table: "CandidatoEstudiantes",
                columns: new[] { "CandidatoEstudianteId", "Apellido", "FechaNacimiento", "Nombre", "TipoPersona" },
                values: new object[,]
                {
                    { new Guid("0ef9b539-60b2-400a-87d7-90f233cbea70"), "Acuña", new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Axl", "Estudiante" },
                    { new Guid("45e13100-09a9-4125-add0-0d9d0dd7dc4e"), "Ramírez", new DateTime(1998, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pedro", "Estudiante" },
                    { new Guid("49ae4fea-7945-423c-9930-b337ecab829e"), "Hernández", new DateTime(1994, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sofía", "Estudiante" },
                    { new Guid("56ee2b03-3572-4502-bb2f-abe9a1f9181e"), "Martínez", new DateTime(1993, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana", "Estudiante" },
                    { new Guid("90ffe0ae-f0b5-4184-8e3d-9f6251397716"), "Fernández", new DateTime(1989, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roberto", "Estudiante" },
                    { new Guid("c488ba4f-e500-4c6b-8b20-b0a056dcd40c"), "Sánchez", new DateTime(1987, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos", "Estudiante" },
                    { new Guid("c7f80181-5eb4-47f5-8fdd-148680271604"), "Gómez", new DateTime(1996, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isabel", "Estudiante" },
                    { new Guid("c84bb6a7-baf3-4320-a746-e7f6b429192a"), "López", new DateTime(2000, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura", "Estudiante" },
                    { new Guid("d42b5142-0c96-4859-a7fb-b2a09f9438bf"), "Díaz", new DateTime(1991, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Francisco", "Estudiante" },
                    { new Guid("f05f37f8-baba-4fe6-bd92-358e82980b90"), "Castro", new DateTime(1990, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan", "Estudiante" }
                });

            migrationBuilder.InsertData(
                table: "Cupo",
                columns: new[] { "CupoId", "CantidadDisponible", "Descripcion", "Duracion", "Estado", "FechaFin", "FechaInicio", "Ubicacion" },
                values: new object[,]
                {
                    { new Guid("2e9435a8-0602-47c1-9b3e-b25498ee5862"), 30, "Cupo para el evento de networking", new TimeSpan(0, 1, 0, 0, 0), true, new DateTime(2024, 2, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7102), new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7101), "Aula 104" },
                    { new Guid("8018b5f1-fef1-4d65-851a-a1886bb647e5"), 20, "Cupo para el seminario de marketing", new TimeSpan(0, 4, 0, 0, 0), true, new DateTime(2023, 12, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7095), new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7095), "Aula 102" },
                    { new Guid("b79c782e-822a-4928-96d1-d3d0e3c7b10e"), 5, "Cupo para el taller de programación", new TimeSpan(0, 3, 0, 0, 0), true, new DateTime(2023, 11, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7092), new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7091), "Aula 101" },
                    { new Guid("bf53e310-25df-4b31-b24c-a3cf308a98e6"), 15, "Cupo para el curso de diseño gráfico", new TimeSpan(0, 2, 0, 0, 0), true, new DateTime(2024, 1, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7099), new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7098), "Aula 103" },
                    { new Guid("e6bf7a9c-4959-400f-a114-ea39363be241"), 10, "Cupo para el evento principal", new TimeSpan(0, 2, 0, 0, 0), true, new DateTime(2023, 10, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7078), new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7073), "Salón principal" }
                });

            migrationBuilder.InsertData(
                table: "DireccionAcudiente",
                columns: new[] { "DireccionAcudienteId", "AcudienteId", "Calle", "CiudadLocalidad", "CodigoPostal", "ColoniaBarrio", "EstadoProvincia", "Pais" },
                values: new object[,]
                {
                    { new Guid("534bf14d-5ee1-4177-ba08-8937512b713a"), new Guid("00000000-0000-0000-0000-000000000000"), "Calle 72", "Bogotá", "110231", "Chapinero", "Bogotá D.C.", "Colombia" },
                    { new Guid("679cdcf1-e269-493f-8f18-aaec9922a710"), new Guid("00000000-0000-0000-0000-000000000000"), "Avenida 68", "Bogotá", "110841", "Kennedy", "Bogotá D.C.", "Colombia" },
                    { new Guid("78b8dfed-b192-460e-8edd-628892bdf30e"), new Guid("00000000-0000-0000-0000-000000000000"), "Carrera 10", "Bogotá", "110321", "La Candelaria", "Bogotá D.C.", "Colombia" },
                    { new Guid("90afda90-aa9c-432d-aef5-18bdc9f4915e"), new Guid("00000000-0000-0000-0000-000000000000"), "Calle 80", "Bogotá", "110841", "Engativá", "Bogotá D.C.", "Colombia" },
                    { new Guid("ca500405-ed43-441f-8b6b-d15ae730c00b"), new Guid("00000000-0000-0000-0000-000000000000"), "Calle 72", "Bogotá", "110231", "Chapinero", "Bogotá D.C.", "Colombia" },
                    { new Guid("cc2595e3-cf74-4fa8-9c42-ab16ad9af8d2"), new Guid("00000000-0000-0000-0000-000000000000"), "Avenida Boyacá", "Bogotá", "110511", "Fontibón", "Bogotá D.C.", "Colombia" },
                    { new Guid("ef1ff1f6-f33e-4895-9264-6e209f0352a1"), new Guid("00000000-0000-0000-0000-000000000000"), "Carrera 7", "Bogotá", "110171", "Usaquén", "Bogotá D.C.", "Colombia" }
                });

            migrationBuilder.InsertData(
                table: "EstudianteDocumentos",
                columns: new[] { "EstudianteDocumentosId", "CandidatoEstudianteId", "Estado", "FechaActualizacion", "NombreDocumento", "NumeroDocumento", "Observaciones", "Tamaño", "TipoDocumento", "Ubicacion" },
                values: new object[,]
                {
                    { new Guid("10a5e754-1570-4be0-8650-2c53d7cfb4d3"), new Guid("b3b5a5a7-5b82-4f76-98c1-654589db8f61"), true, new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(5924), "Fotografía del Estudiante", 1111111, "Foto de perfil", 1024, "Identificación", "ruta/al/documento10" },
                    { new Guid("2d54a999-187f-4a8c-99db-d17841e7938c"), new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), true, new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(5892), "Diploma", 987654, "Logros académicos", 2048, "Educativo", "ruta/al/documento2" },
                    { new Guid("3e68515e-3a47-4a62-a8c7-9f12242d020e"), new Guid("4f3657e5-5824-47b8-b4cd-6f49a3f4dbf1"), false, new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(5905), "Certificado de Graduación", 123456, "Graduación universitaria", 1536, "Educativo", "ruta/al/documento3" },
                    { new Guid("4a303cce-8c0e-4ae7-89c1-067d0b7741b6"), new Guid("3e68515e-3a47-4a62-a8c7-9f12242d020e"), true, new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(5909), "Certificado de Matrícula", 789012, "Matrícula escolar", 8192, "Educativo", "ruta/al/documento4" },
                    { new Guid("5f78d0e1-579e-4dfc-82a1-92010b4191d3"), new Guid("31eb541a-9419-4eac-bf1b-0289a6c6f6f0"), true, new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(5913), "Cédula de Identidad", 555555, "Documento oficial", 4096, "Identificación", "ruta/al/documento5" },
                    { new Guid("6a30c846-4b9d-4cf5-bb17-051a3e9d1b72"), new Guid("c9d4c053-49b6-410c-bc78-2d54a999187f"), true, null, "Certificado de Nacimiento", 61464465, "Ninguna", 1024, "Identificación", "ruta/al/documento1" },
                    { new Guid("7e15d9a4-98cb-4d14-9a35-862f8c202725"), new Guid("bb9b0679-4f04-4ac4-9ddc-5c3e50e81298"), true, new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(5918), "Boleta de Calificaciones", 9876543, "Registro académico", 5120, "Educativo", "ruta/al/documento7" },
                    { new Guid("8f4a67c2-fd5e-4316-8c50-7249f159d0f1"), new Guid("a6509bea-688e-43b5-a870-6ee461ccf601"), true, new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(5920), "Pasaporte", 1234567, "Documento de viaje", 4096, "Identificación", "ruta/al/documento8" },
                    { new Guid("9b9d6d8f-72f0-4f0a-8e18-1e75b0182e3f"), new Guid("db9fcac5-8654-45c3-87c7-8b5e13e9e6c2"), true, new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(5922), "Certificado Médico", 543210, "Informe médico", 2048, "Salud", "ruta/al/documento9" },
                    { new Guid("f38f6b1a-86e9-4d9d-8a7a-62f17e6f1ba2"), new Guid("7f255218-f8e0-45a9-9807-12e1bcfd438c"), true, new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(5915), "Carné de Estudiante", 7890123, "Carné escolar", 3072, "Identificación", "ruta/al/documento6" }
                });

            migrationBuilder.InsertData(
                table: "Matricula",
                columns: new[] { "MatriculaId", "CategoriaMatricula", "Comentarios", "EstadoMatricula", "FechaMatricula", "InformacionPlanEstudios", "PeriodoAcademico", "RegistroCambios", "TipoMatricula" },
                values: new object[,]
                {
                    { new Guid("2a35d86f-6091-44f9-85a2-ef1bac9ba761"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 4", "Activa", new DateTime(2023, 12, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(8038), "Plan de estudios 2023", 2023, "Registro de cambios 4", "Matrícula Regular" },
                    { new Guid("41ea5832-9d0d-406b-813b-d956ee524dc0"), "Estudiante de Tiempo Parcial", "Comentario sobre la matrícula 2", "Pendiente", new DateTime(2023, 10, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(8031), "Plan de estudios 2023", 2023, "Registro de cambios 2", "Matrícula Parcial" },
                    { new Guid("5b8b4815-97a6-4395-936e-e60668e35e6b"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 5", "Activa", new DateTime(2024, 1, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(8041), "Plan de estudios 2023", 2023, "Registro de cambios 5", "Matrícula Regular" },
                    { new Guid("82697d43-ff9b-4c85-929a-f13cd24cd524"), "Estudiante Internacional", "Comentario sobre la matrícula 3", "Cancelada", new DateTime(2023, 11, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(8035), "Plan de estudios 2023", 2023, "Registro de cambios 3", "Matrícula Regular" },
                    { new Guid("997418c7-a4d5-4f28-b9ff-2bd2ca90804c"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 1", "Activa", new DateTime(2023, 9, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(8023), "Plan de estudios 2023", 2023, "Registro de cambios 1", "Matrícula Regular" }
                });

            migrationBuilder.InsertData(
                table: "PreMatricula",
                columns: new[] { "PreMatriculaId", "EstadoPreMatricula", "GradoONivel", "Observaciones", "RequisitosDocumentacion", "Turno" },
                values: new object[,]
                {
                    { new Guid("010b49b7-50bc-41b2-b582-f955d9561f6e"), "Activa", "Segundo de Primaria", "Estudiante con discapacidad visual.", "SiCumplio", "Mañana" },
                    { new Guid("0f479811-49f2-4099-911d-69221ec1f50b"), "Activa", "Séptimo de Secundaria", "Estudiante de transferencia.", "SiCumplio", "Tarde" },
                    { new Guid("5198675a-ed9a-4243-a663-85a1599c309b"), "Pendiente", "Tercero de Primaria", "Estudiante extranjero.", "SiCumplio", "Mañana" },
                    { new Guid("5bebdab6-aa21-4951-8319-3489e87e03d3"), "Pendiente", "Octavo de Secundaria", "Estudiante sin observaciones adicionales.", "Si cumplio", "Tarde" },
                    { new Guid("83099039-4497-4013-9e89-3c949a6ba14c"), "Activa", "Cuarto de Secundaria", "Estudiante con beca deportiva.", "SiCumplio", "Tarde" },
                    { new Guid("8bd98a21-f011-4866-9765-63e0d1eabbbc"), "Pendiente", "Quinto de Primaria", "Estudiante con requerimientos especiales.", "NoCumplio", "Mañana" }
                });

            migrationBuilder.InsertData(
                table: "RespuestaCupo",
                columns: new[] { "RespuestaCupoId", "DuracionRespuesta", "EstadoRespuesta", "FechaRespuesta", "FechaVencimiento", "MensajeRespuesta", "Prioridad", "TipoRespuesta", "UsuarioRespuesta" },
                values: new object[,]
                {
                    { new Guid("04506ed8-3111-4857-a675-6bafc80a0274"), new TimeSpan(60, 0, 0, 0, 0), "Pendiente", new DateTime(2023, 9, 22, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7498), new DateTime(2023, 12, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7499), "Respuesta 3", "Baja", "Pendiente", "Usuario3" },
                    { new Guid("3b571d2f-d3e1-4170-8e55-d2c89b687f10"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2023, 9, 21, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7494), new DateTime(2023, 11, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7495), "Respuesta 2", "Media", "Rechazo", "Usuario2" },
                    { new Guid("4ddb3ce6-a186-4fef-9764-a5dc0bf047b8"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2023, 9, 20, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7483), new DateTime(2023, 10, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7489), "Respuesta 1", "Alta", "Aceptación", "Usuario1" },
                    { new Guid("7954f9cd-b283-4e89-954d-09e33bf593ec"), new TimeSpan(60, 0, 0, 0, 0), "Pendiente", new DateTime(2023, 9, 27, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7513), new DateTime(2024, 5, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7514), "Respuesta 8", "Baja", "Pendiente", "Usuario8" },
                    { new Guid("ab8f6391-a700-45ca-adc2-27d2f20caa1f"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2023, 9, 28, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7519), new DateTime(2024, 6, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7520), "Respuesta 9", "Alta", "Aceptación", "Usuario9" },
                    { new Guid("c60942b0-ca0c-444e-8b8a-b2c028b41b49"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2023, 9, 24, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7504), new DateTime(2024, 2, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7505), "Respuesta 5", "Media", "Rechazo", "Usuario5" },
                    { new Guid("c98c87a1-3e7d-4466-bb8e-464d761e843f"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2023, 9, 26, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7510), new DateTime(2024, 4, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7511), "Respuesta 7", "Media", "Rechazo", "Usuario7" },
                    { new Guid("dc2939f3-f303-4973-94cb-53c5ce5c7992"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2023, 9, 23, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7501), new DateTime(2024, 1, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7502), "Respuesta 4", "Alta", "Aceptación", "Usuario4" },
                    { new Guid("dfc75504-50aa-42e1-8fdb-93ae2f1ac546"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2023, 9, 25, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7507), new DateTime(2024, 3, 19, 20, 27, 49, 759, DateTimeKind.Local).AddTicks(7508), "Respuesta 6", "Alta", "Aceptación", "Usuario6" }
                });

            migrationBuilder.InsertData(
                table: "TelefonoAcudiente",
                columns: new[] { "TelefonoAcudienteId", "AcudienteId", "Indicativo", "Numero", "Tipo" },
                values: new object[,]
                {
                    { new Guid("0498bdd2-b923-420c-bc5f-2c66b7ab8aed"), 4, "+1", -4333, "Móvil" },
                    { new Guid("08777714-3c20-4f8a-a3bb-3159f67a3426"), 3, "+1", -5357, "Fijo" },
                    { new Guid("0d2f6b38-5fd3-4ecb-8715-a4a00d9f3618"), 3, "+1", -3111, "Fijo" },
                    { new Guid("0e936899-1439-4b3b-8376-8834e791bd53"), 4, "+1", -5753, "Móvil" },
                    { new Guid("3095503b-67a4-44c7-aad1-830eb9093ee8"), 2, "+1", -6975, "Móvil" },
                    { new Guid("36e776dd-13d8-4120-a755-fe9d384f43ab"), 5, "+1", 911, "Emergencia" },
                    { new Guid("77569026-0204-4a77-9fa5-3e3e62039902"), 1, "+1", -4135, "Móvil" },
                    { new Guid("77d85f4e-1ae1-4e05-857f-8c20f4ed5351"), 2, "+1", -1889, "Móvil" },
                    { new Guid("7ca9c81e-7e72-449f-af08-ae69a5aee367"), 1, "+1", -667, "Móvil" },
                    { new Guid("ff9e7f49-6edf-4b82-9e63-c14904a2ac84"), 5, "+1", -5555, "Emergencia" }
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
                name: "Cupo");

            migrationBuilder.DropTable(
                name: "DireccionAcudiente");

            migrationBuilder.DropTable(
                name: "EstudianteDocumentos");

            migrationBuilder.DropTable(
                name: "Matricula");

            migrationBuilder.DropTable(
                name: "PreMatricula");

            migrationBuilder.DropTable(
                name: "RespuestaCupo");

            migrationBuilder.DropTable(
                name: "TelefonoAcudiente");
        }
    }
}

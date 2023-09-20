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
                    Duracion = table.Column<TimeSpan>(type: "time", nullable: false),
                    CandidatoEstudianteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comentarios = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    { new Guid("14916451-864e-4082-99da-59be86714103"), "Martínez", "pedro.martinez@email.com", true, "Casado", new DateTime(1988, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(2164), "Masculino", "Pedro", 98765, "Profesor", "Padre" },
                    { new Guid("4f5c20ae-75e7-4b08-bd95-741a78985ece"), "Hernández", "andres.hernandez@email.com", true, "Casado", new DateTime(1979, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(2172), "Masculino", "Andrés", 97531, "Arquitecto", "Padrino" },
                    { new Guid("4fe4e135-70ae-4e05-960f-89fd3e643202"), "Rodríguez", "carlos.rodriguez@email.com", true, "Soltero", new DateTime(1985, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(2168), "Masculino", "Carlos", 24680, "Ingeniero Civil", "Tío" },
                    { new Guid("6dbd98a4-5f1f-40d3-85ad-2c5c05e7f4f3"), "Sánchez", "luis.sanchez@email.com", true, "Casado", new DateTime(1972, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(2166), "Masculino", "Luis", 13579, "Contador", "Padre" },
                    { new Guid("84521c97-adfc-45ac-b37e-588105fc0253"), "Luna", "roberto.luna@email.com", true, "Viudo", new DateTime(1970, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(2178), "Masculino", "Roberto", 10293, "Jubilado", "Abuelo" },
                    { new Guid("b0b5678d-0205-401c-a7a1-f1b5ac70f19c"), "Pérez", "maria.perez@email.com", true, "Casada", new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(2151), "Femenino", "María", 12345, "Ingeniera", "Madre" },
                    { new Guid("b378a83e-5620-46a3-80fe-32c8861faf0a"), "Díaz", "sofia.diaz@email.com", true, "Soltera", new DateTime(1987, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(2174), "Femenino", "Sofía", 75319, "Profesora", "Tía" },
                    { new Guid("c89b82db-fab8-4981-810a-f2ee059c9edb"), "López", "ana.lopez@email.com", true, "Divorciada", new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(2161), "Femenino", "Ana", 54321, "Médica", "Tutor Legal" },
                    { new Guid("f4f4a2a6-d65d-45c5-9a42-8fc1d84f8b10"), "González", "juan.gonzalez@email.com", true, "Soltero", new DateTime(1975, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(2158), "Masculino", "Juan", 67890, "Abogado", "Padre" },
                    { new Guid("f8c81da2-1f61-4ab3-85ed-53d0156294ee"), "Gómez", "laura.gomez@email.com", true, "Divorciada", new DateTime(1992, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(2170), "Femenino", "Laura", 86420, "Médica", "Madre" }
                });

            migrationBuilder.InsertData(
                table: "CandidatoEstudiantes",
                columns: new[] { "CandidatoEstudianteId", "Apellido", "FechaNacimiento", "Nombre", "TipoPersona" },
                values: new object[,]
                {
                    { new Guid("088ac4bf-e1ac-45c9-b587-3e76c18ff184"), "Acuña", new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Axl", "Estudiante" },
                    { new Guid("1103d5a3-567c-42e0-9ba1-90b2dbecfc78"), "Sánchez", new DateTime(1987, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos", "Estudiante" },
                    { new Guid("395822b7-a456-45a0-bea8-af50ce2aa67d"), "Ramírez", new DateTime(1998, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pedro", "Estudiante" },
                    { new Guid("6139564b-37eb-430d-8ad3-cfd365e68d17"), "Castro", new DateTime(1990, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan", "Estudiante" },
                    { new Guid("638e6e3d-06fb-4cf1-9098-5db1820078f4"), "López", new DateTime(2000, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura", "Estudiante" },
                    { new Guid("804dacc5-00d3-4169-aa74-0099f89d822d"), "Gómez", new DateTime(1996, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isabel", "Estudiante" },
                    { new Guid("a7407eac-9489-4692-9047-ab65d677d1e0"), "Díaz", new DateTime(1991, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Francisco", "Estudiante" },
                    { new Guid("d92cc1cd-957a-4aeb-809b-41f0f05a1ad7"), "Hernández", new DateTime(1994, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sofía", "Estudiante" },
                    { new Guid("d9412190-0da6-4485-9538-c6108dbd604a"), "Fernández", new DateTime(1989, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roberto", "Estudiante" },
                    { new Guid("ddae919b-46fe-4102-bea1-22a2c1481199"), "Martínez", new DateTime(1993, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana", "Estudiante" }
                });

            migrationBuilder.InsertData(
                table: "Cupo",
                columns: new[] { "CupoId", "CandidatoEstudianteId", "CantidadDisponible", "Comentarios", "Descripcion", "Duracion", "Estado", "FechaFin", "FechaInicio", "Ubicacion" },
                values: new object[,]
                {
                    { new Guid("0ffde711-e5b6-415c-9688-7576b2936f05"), new Guid("45c05980-18f8-4d72-81e5-8b25ae3d5b73"), 15, "Cupo para diseñadores creativos", "Cupo para el curso de diseño gráfico", new TimeSpan(0, 2, 0, 0, 0), true, new DateTime(2024, 1, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(2824), new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(2823), "Aula 103" },
                    { new Guid("8b73345b-dbcc-4307-8cec-92e3c03e3154"), new Guid("2c25d8c9-c19f-41a1-ad8c-d1ea143be1f8"), 20, "Cupo para profesionales de marketing", "Cupo para el seminario de marketing", new TimeSpan(0, 4, 0, 0, 0), true, new DateTime(2023, 12, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(2819), new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(2818), "Aula 102" },
                    { new Guid("99c6e336-c81c-4e49-95ad-8ca4bcf981d2"), new Guid("e7cad3c2-d134-4215-af9a-5b765744b964"), 5, "Cupo para desarrolladores junior", "Cupo para el taller de programación", new TimeSpan(0, 3, 0, 0, 0), true, new DateTime(2023, 11, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(2816), new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(2815), "Aula 101" },
                    { new Guid("a4679b4b-79e8-4a90-88c5-43372ad78186"), new Guid("3061c8ff-d37e-4aef-b289-fff7ff116990"), 30, "Cupo para establecer contactos profesionales", "Cupo para el evento de networking", new TimeSpan(0, 1, 0, 0, 0), true, new DateTime(2024, 2, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(2827), new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(2827), "Aula 104" },
                    { new Guid("b348931a-9638-4c58-8fd6-ad8b0512dc1a"), new Guid("540e0c88-9bff-4a91-a34e-23d7c1915583"), 10, "Cupo para estudiantes universitarios", "Cupo para el evento principal", new TimeSpan(0, 2, 0, 0, 0), true, new DateTime(2023, 10, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(2804), new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(2803), "Salón principal" }
                });

            migrationBuilder.InsertData(
                table: "DireccionAcudiente",
                columns: new[] { "DireccionAcudienteId", "AcudienteId", "Calle", "CiudadLocalidad", "CodigoPostal", "ColoniaBarrio", "EstadoProvincia", "Pais" },
                values: new object[,]
                {
                    { new Guid("055cdf5f-1bbb-496c-bfd5-af1da659c01c"), new Guid("00000000-0000-0000-0000-000000000000"), "Avenida 68", "Bogotá", "110841", "Kennedy", "Bogotá D.C.", "Colombia" },
                    { new Guid("588c0765-72a7-41d7-b564-d698eb3b7a55"), new Guid("00000000-0000-0000-0000-000000000000"), "Calle 72", "Bogotá", "110231", "Chapinero", "Bogotá D.C.", "Colombia" },
                    { new Guid("9b60cad5-2509-445b-aca9-86e2d36a1c77"), new Guid("00000000-0000-0000-0000-000000000000"), "Carrera 7", "Bogotá", "110171", "Usaquén", "Bogotá D.C.", "Colombia" },
                    { new Guid("9cf9cef0-9007-4966-b767-4eb36332475d"), new Guid("00000000-0000-0000-0000-000000000000"), "Calle 80", "Bogotá", "110841", "Engativá", "Bogotá D.C.", "Colombia" },
                    { new Guid("bc946c76-e037-4259-8509-ddd6714c695e"), new Guid("00000000-0000-0000-0000-000000000000"), "Carrera 10", "Bogotá", "110321", "La Candelaria", "Bogotá D.C.", "Colombia" },
                    { new Guid("dcfda25c-4b14-4c5f-982f-723b93905ab0"), new Guid("00000000-0000-0000-0000-000000000000"), "Avenida Boyacá", "Bogotá", "110511", "Fontibón", "Bogotá D.C.", "Colombia" },
                    { new Guid("e68fc3d3-ba06-451f-86fc-1a82e1db8fdf"), new Guid("00000000-0000-0000-0000-000000000000"), "Calle 72", "Bogotá", "110231", "Chapinero", "Bogotá D.C.", "Colombia" }
                });

            migrationBuilder.InsertData(
                table: "EstudianteDocumentos",
                columns: new[] { "EstudianteDocumentosId", "CandidatoEstudianteId", "Estado", "FechaActualizacion", "NombreDocumento", "NumeroDocumento", "Observaciones", "Tamaño", "TipoDocumento", "Ubicacion" },
                values: new object[,]
                {
                    { new Guid("10a5e754-1570-4be0-8650-2c53d7cfb4d3"), new Guid("b3b5a5a7-5b82-4f76-98c1-654589db8f61"), true, new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(1943), "Fotografía del Estudiante", 1111111, "Foto de perfil", 1024, "Identificación", "ruta/al/documento10" },
                    { new Guid("2d54a999-187f-4a8c-99db-d17841e7938c"), new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), true, new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(1908), "Diploma", 987654, "Logros académicos", 2048, "Educativo", "ruta/al/documento2" },
                    { new Guid("3e68515e-3a47-4a62-a8c7-9f12242d020e"), new Guid("4f3657e5-5824-47b8-b4cd-6f49a3f4dbf1"), false, new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(1922), "Certificado de Graduación", 123456, "Graduación universitaria", 1536, "Educativo", "ruta/al/documento3" },
                    { new Guid("4a303cce-8c0e-4ae7-89c1-067d0b7741b6"), new Guid("3e68515e-3a47-4a62-a8c7-9f12242d020e"), true, new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(1926), "Certificado de Matrícula", 789012, "Matrícula escolar", 8192, "Educativo", "ruta/al/documento4" },
                    { new Guid("5f78d0e1-579e-4dfc-82a1-92010b4191d3"), new Guid("31eb541a-9419-4eac-bf1b-0289a6c6f6f0"), true, new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(1931), "Cédula de Identidad", 555555, "Documento oficial", 4096, "Identificación", "ruta/al/documento5" },
                    { new Guid("6a30c846-4b9d-4cf5-bb17-051a3e9d1b72"), new Guid("c9d4c053-49b6-410c-bc78-2d54a999187f"), true, null, "Certificado de Nacimiento", 61464465, "Ninguna", 1024, "Identificación", "ruta/al/documento1" },
                    { new Guid("7e15d9a4-98cb-4d14-9a35-862f8c202725"), new Guid("bb9b0679-4f04-4ac4-9ddc-5c3e50e81298"), true, new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(1936), "Boleta de Calificaciones", 9876543, "Registro académico", 5120, "Educativo", "ruta/al/documento7" },
                    { new Guid("8f4a67c2-fd5e-4316-8c50-7249f159d0f1"), new Guid("a6509bea-688e-43b5-a870-6ee461ccf601"), true, new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(1938), "Pasaporte", 1234567, "Documento de viaje", 4096, "Identificación", "ruta/al/documento8" },
                    { new Guid("9b9d6d8f-72f0-4f0a-8e18-1e75b0182e3f"), new Guid("db9fcac5-8654-45c3-87c7-8b5e13e9e6c2"), true, new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(1941), "Certificado Médico", 543210, "Informe médico", 2048, "Salud", "ruta/al/documento9" },
                    { new Guid("f38f6b1a-86e9-4d9d-8a7a-62f17e6f1ba2"), new Guid("7f255218-f8e0-45a9-9807-12e1bcfd438c"), true, new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(1934), "Carné de Estudiante", 7890123, "Carné escolar", 3072, "Identificación", "ruta/al/documento6" }
                });

            migrationBuilder.InsertData(
                table: "Matricula",
                columns: new[] { "MatriculaId", "CategoriaMatricula", "Comentarios", "EstadoMatricula", "FechaMatricula", "InformacionPlanEstudios", "PeriodoAcademico", "RegistroCambios", "TipoMatricula" },
                values: new object[,]
                {
                    { new Guid("1424202b-7d11-417f-88c5-c79530798594"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 5", "Activa", new DateTime(2024, 1, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3455), "Plan de estudios 2023", 2023, "Registro de cambios 5", "Matrícula Regular" },
                    { new Guid("14f42d9e-06c2-4900-8257-df235dc74760"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 1", "Activa", new DateTime(2023, 9, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3443), "Plan de estudios 2023", 2023, "Registro de cambios 1", "Matrícula Regular" },
                    { new Guid("28d35eda-1b85-4566-9477-e0c035523b6d"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 4", "Activa", new DateTime(2023, 12, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3453), "Plan de estudios 2023", 2023, "Registro de cambios 4", "Matrícula Regular" },
                    { new Guid("bbc21fcc-433a-4550-b0b0-94b1a799fb39"), "Estudiante Internacional", "Comentario sobre la matrícula 3", "Cancelada", new DateTime(2023, 11, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3450), "Plan de estudios 2023", 2023, "Registro de cambios 3", "Matrícula Regular" },
                    { new Guid("f95e7730-3074-46c4-89c9-525682548f48"), "Estudiante de Tiempo Parcial", "Comentario sobre la matrícula 2", "Pendiente", new DateTime(2023, 10, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3448), "Plan de estudios 2023", 2023, "Registro de cambios 2", "Matrícula Parcial" }
                });

            migrationBuilder.InsertData(
                table: "PreMatricula",
                columns: new[] { "PreMatriculaId", "EstadoPreMatricula", "GradoONivel", "Observaciones", "RequisitosDocumentacion", "Turno" },
                values: new object[,]
                {
                    { new Guid("05d7a5db-3c4b-4aca-b5fc-08a8159706d7"), "Pendiente", "Tercero de Primaria", "Estudiante extranjero.", "SiCumplio", "Mañana" },
                    { new Guid("0b323115-dfc4-47bf-8926-1da6d57e27c4"), "Pendiente", "Quinto de Primaria", "Estudiante con requerimientos especiales.", "NoCumplio", "Mañana" },
                    { new Guid("3c04a32b-03fa-4e75-96a5-e883e54e633e"), "Activa", "Cuarto de Secundaria", "Estudiante con beca deportiva.", "SiCumplio", "Tarde" },
                    { new Guid("46f647e0-853e-4b79-82bf-c751013f95a6"), "Activa", "Segundo de Primaria", "Estudiante con discapacidad visual.", "SiCumplio", "Mañana" },
                    { new Guid("519c43b4-ec15-421b-90ae-73102e017034"), "Activa", "Séptimo de Secundaria", "Estudiante de transferencia.", "SiCumplio", "Tarde" },
                    { new Guid("8ebf3c17-f3ee-4e9f-b90c-1204be3e7b1c"), "Pendiente", "Octavo de Secundaria", "Estudiante sin observaciones adicionales.", "Si cumplio", "Tarde" }
                });

            migrationBuilder.InsertData(
                table: "RespuestaCupo",
                columns: new[] { "RespuestaCupoId", "DuracionRespuesta", "EstadoRespuesta", "FechaRespuesta", "FechaVencimiento", "MensajeRespuesta", "Prioridad", "TipoRespuesta", "UsuarioRespuesta" },
                values: new object[,]
                {
                    { new Guid("08c5bb2c-f105-4746-9d1f-ef291ba77905"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2023, 9, 20, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3014), new DateTime(2023, 10, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3023), "Respuesta 1", "Alta", "Aceptación", "Usuario1" },
                    { new Guid("09ba4c9e-8606-4a52-aa65-5f5695962da0"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2023, 9, 25, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3039), new DateTime(2024, 3, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3040), "Respuesta 6", "Alta", "Aceptación", "Usuario6" },
                    { new Guid("2816aa8d-31e9-45cf-b087-bc9455258d91"), new TimeSpan(60, 0, 0, 0, 0), "Pendiente", new DateTime(2023, 9, 22, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3030), new DateTime(2023, 12, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3031), "Respuesta 3", "Baja", "Pendiente", "Usuario3" },
                    { new Guid("3b242839-797d-4ba0-9658-c680ed7963bd"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2023, 9, 26, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3042), new DateTime(2024, 4, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3043), "Respuesta 7", "Media", "Rechazo", "Usuario7" },
                    { new Guid("3e335b71-3492-4ec1-a342-85133733c076"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2023, 9, 28, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3047), new DateTime(2024, 6, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3047), "Respuesta 9", "Alta", "Aceptación", "Usuario9" },
                    { new Guid("43e65a26-0ab8-4bb5-b95a-79999650b930"), new TimeSpan(60, 0, 0, 0, 0), "Pendiente", new DateTime(2023, 9, 27, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3044), new DateTime(2024, 5, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3045), "Respuesta 8", "Baja", "Pendiente", "Usuario8" },
                    { new Guid("4a36c0f6-0e4f-4669-b7e2-e6896c034533"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2023, 9, 21, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3028), new DateTime(2023, 11, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3029), "Respuesta 2", "Media", "Rechazo", "Usuario2" },
                    { new Guid("976be678-906b-4ecd-9572-44ba3bcb856c"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2023, 9, 24, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3037), new DateTime(2024, 2, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3038), "Respuesta 5", "Media", "Rechazo", "Usuario5" },
                    { new Guid("b9d3729f-8049-4282-8094-b3caa1c345ef"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2023, 9, 23, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3033), new DateTime(2024, 1, 19, 19, 55, 17, 403, DateTimeKind.Local).AddTicks(3034), "Respuesta 4", "Alta", "Aceptación", "Usuario4" }
                });

            migrationBuilder.InsertData(
                table: "TelefonoAcudiente",
                columns: new[] { "TelefonoAcudienteId", "AcudienteId", "Indicativo", "Numero", "Tipo" },
                values: new object[,]
                {
                    { new Guid("50fd0c27-a9a5-498d-a3a5-2cc909e14db9"), 1, "+1", -4135, "Móvil" },
                    { new Guid("55a93a85-4554-4062-8653-fe274f668bf1"), 1, "+1", -667, "Móvil" },
                    { new Guid("5f206690-0330-4f5b-83d3-702e2941c89b"), 2, "+1", -6975, "Móvil" },
                    { new Guid("6f94f3eb-c94c-472c-bb06-f2b681cfedf5"), 5, "+1", 911, "Emergencia" },
                    { new Guid("71bdf0de-175b-4353-818b-f60548dd5cf1"), 4, "+1", -5753, "Móvil" },
                    { new Guid("7be3bbe2-2158-4a43-a022-83cf3cdd2d46"), 3, "+1", -3111, "Fijo" },
                    { new Guid("9709a9d1-d5d9-4734-b556-393530c5dd2a"), 4, "+1", -4333, "Móvil" },
                    { new Guid("bb978121-56ca-4328-b9b5-914b1c770fde"), 3, "+1", -5357, "Fijo" },
                    { new Guid("d58a83de-6694-431b-90e5-98eca18473eb"), 5, "+1", -5555, "Emergencia" },
                    { new Guid("f45afba4-5184-4d73-87ac-ddf32cacc06c"), 2, "+1", -1889, "Móvil" }
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

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
                name: "Aulas",
                columns: table => new
                {
                    AulaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreNumero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacidad = table.Column<int>(type: "int", nullable: false),
                    TipoAula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoAula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HorarioDisponibilidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotasAdicionales = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UltimaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResponsableAula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrosIncidentesProblemas = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aulas", x => x.AulaId);
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
                name: "Cursos",
                columns: table => new
                {
                    CursoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartamentoAcademico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nivel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfesorAsignado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AulasAsignadas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaLimiteInscripcion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MetodosEnsenanza = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.CursoId);
                });

            migrationBuilder.CreateTable(
                name: "DireccionAcudiente",
                columns: table => new
                {
                    DireccionAcudienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Calle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColoniaBarrio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CiudadLocalidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoProvincia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "Horarios",
                columns: table => new
                {
                    HorarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiaSemana = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoraInicio = table.Column<TimeSpan>(type: "time", nullable: false),
                    HoraFin = table.Column<TimeSpan>(type: "time", nullable: false),
                    PeriodoAcademico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrupoSeccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaInicioClases = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinClases = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoHorario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DuracionClaseMinutos = table.Column<int>(type: "int", nullable: false),
                    SalaAula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfesorAsistente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotificacionCambioHorario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios", x => x.HorarioId);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    MateriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartamentoAcademico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nivel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfesorAsignado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModalidadEnsenanza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotasAdicionales = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrupoSeccionMateria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetodosEnsenanza = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.MateriaId);
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
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    { new Guid("245d7546-6317-4a5e-8873-e1f03d204659"), "Pérez", "maria.perez@email.com", true, "Casada", new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(3990), "Femenino", "María", 12345, "Ingeniera", "Madre" },
                    { new Guid("445ac000-46eb-4b2e-942c-4a326eb7aa2f"), "Luna", "roberto.luna@email.com", true, "Viudo", new DateTime(1970, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4014), "Masculino", "Roberto", 10293, "Jubilado", "Abuelo" },
                    { new Guid("6635601d-5acd-47a3-bfe8-3f3daa56df65"), "López", "ana.lopez@email.com", true, "Divorciada", new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(3996), "Femenino", "Ana", 54321, "Médica", "Tutor Legal" },
                    { new Guid("7e4115a2-5eaa-4f03-a055-2d6f202bd946"), "Martínez", "pedro.martinez@email.com", true, "Casado", new DateTime(1988, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(3998), "Masculino", "Pedro", 98765, "Profesor", "Padre" },
                    { new Guid("8d427a0e-48d2-4a46-86f7-a3de25dbb533"), "Gómez", "laura.gomez@email.com", true, "Divorciada", new DateTime(1992, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4007), "Femenino", "Laura", 86420, "Médica", "Madre" },
                    { new Guid("b556b99b-376b-483e-a24a-4d1f551e568e"), "Hernández", "andres.hernandez@email.com", true, "Casado", new DateTime(1979, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4010), "Masculino", "Andrés", 97531, "Arquitecto", "Padrino" },
                    { new Guid("c18439f5-f22e-4ba3-9605-1af15d29fd17"), "González", "juan.gonzalez@email.com", true, "Soltero", new DateTime(1975, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(3993), "Masculino", "Juan", 67890, "Abogado", "Padre" },
                    { new Guid("cac42b95-84a3-4caf-94a4-563d7e171ff2"), "Rodríguez", "carlos.rodriguez@email.com", true, "Soltero", new DateTime(1985, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4005), "Masculino", "Carlos", 24680, "Ingeniero Civil", "Tío" },
                    { new Guid("f4eca209-bb99-4c97-98fe-56d201d9e34b"), "Sánchez", "luis.sanchez@email.com", true, "Casado", new DateTime(1972, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4003), "Masculino", "Luis", 13579, "Contador", "Padre" },
                    { new Guid("fa3282b4-7cf4-4000-bc6a-3056ec7e0a5b"), "Díaz", "sofia.diaz@email.com", true, "Soltera", new DateTime(1987, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4012), "Femenino", "Sofía", 75319, "Profesora", "Tía" }
                });

            migrationBuilder.InsertData(
                table: "Aulas",
                columns: new[] { "AulaId", "Capacidad", "EstadoAula", "HorarioDisponibilidad", "NombreNumero", "NotasAdicionales", "RegistrosIncidentesProblemas", "ResponsableAula", "TipoAula", "Ubicacion", "UltimaActualizacion" },
                values: new object[,]
                {
                    { new Guid("2d863009-2650-4ce4-8ada-b42b8953fe36"), 100, "Disponible", "Disponible previa reserva", "Aula 103", "Equipada con proyector y sistema de sonido", "Ninguno", "Personal de Eventos", "Sala de Conferencias", "Edificio de Eventos", new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5d0d63ea-f0b4-4903-92d2-9fdfa29bffc0"), 30, "Ocupado", "Lunes a Viernes, 10:00 AM - 05:00 PM", "Aula 102", "Equipado con computadoras de última generación", "Reporte de fallo en una computadora", "Profesor Responsable 2", "Laboratorio de Informática", "Edificio de Ciencias", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bf25f240-9c56-4112-b1dd-be1819bebec5"), 10, "Disponible", "Lunes a Domingo, 09:00 AM - 11:00 PM", "Aula 105", "Área de estudio tranquila", "Ninguno", "Bibliotecario", "Sala de Estudio", "Biblioteca", new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d778acaa-16c4-4c7f-aadb-22c2c42c4ad8"), 50, "Disponible", "Lunes a Viernes, 08:00 AM - 06:00 PM", "Aula 101", "Equipada con proyector", "Ninguno", "Profesor Responsable 1", "Salón de Clases", "Edificio Principal", new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f2af438a-8efb-46e4-a95e-4afed9a75b98"), 40, "En Mantenimiento", "No disponible temporalmente", "Aula 104", "Mantenimiento programado", "Reporte de fugas de agua en el techo", "Personal de Mantenimiento", "Salón de Clases", "Edificio Principal", new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CandidatoEstudiantes",
                columns: new[] { "CandidatoEstudianteId", "Apellido", "FechaNacimiento", "Nombre", "TipoPersona" },
                values: new object[,]
                {
                    { new Guid("045da293-1d5b-4795-b32e-b086aaf8d90a"), "López", new DateTime(2000, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura", "Estudiante" },
                    { new Guid("4135f9b8-1031-4ad8-88c1-28fec4a01245"), "Sánchez", new DateTime(1987, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos", "Estudiante" },
                    { new Guid("6820d69c-05cc-44b4-a373-2bbd7207d93f"), "Gómez", new DateTime(1996, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isabel", "Estudiante" },
                    { new Guid("816205b7-d23a-45d6-a612-f36acd97f930"), "Martínez", new DateTime(1993, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana", "Estudiante" },
                    { new Guid("927f82d8-fdeb-433b-929c-6d47b662e6f0"), "Díaz", new DateTime(1991, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Francisco", "Estudiante" },
                    { new Guid("95e9584c-7b97-4edc-bf2b-b9846674c701"), "Castro", new DateTime(1990, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan", "Estudiante" },
                    { new Guid("a31c548e-2242-4d1d-9a87-d46288b4b326"), "Fernández", new DateTime(1989, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roberto", "Estudiante" },
                    { new Guid("af1818ea-391b-4f50-8772-d49438d03cf4"), "Ramírez", new DateTime(1998, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pedro", "Estudiante" },
                    { new Guid("c31f42d6-2e4a-40d3-a42d-a76ba51a6fdc"), "Acuña", new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Axl", "Estudiante" },
                    { new Guid("f02037be-aee2-48ec-bb26-77085f6fc534"), "Hernández", new DateTime(1994, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sofía", "Estudiante" }
                });

            migrationBuilder.InsertData(
                table: "Cupo",
                columns: new[] { "CupoId", "CantidadDisponible", "Descripcion", "Duracion", "Estado", "FechaFin", "FechaInicio", "Ubicacion" },
                values: new object[,]
                {
                    { new Guid("07109f37-f3e4-488d-b4d7-2cf302af36ca"), 30, "Cupo para el evento de networking", new TimeSpan(0, 1, 0, 0, 0), true, new DateTime(2024, 2, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4626), new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4625), "Aula 104" },
                    { new Guid("0fe43e64-e710-41b0-9c2a-28d203b30356"), 5, "Cupo para el taller de programación", new TimeSpan(0, 3, 0, 0, 0), true, new DateTime(2023, 11, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4619), new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4618), "Aula 101" },
                    { new Guid("7280e420-cb81-42e6-8f5b-a58658d5c16c"), 20, "Cupo para el seminario de marketing", new TimeSpan(0, 4, 0, 0, 0), true, new DateTime(2023, 12, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4621), new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4621), "Aula 102" },
                    { new Guid("9f1d3f87-d445-46a5-9526-de92ce54fad6"), 15, "Cupo para el curso de diseño gráfico", new TimeSpan(0, 2, 0, 0, 0), true, new DateTime(2024, 1, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4623), new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4623), "Aula 103" },
                    { new Guid("e23911f8-ed32-4909-a61f-c6300ff0e734"), 10, "Cupo para el evento principal", new TimeSpan(0, 2, 0, 0, 0), true, new DateTime(2023, 10, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4604), new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4602), "Salón principal" }
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "CursoId", "AulasAsignadas", "Codigo", "DepartamentoAcademico", "Descripcion", "FechaLimiteInscripcion", "MetodosEnsenanza", "Nivel", "ProfesorAsignado" },
                values: new object[,]
                {
                    { new Guid("14141373-31f7-473f-8d6e-ad6f3dc2a1ba"), "Chemistry Lab 201", "CHEM201", "Chemistry Department", "Organic Chemistry", new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lectures, laboratory experiments", "Second Semester", "Professor 4" },
                    { new Guid("6396b10e-5114-41d2-82b2-f2d6fac48880"), "Classroom 201, Classroom 202", "ENG201", "English Department", "Advanced English Composition", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lectures, writing assignments, group discussions", "Second Semester", "Professor 2" },
                    { new Guid("a3305a56-e308-4259-8123-44d8e8845c32"), "Aula 101, Aula 102", "CS101", "Ciencias de la Computación", "Introducción a la Programación", new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clases magistrales, laboratorios prácticos", "Primer Semestre", "Profesor 1" },
                    { new Guid("cbe3eccf-376f-45d8-bc38-1fb14b005b0a"), "History Classroom 101", "HIST101", "History Department", "Introduction to History", new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lectures, discussions, research papers", "First Semester", "Professor 5" },
                    { new Guid("d1dd4a94-0fe6-4767-aaa3-c8f1011a9a90"), "Math Classroom 301", "MATH301", "Mathematics Department", "Advanced Calculus", new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lectures, problem sets, exams", "Third Semester", "Professor 3" }
                });

            migrationBuilder.InsertData(
                table: "DireccionAcudiente",
                columns: new[] { "DireccionAcudienteId", "Calle", "CiudadLocalidad", "CodigoPostal", "ColoniaBarrio", "EstadoProvincia", "Pais" },
                values: new object[,]
                {
                    { new Guid("1047f0d3-c8ef-499a-b7a0-ef1236e53de8"), "Avenida Boyacá", "Bogotá", "110511", "Fontibón", "Bogotá D.C.", "Colombia" },
                    { new Guid("139d28a4-cbce-4b58-b378-0526b22a7419"), "Calle 80", "Bogotá", "110841", "Engativá", "Bogotá D.C.", "Colombia" },
                    { new Guid("6f744431-0b8d-4b0d-9985-e31d2d47a80c"), "Carrera 7", "Bogotá", "110171", "Usaquén", "Bogotá D.C.", "Colombia" },
                    { new Guid("747ec17a-d2fa-4dfc-8351-ea89aafec2e7"), "Calle 72", "Bogotá", "110231", "Chapinero", "Bogotá D.C.", "Colombia" },
                    { new Guid("7e50b694-44e1-4019-b9a2-4d4afbb3b015"), "Carrera 10", "Bogotá", "110321", "La Candelaria", "Bogotá D.C.", "Colombia" },
                    { new Guid("872e6d62-c3ee-4b4e-b856-d1b4ae2a018e"), "Calle 72", "Bogotá", "110231", "Chapinero", "Bogotá D.C.", "Colombia" },
                    { new Guid("8b065f15-90f7-499b-8a9b-5d19584b6212"), "Avenida 68", "Bogotá", "110841", "Kennedy", "Bogotá D.C.", "Colombia" }
                });

            migrationBuilder.InsertData(
                table: "EstudianteDocumentos",
                columns: new[] { "EstudianteDocumentosId", "CandidatoEstudianteId", "Estado", "FechaActualizacion", "NombreDocumento", "NumeroDocumento", "Observaciones", "Tamaño", "TipoDocumento", "Ubicacion" },
                values: new object[,]
                {
                    { new Guid("10a5e754-1570-4be0-8650-2c53d7cfb4d3"), new Guid("b3b5a5a7-5b82-4f76-98c1-654589db8f61"), true, new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(3805), "Fotografía del Estudiante", 1111111, "Foto de perfil", 1024, "Identificación", "ruta/al/documento10" },
                    { new Guid("2d54a999-187f-4a8c-99db-d17841e7938c"), new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), true, new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(3772), "Diploma", 987654, "Logros académicos", 2048, "Educativo", "ruta/al/documento2" },
                    { new Guid("3e68515e-3a47-4a62-a8c7-9f12242d020e"), new Guid("4f3657e5-5824-47b8-b4cd-6f49a3f4dbf1"), false, new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(3788), "Certificado de Graduación", 123456, "Graduación universitaria", 1536, "Educativo", "ruta/al/documento3" },
                    { new Guid("4a303cce-8c0e-4ae7-89c1-067d0b7741b6"), new Guid("3e68515e-3a47-4a62-a8c7-9f12242d020e"), true, new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(3791), "Certificado de Matrícula", 789012, "Matrícula escolar", 8192, "Educativo", "ruta/al/documento4" },
                    { new Guid("5f78d0e1-579e-4dfc-82a1-92010b4191d3"), new Guid("31eb541a-9419-4eac-bf1b-0289a6c6f6f0"), true, new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(3794), "Cédula de Identidad", 555555, "Documento oficial", 4096, "Identificación", "ruta/al/documento5" },
                    { new Guid("6a30c846-4b9d-4cf5-bb17-051a3e9d1b72"), new Guid("c9d4c053-49b6-410c-bc78-2d54a999187f"), true, null, "Certificado de Nacimiento", 61464465, "Ninguna", 1024, "Identificación", "ruta/al/documento1" },
                    { new Guid("7e15d9a4-98cb-4d14-9a35-862f8c202725"), new Guid("bb9b0679-4f04-4ac4-9ddc-5c3e50e81298"), true, new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(3799), "Boleta de Calificaciones", 9876543, "Registro académico", 5120, "Educativo", "ruta/al/documento7" },
                    { new Guid("8f4a67c2-fd5e-4316-8c50-7249f159d0f1"), new Guid("a6509bea-688e-43b5-a870-6ee461ccf601"), true, new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(3801), "Pasaporte", 1234567, "Documento de viaje", 4096, "Identificación", "ruta/al/documento8" },
                    { new Guid("9b9d6d8f-72f0-4f0a-8e18-1e75b0182e3f"), new Guid("db9fcac5-8654-45c3-87c7-8b5e13e9e6c2"), true, new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(3803), "Certificado Médico", 543210, "Informe médico", 2048, "Salud", "ruta/al/documento9" },
                    { new Guid("f38f6b1a-86e9-4d9d-8a7a-62f17e6f1ba2"), new Guid("7f255218-f8e0-45a9-9807-12e1bcfd438c"), true, new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(3796), "Carné de Estudiante", 7890123, "Carné escolar", 3072, "Identificación", "ruta/al/documento6" }
                });

            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "HorarioId", "DiaSemana", "DuracionClaseMinutos", "EstadoHorario", "FechaFinClases", "FechaInicioClases", "GrupoSeccion", "HoraFin", "HoraInicio", "NotificacionCambioHorario", "PeriodoAcademico", "ProfesorAsistente", "SalaAula" },
                values: new object[,]
                {
                    { new Guid("03ad99be-92aa-4e2c-bc43-37d59a6f5cfa"), "Miércoles", 120, "Activo", new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupo C", new TimeSpan(0, 13, 30, 0, 0), new TimeSpan(0, 11, 30, 0, 0), "No", "Semestre de Verano", "Profesor Asistente 3", "Aula 305" },
                    { new Guid("3a487a63-01f0-4778-a51e-726a1db399a6"), "Viernes", 120, "Activo", new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupo E", new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), "No", "Semestre de Primavera", "Profesor Asistente 5", "Aula 102" },
                    { new Guid("a95fb80a-56fb-466e-b350-a08c72716750"), "Jueves", 120, "Activo", new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupo D", new TimeSpan(0, 18, 30, 0, 0), new TimeSpan(0, 16, 30, 0, 0), "Sí", "Semestre de Invierno", "Profesor Asistente 4", "Aula 401" },
                    { new Guid("acaec0ce-31d5-45ee-bb08-730d1b85ad08"), "Lunes", 120, "Activo", new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupo A", new TimeSpan(0, 11, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), "No", "Semestre de Otoño", "Profesor Asistente 1", "Aula 101" },
                    { new Guid("ef3190a9-2915-4a56-b2ed-7b259b019824"), "Martes", 120, "Activo", new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupo B", new TimeSpan(0, 16, 0, 0, 0), new TimeSpan(0, 14, 0, 0, 0), "Sí", "Semestre de Primavera", "Profesor Asistente 2", "Aula 203" }
                });

            migrationBuilder.InsertData(
                table: "Materias",
                columns: new[] { "MateriaId", "DepartamentoAcademico", "Descripcion", "Estado", "GrupoSeccionMateria", "MetodosEnsenanza", "ModalidadEnsenanza", "Nivel", "Nombre", "NotasAdicionales", "ProfesorAsignado" },
                values: new object[,]
                {
                    { new Guid("00d82c08-d406-4d23-89a1-6d0b3c6d1143"), "Departamento de Arte", "Curso de Arte Contemporáneo", "Inscripciones abiertas", "Grupo G", "Prácticas artísticas y exposiciones", "Presencial", "Intermedio", "Arte", "No se requiere experiencia previa en arte.", "Profesor de Arte" },
                    { new Guid("08219c80-ff83-4553-961e-4cf9e8ebf4ba"), "Departamento de Informática", "Curso de Ciencias de la Computación", "En progreso", "Grupo C", "Clases virtuales y proyectos prácticos", "En línea", "Avanzado", "Ciencias de la Computación", "Requiere acceso a una computadora.", "Profesor de Informática" },
                    { new Guid("2879dce7-6402-4189-8c33-19daae59405d"), "Departamento de Física", "Curso de Física Avanzada", "Completo", "Grupo E", "Experimentos y clases teóricas", "Presencial", "Avanzado", "Física", "Requiere conocimientos previos de física.", "Profesor de Física" },
                    { new Guid("32a4eca1-320c-4828-9886-e5af6e1ccc3e"), "Departamento de Literatura", "Curso de Literatura Universal", "Inscripciones abiertas", "Grupo D", "Lecturas y discusiones literarias", "Presencial", "Intermedio", "Literatura", "Apto para amantes de la lectura.", "Profesor Literario" },
                    { new Guid("48a999fc-6d4b-45f7-b26d-3ea5e5e2f1c6"), "Departamento de Economía", "Curso de Economía Moderna", "En progreso", "Grupo F", "Clases virtuales y análisis económico", "En línea", "Intermedio", "Economía", "Abordaremos temas financieros actuales.", "Profesor Economista" },
                    { new Guid("809ab068-ee25-4af5-bf04-3cfd23eca26e"), "Departamento de Matemáticas", "Curso de Matemáticas Avanzadas", "En progreso", "Grupo A", "Clases teóricas y prácticas", "Presencial", "Avanzado", "Matemáticas", "Se requiere calculadora científica.", "Profesor Matemático" },
                    { new Guid("fde2c5d6-c4b2-4d8d-b27e-956283f722b8"), "Departamento de Historia", "Curso de Historia Mundial", "Inscripciones abiertas", "Grupo B", "Conferencias y debates", "Presencial", "Intermedio", "Historia", "Recomendado para estudiantes de Historia.", "Profesor Historiador" }
                });

            migrationBuilder.InsertData(
                table: "Matricula",
                columns: new[] { "MatriculaId", "CategoriaMatricula", "Comentarios", "EstadoMatricula", "FechaMatricula", "InformacionPlanEstudios", "PeriodoAcademico", "RegistroCambios", "TipoMatricula" },
                values: new object[,]
                {
                    { new Guid("5e106de1-2da6-4169-9917-7860696fe682"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 4", "Activa", new DateTime(2023, 12, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(5153), "Plan de estudios 2023", 2023, "Registro de cambios 4", "Matrícula Regular" },
                    { new Guid("830c1f65-f764-45c2-a167-b0d9b08c9ad4"), "Estudiante de Tiempo Parcial", "Comentario sobre la matrícula 2", "Pendiente", new DateTime(2023, 10, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(5147), "Plan de estudios 2023", 2023, "Registro de cambios 2", "Matrícula Parcial" },
                    { new Guid("848b44fe-4475-4ff1-9a4a-a75f6c016203"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 5", "Activa", new DateTime(2024, 1, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(5155), "Plan de estudios 2023", 2023, "Registro de cambios 5", "Matrícula Regular" },
                    { new Guid("f4aecf6d-7f7d-499a-8bed-ecd42fac4747"), "Estudiante Internacional", "Comentario sobre la matrícula 3", "Cancelada", new DateTime(2023, 11, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(5151), "Plan de estudios 2023", 2023, "Registro de cambios 3", "Matrícula Regular" },
                    { new Guid("fae7bdcc-e88b-41b4-8093-cf424307e597"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 1", "Activa", new DateTime(2023, 9, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(5143), "Plan de estudios 2023", 2023, "Registro de cambios 1", "Matrícula Regular" }
                });

            migrationBuilder.InsertData(
                table: "PreMatricula",
                columns: new[] { "PreMatriculaId", "EstadoPreMatricula", "GradoONivel", "Observaciones", "RequisitosDocumentacion", "Turno" },
                values: new object[,]
                {
                    { new Guid("298729ff-84d6-4616-bd75-4a52412ef10d"), "Pendiente", "Octavo de Secundaria", "Estudiante sin observaciones adicionales.", "Si cumplio", "Tarde" },
                    { new Guid("2e74add9-ea21-4b6a-b906-11e04cb783af"), "Activa", "Segundo de Primaria", "Estudiante con discapacidad visual.", "SiCumplio", "Mañana" },
                    { new Guid("7e364df1-cf17-4238-b61d-6f06617a894e"), "Activa", "Séptimo de Secundaria", "Estudiante de transferencia.", "SiCumplio", "Tarde" },
                    { new Guid("867a6251-3977-40be-80b3-9a83a09e637d"), "Pendiente", "Tercero de Primaria", "Estudiante extranjero.", "SiCumplio", "Mañana" },
                    { new Guid("8f5940de-42b6-4667-82c5-37484eb87c05"), "Pendiente", "Quinto de Primaria", "Estudiante con requerimientos especiales.", "NoCumplio", "Mañana" },
                    { new Guid("dec625be-47c3-4142-a234-454b89bcaad5"), "Activa", "Cuarto de Secundaria", "Estudiante con beca deportiva.", "SiCumplio", "Tarde" }
                });

            migrationBuilder.InsertData(
                table: "RespuestaCupo",
                columns: new[] { "RespuestaCupoId", "DuracionRespuesta", "EstadoRespuesta", "FechaRespuesta", "FechaVencimiento", "MensajeRespuesta", "Prioridad", "TipoRespuesta", "UsuarioRespuesta" },
                values: new object[,]
                {
                    { new Guid("0147f305-e959-4eca-bed1-a038bdd69077"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2023, 9, 27, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4819), new DateTime(2024, 4, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4820), "Respuesta 7", "Media", "Rechazo", "Usuario7" },
                    { new Guid("59395608-a7db-49dc-b156-32b952e7a421"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2023, 9, 21, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4794), new DateTime(2023, 10, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4799), "Respuesta 1", "Alta", "Aceptación", "Usuario1" },
                    { new Guid("6382b9b5-172b-4855-acbe-4c9fedd3ad14"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2023, 9, 24, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4809), new DateTime(2024, 1, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4810), "Respuesta 4", "Alta", "Aceptación", "Usuario4" },
                    { new Guid("7ad552af-7c8c-4972-b0a5-d9366d1f9e5c"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2023, 9, 29, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4823), new DateTime(2024, 6, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4824), "Respuesta 9", "Alta", "Aceptación", "Usuario9" },
                    { new Guid("8e54b8cf-5eac-4eb9-abd2-62963813134f"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2023, 9, 25, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4814), new DateTime(2024, 2, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4815), "Respuesta 5", "Media", "Rechazo", "Usuario5" },
                    { new Guid("a9649f23-138d-4d0c-8fda-206d65649f80"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2023, 9, 26, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4817), new DateTime(2024, 3, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4817), "Respuesta 6", "Alta", "Aceptación", "Usuario6" },
                    { new Guid("b3f250c8-879e-450a-a9a9-07acefaf2061"), new TimeSpan(60, 0, 0, 0, 0), "Pendiente", new DateTime(2023, 9, 23, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4807), new DateTime(2023, 12, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4807), "Respuesta 3", "Baja", "Pendiente", "Usuario3" },
                    { new Guid("e2352c07-e3dc-4281-a838-5a0f85665665"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2023, 9, 22, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4804), new DateTime(2023, 11, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4805), "Respuesta 2", "Media", "Rechazo", "Usuario2" },
                    { new Guid("fa382fda-72d2-4535-a4cb-601edc746f3f"), new TimeSpan(60, 0, 0, 0, 0), "Pendiente", new DateTime(2023, 9, 28, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4821), new DateTime(2024, 5, 20, 8, 17, 42, 629, DateTimeKind.Local).AddTicks(4822), "Respuesta 8", "Baja", "Pendiente", "Usuario8" }
                });

            migrationBuilder.InsertData(
                table: "TelefonoAcudiente",
                columns: new[] { "TelefonoAcudienteId", "AcudienteId", "Indicativo", "Numero", "Tipo" },
                values: new object[,]
                {
                    { new Guid("13361dd0-a3f7-4e52-8960-f2f00fb92a8b"), 4, "+1", -5753, "Móvil" },
                    { new Guid("13453053-b0c7-436f-b221-4b175479ffd9"), 1, "+1", -4135, "Móvil" },
                    { new Guid("6fffc71f-9585-4b66-bf95-9f1c73f7ec1f"), 1, "+1", -667, "Móvil" },
                    { new Guid("7414aac1-315e-41da-90ba-38991e2fe2ec"), 3, "+1", -3111, "Fijo" },
                    { new Guid("7d5d6684-874b-4c6e-9432-2dba46b0d20f"), 2, "+1", -6975, "Móvil" },
                    { new Guid("c7b42eaa-495e-47d2-acb0-432f6ee35c77"), 3, "+1", -5357, "Fijo" },
                    { new Guid("cf3b5908-f49d-405a-9b92-9b7997efc9e1"), 5, "+1", 911, "Emergencia" },
                    { new Guid("cfd5968b-0ee4-432a-8b88-3aca5d5d4418"), 4, "+1", -4333, "Móvil" },
                    { new Guid("e3299505-bfdd-42c9-ab3a-3b2793d56a11"), 5, "+1", -5555, "Emergencia" },
                    { new Guid("e3d9a977-8741-4e20-83d0-f2e571950544"), 2, "+1", -1889, "Móvil" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acudiente");

            migrationBuilder.DropTable(
                name: "Aulas");

            migrationBuilder.DropTable(
                name: "CandidatoEstudiantes");

            migrationBuilder.DropTable(
                name: "Cupo");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "DireccionAcudiente");

            migrationBuilder.DropTable(
                name: "EstudianteDocumentos");

            migrationBuilder.DropTable(
                name: "Horarios");

            migrationBuilder.DropTable(
                name: "Materias");

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

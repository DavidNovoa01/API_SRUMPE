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
                name: "Asistencia",
                columns: table => new
                {
                    AsistenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreAsistente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaHoraAsistencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoEvento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UbicacionEvento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Asistio = table.Column<bool>(type: "bit", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistencia", x => x.AsistenciaId);
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
                name: "Estadisticas",
                columns: table => new
                {
                    EstadisticaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Materia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotaPromedio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NotaMaxima = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NotaMinima = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CantidadExamenes = table.Column<int>(type: "int", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AñoEscolar = table.Column<int>(type: "int", nullable: false),
                    PeriodoEscolar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadisticas", x => x.EstadisticaId);
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
                    { new Guid("5444a831-c368-444c-a00d-95376feae577"), "Gómez", "laura.gomez@email.com", true, "Divorciada", new DateTime(1992, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(3741), "Femenino", "Laura", 86420, "Médica", "Madre" },
                    { new Guid("670b49f3-92cd-4b50-90c8-9b6243237ac3"), "Hernández", "andres.hernandez@email.com", true, "Casado", new DateTime(1979, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(3743), "Masculino", "Andrés", 97531, "Arquitecto", "Padrino" },
                    { new Guid("6bc1af02-7773-4b20-bc8c-61af3df6fa7e"), "Martínez", "pedro.martinez@email.com", true, "Casado", new DateTime(1988, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(3733), "Masculino", "Pedro", 98765, "Profesor", "Padre" },
                    { new Guid("85905472-82b2-4b60-98b7-8d0861ac89f9"), "Luna", "roberto.luna@email.com", true, "Viudo", new DateTime(1970, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(3747), "Masculino", "Roberto", 10293, "Jubilado", "Abuelo" },
                    { new Guid("8ea0367a-b1af-4ceb-8ed6-f858cedbb0b9"), "González", "juan.gonzalez@email.com", true, "Soltero", new DateTime(1975, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(3728), "Masculino", "Juan", 67890, "Abogado", "Padre" },
                    { new Guid("9857d5a1-398c-4cef-8c41-c9a2d4f4c4d6"), "López", "ana.lopez@email.com", true, "Divorciada", new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(3731), "Femenino", "Ana", 54321, "Médica", "Tutor Legal" },
                    { new Guid("9dbc9d53-1ae0-40a5-a115-7eb348b0c608"), "Rodríguez", "carlos.rodriguez@email.com", true, "Soltero", new DateTime(1985, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(3737), "Masculino", "Carlos", 24680, "Ingeniero Civil", "Tío" },
                    { new Guid("b2b91ee7-bb52-4c7b-9da0-8c92d3b707e9"), "Sánchez", "luis.sanchez@email.com", true, "Casado", new DateTime(1972, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(3735), "Masculino", "Luis", 13579, "Contador", "Padre" },
                    { new Guid("c1d18c1c-7206-4c64-8697-95eaa774481b"), "Díaz", "sofia.diaz@email.com", true, "Soltera", new DateTime(1987, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(3745), "Femenino", "Sofía", 75319, "Profesora", "Tía" },
                    { new Guid("e5d768d1-095f-4dee-874b-e6acc40095c6"), "Pérez", "maria.perez@email.com", true, "Casada", new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(3725), "Femenino", "María", 12345, "Ingeniera", "Madre" }
                });

            migrationBuilder.InsertData(
                table: "Asistencia",
                columns: new[] { "AsistenciaId", "Asistio", "FechaHoraAsistencia", "NombreAsistente", "Notas", "TipoEvento", "UbicacionEvento" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 10, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), "Juan Pérez", "Asistió puntualmente.", "Conferencia", "Salón A" },
                    { 2, false, new DateTime(2023, 10, 4, 15, 30, 0, 0, DateTimeKind.Unspecified), "María Rodríguez", "No pudo asistir debido a un compromiso previo.", "Reunión", "Sala de juntas" },
                    { 3, true, new DateTime(2023, 10, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), "Carlos González", "Participó activamente en el taller.", "Taller", "Aula 101" },
                    { 4, true, new DateTime(2023, 10, 6, 10, 30, 0, 0, DateTimeKind.Unspecified), "Ana López", "Tomó notas detalladas durante la conferencia.", "Conferencia", "Salón B" },
                    { 5, true, new DateTime(2023, 10, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), "Pedro Ramírez", "Participó en la discusión de temas importantes.", "Reunión", "Sala de conferencias" },
                    { 6, true, new DateTime(2023, 10, 8, 11, 45, 0, 0, DateTimeKind.Unspecified), "Laura Martínez", "Hizo preguntas interesantes durante el seminario.", "Seminario", "Auditorio" }
                });

            migrationBuilder.InsertData(
                table: "Aulas",
                columns: new[] { "AulaId", "Capacidad", "EstadoAula", "HorarioDisponibilidad", "NombreNumero", "NotasAdicionales", "RegistrosIncidentesProblemas", "ResponsableAula", "TipoAula", "Ubicacion", "UltimaActualizacion" },
                values: new object[,]
                {
                    { new Guid("0d6c1b20-6a8e-4380-8419-e0a9db27ce34"), 50, "Disponible", "Lunes a Viernes, 08:00 AM - 06:00 PM", "Aula 101", "Equipada con proyector", "Ninguno", "Profesor Responsable 1", "Salón de Clases", "Edificio Principal", new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b124a6d-2170-43af-aab8-58cd5d7eb683"), 10, "Disponible", "Lunes a Domingo, 09:00 AM - 11:00 PM", "Aula 105", "Área de estudio tranquila", "Ninguno", "Bibliotecario", "Sala de Estudio", "Biblioteca", new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5c345d47-315f-4ebb-844e-705acc0b948c"), 30, "Ocupado", "Lunes a Viernes, 10:00 AM - 05:00 PM", "Aula 102", "Equipado con computadoras de última generación", "Reporte de fallo en una computadora", "Profesor Responsable 2", "Laboratorio de Informática", "Edificio de Ciencias", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("742238e9-33d5-4502-9528-1c556672f798"), 100, "Disponible", "Disponible previa reserva", "Aula 103", "Equipada con proyector y sistema de sonido", "Ninguno", "Personal de Eventos", "Sala de Conferencias", "Edificio de Eventos", new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b087f36c-bd8f-4032-9323-65000b54888c"), 40, "En Mantenimiento", "No disponible temporalmente", "Aula 104", "Mantenimiento programado", "Reporte de fugas de agua en el techo", "Personal de Mantenimiento", "Salón de Clases", "Edificio Principal", new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CandidatoEstudiantes",
                columns: new[] { "CandidatoEstudianteId", "Apellido", "FechaNacimiento", "Nombre", "TipoPersona" },
                values: new object[,]
                {
                    { new Guid("21bfab7b-ec9e-4706-ae29-7fe27b75e0ba"), "Hernández", new DateTime(1994, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sofía", "Estudiante" },
                    { new Guid("511a3aff-e375-4340-8b56-39b4c5c9441c"), "Fernández", new DateTime(1989, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roberto", "Estudiante" },
                    { new Guid("5388abae-3ad5-433c-89c4-40315c83aad2"), "Díaz", new DateTime(1991, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Francisco", "Estudiante" },
                    { new Guid("6e0464cd-4c86-43a1-91fb-aab9d93ba449"), "Acuña", new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Axl", "Estudiante" },
                    { new Guid("7a02901d-e7ee-4587-b2ce-0c7499647297"), "Sánchez", new DateTime(1987, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos", "Estudiante" },
                    { new Guid("aa178fa6-9e8c-4343-a4fd-3cfb0d541164"), "Castro", new DateTime(1990, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan", "Estudiante" },
                    { new Guid("b28eee30-363b-4bb8-a71e-32f27bb76ddb"), "Ramírez", new DateTime(1998, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pedro", "Estudiante" },
                    { new Guid("d4cfebf6-1d98-4e31-80f4-90296573bc8c"), "Gómez", new DateTime(1996, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isabel", "Estudiante" },
                    { new Guid("e8605813-966f-4a3d-ac65-b1f0051a75e0"), "López", new DateTime(2000, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura", "Estudiante" },
                    { new Guid("ffa64eae-0e58-4639-b225-357844ddfcbe"), "Martínez", new DateTime(1993, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana", "Estudiante" }
                });

            migrationBuilder.InsertData(
                table: "Cupo",
                columns: new[] { "CupoId", "CantidadDisponible", "Descripcion", "Duracion", "Estado", "FechaFin", "FechaInicio", "Ubicacion" },
                values: new object[,]
                {
                    { new Guid("157a7355-6694-4bfa-9af7-9d0c6478c196"), 30, "Cupo para el evento de networking", new TimeSpan(0, 1, 0, 0, 0), true, new DateTime(2024, 3, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4409), new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4409), "Aula 104" },
                    { new Guid("6c0ad561-1296-45f5-9535-00272b4e700b"), 20, "Cupo para el seminario de marketing", new TimeSpan(0, 4, 0, 0, 0), true, new DateTime(2024, 1, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4403), new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4403), "Aula 102" },
                    { new Guid("81dd02c5-4ed4-42c0-95b5-476188e3f9c1"), 5, "Cupo para el taller de programación", new TimeSpan(0, 3, 0, 0, 0), true, new DateTime(2023, 12, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4400), new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4400), "Aula 101" },
                    { new Guid("8d3267a9-3dd6-4030-b8d7-48fd5987045c"), 10, "Cupo para el evento principal", new TimeSpan(0, 2, 0, 0, 0), true, new DateTime(2023, 11, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4388), new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4387), "Salón principal" },
                    { new Guid("feaa0948-fdb0-44a7-913a-294c6efe9a5d"), 15, "Cupo para el curso de diseño gráfico", new TimeSpan(0, 2, 0, 0, 0), true, new DateTime(2024, 2, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4407), new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4407), "Aula 103" }
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "CursoId", "AulasAsignadas", "Codigo", "DepartamentoAcademico", "Descripcion", "FechaLimiteInscripcion", "MetodosEnsenanza", "Nivel", "ProfesorAsignado" },
                values: new object[,]
                {
                    { new Guid("15bf4971-90d6-4ed6-95fa-f9d1da9b6f2e"), "History Classroom 101", "HIST101", "History Department", "Introduction to History", new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lectures, discussions, research papers", "First Semester", "Professor 5" },
                    { new Guid("354d434d-b2be-484b-a891-52ea0c9349f3"), "Chemistry Lab 201", "CHEM201", "Chemistry Department", "Organic Chemistry", new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lectures, laboratory experiments", "Second Semester", "Professor 4" },
                    { new Guid("55c47303-fa58-496a-8b4d-d8dc40866962"), "Math Classroom 301", "MATH301", "Mathematics Department", "Advanced Calculus", new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lectures, problem sets, exams", "Third Semester", "Professor 3" },
                    { new Guid("c8d736ad-cd57-40c2-a02d-58f399392330"), "Classroom 201, Classroom 202", "ENG201", "English Department", "Advanced English Composition", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lectures, writing assignments, group discussions", "Second Semester", "Professor 2" },
                    { new Guid("e1c305d1-4afe-480c-9eac-318bfaf14d06"), "Aula 101, Aula 102", "CS101", "Ciencias de la Computación", "Introducción a la Programación", new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clases magistrales, laboratorios prácticos", "Primer Semestre", "Profesor 1" }
                });

            migrationBuilder.InsertData(
                table: "DireccionAcudiente",
                columns: new[] { "DireccionAcudienteId", "Calle", "CiudadLocalidad", "CodigoPostal", "ColoniaBarrio", "EstadoProvincia", "Pais" },
                values: new object[,]
                {
                    { new Guid("0752a2b1-87bd-43a3-8935-23aab6b46e6c"), "Carrera 10", "Bogotá", "110321", "La Candelaria", "Bogotá D.C.", "Colombia" },
                    { new Guid("21a55e75-ef27-4bee-a5be-55611f8d88fe"), "Avenida Boyacá", "Bogotá", "110511", "Fontibón", "Bogotá D.C.", "Colombia" },
                    { new Guid("4ddf8a43-3ae6-49fc-a08f-3a8161cb453b"), "Carrera 7", "Bogotá", "110171", "Usaquén", "Bogotá D.C.", "Colombia" },
                    { new Guid("6fb91c38-be05-4767-8996-a0498eb45f93"), "Calle 72", "Bogotá", "110231", "Chapinero", "Bogotá D.C.", "Colombia" },
                    { new Guid("a0ee0ef7-4c11-43b3-8734-f22fd8214dd2"), "Calle 72", "Bogotá", "110231", "Chapinero", "Bogotá D.C.", "Colombia" },
                    { new Guid("b0bce11d-da14-4f97-89b9-66617a66bd44"), "Avenida 68", "Bogotá", "110841", "Kennedy", "Bogotá D.C.", "Colombia" },
                    { new Guid("c0a7c644-4130-498f-8fc4-0fcf82ac1950"), "Calle 80", "Bogotá", "110841", "Engativá", "Bogotá D.C.", "Colombia" }
                });

            migrationBuilder.InsertData(
                table: "Estadisticas",
                columns: new[] { "EstadisticaId", "AñoEscolar", "CantidadExamenes", "FechaRegistro", "Materia", "NotaMaxima", "NotaMinima", "NotaPromedio", "PeriodoEscolar" },
                values: new object[,]
                {
                    { 1, 2023, 5, new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(6417), "Matemáticas", 9.0m, 7.5m, 8.5m, "Primer Trimestre" },
                    { 2, 2023, 4, new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(6421), "Ciencias", 8.5m, 6.5m, 7.8m, "Segundo Trimestre" },
                    { 3, 2023, 3, new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(6422), "Historia", 9.5m, 8.5m, 9.2m, "Tercer Trimestre" },
                    { 4, 2023, 5, new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(6425), "Lenguaje", 8.0m, 6.0m, 7.2m, "Primer Semestre" },
                    { 5, 2023, 2, new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(6426), "Arte", 9.0m, 8.0m, 8.7m, "Segundo Semestre" },
                    { 6, 2023, 3, new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(6428), "Educación Física", 10.0m, 9.0m, 9.5m, "Trimestre Extra" }
                });

            migrationBuilder.InsertData(
                table: "EstudianteDocumentos",
                columns: new[] { "EstudianteDocumentosId", "CandidatoEstudianteId", "Estado", "FechaActualizacion", "NombreDocumento", "NumeroDocumento", "Observaciones", "Tamaño", "TipoDocumento", "Ubicacion" },
                values: new object[,]
                {
                    { new Guid("10a5e754-1570-4be0-8650-2c53d7cfb4d3"), new Guid("b3b5a5a7-5b82-4f76-98c1-654589db8f61"), true, new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(3518), "Fotografía del Estudiante", 1111111, "Foto de perfil", 1024, "Identificación", "ruta/al/documento10" },
                    { new Guid("2d54a999-187f-4a8c-99db-d17841e7938c"), new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), true, new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(3487), "Diploma", 987654, "Logros académicos", 2048, "Educativo", "ruta/al/documento2" },
                    { new Guid("3e68515e-3a47-4a62-a8c7-9f12242d020e"), new Guid("4f3657e5-5824-47b8-b4cd-6f49a3f4dbf1"), false, new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(3500), "Certificado de Graduación", 123456, "Graduación universitaria", 1536, "Educativo", "ruta/al/documento3" },
                    { new Guid("4a303cce-8c0e-4ae7-89c1-067d0b7741b6"), new Guid("3e68515e-3a47-4a62-a8c7-9f12242d020e"), true, new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(3503), "Certificado de Matrícula", 789012, "Matrícula escolar", 8192, "Educativo", "ruta/al/documento4" },
                    { new Guid("5f78d0e1-579e-4dfc-82a1-92010b4191d3"), new Guid("31eb541a-9419-4eac-bf1b-0289a6c6f6f0"), true, new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(3506), "Cédula de Identidad", 555555, "Documento oficial", 4096, "Identificación", "ruta/al/documento5" },
                    { new Guid("6a30c846-4b9d-4cf5-bb17-051a3e9d1b72"), new Guid("c9d4c053-49b6-410c-bc78-2d54a999187f"), true, null, "Certificado de Nacimiento", 61464465, "Ninguna", 1024, "Identificación", "ruta/al/documento1" },
                    { new Guid("7e15d9a4-98cb-4d14-9a35-862f8c202725"), new Guid("bb9b0679-4f04-4ac4-9ddc-5c3e50e81298"), true, new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(3512), "Boleta de Calificaciones", 9876543, "Registro académico", 5120, "Educativo", "ruta/al/documento7" },
                    { new Guid("8f4a67c2-fd5e-4316-8c50-7249f159d0f1"), new Guid("a6509bea-688e-43b5-a870-6ee461ccf601"), true, new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(3514), "Pasaporte", 1234567, "Documento de viaje", 4096, "Identificación", "ruta/al/documento8" },
                    { new Guid("9b9d6d8f-72f0-4f0a-8e18-1e75b0182e3f"), new Guid("db9fcac5-8654-45c3-87c7-8b5e13e9e6c2"), true, new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(3516), "Certificado Médico", 543210, "Informe médico", 2048, "Salud", "ruta/al/documento9" },
                    { new Guid("f38f6b1a-86e9-4d9d-8a7a-62f17e6f1ba2"), new Guid("7f255218-f8e0-45a9-9807-12e1bcfd438c"), true, new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(3509), "Carné de Estudiante", 7890123, "Carné escolar", 3072, "Identificación", "ruta/al/documento6" }
                });

            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "HorarioId", "DiaSemana", "DuracionClaseMinutos", "EstadoHorario", "FechaFinClases", "FechaInicioClases", "GrupoSeccion", "HoraFin", "HoraInicio", "NotificacionCambioHorario", "PeriodoAcademico", "ProfesorAsistente", "SalaAula" },
                values: new object[,]
                {
                    { new Guid("0559084f-a0b5-42a9-9795-7107d57c3a21"), "Martes", 120, "Activo", new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupo B", new TimeSpan(0, 16, 0, 0, 0), new TimeSpan(0, 14, 0, 0, 0), "Sí", "Semestre de Primavera", "Profesor Asistente 2", "Aula 203" },
                    { new Guid("15af04cc-7180-4ab9-a2f3-5c9dbe9ca920"), "Viernes", 120, "Activo", new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupo E", new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), "No", "Semestre de Primavera", "Profesor Asistente 5", "Aula 102" },
                    { new Guid("52e77762-81c1-47aa-ac76-f99b2e6c3894"), "Jueves", 120, "Activo", new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupo D", new TimeSpan(0, 18, 30, 0, 0), new TimeSpan(0, 16, 30, 0, 0), "Sí", "Semestre de Invierno", "Profesor Asistente 4", "Aula 401" },
                    { new Guid("cf435652-1c86-44f2-ad18-a27a6e25e383"), "Miércoles", 120, "Activo", new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupo C", new TimeSpan(0, 13, 30, 0, 0), new TimeSpan(0, 11, 30, 0, 0), "No", "Semestre de Verano", "Profesor Asistente 3", "Aula 305" },
                    { new Guid("d1679085-709a-49d5-b38b-efb726497ff5"), "Lunes", 120, "Activo", new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupo A", new TimeSpan(0, 11, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), "No", "Semestre de Otoño", "Profesor Asistente 1", "Aula 101" }
                });

            migrationBuilder.InsertData(
                table: "Materias",
                columns: new[] { "MateriaId", "DepartamentoAcademico", "Descripcion", "Estado", "GrupoSeccionMateria", "MetodosEnsenanza", "ModalidadEnsenanza", "Nivel", "Nombre", "NotasAdicionales", "ProfesorAsignado" },
                values: new object[,]
                {
                    { new Guid("330054f0-d1da-4ea2-9538-35a5d944525f"), "Departamento de Arte", "Curso de Arte Contemporáneo", "Inscripciones abiertas", "Grupo G", "Prácticas artísticas y exposiciones", "Presencial", "Intermedio", "Arte", "No se requiere experiencia previa en arte.", "Profesor de Arte" },
                    { new Guid("a3ab3e46-d1a5-4133-942f-cecdb6bd045f"), "Departamento de Informática", "Curso de Ciencias de la Computación", "En progreso", "Grupo C", "Clases virtuales y proyectos prácticos", "En línea", "Avanzado", "Ciencias de la Computación", "Requiere acceso a una computadora.", "Profesor de Informática" },
                    { new Guid("a88d0112-f1ac-40ca-9c93-44e9c3aebfd2"), "Departamento de Matemáticas", "Curso de Matemáticas Avanzadas", "En progreso", "Grupo A", "Clases teóricas y prácticas", "Presencial", "Avanzado", "Matemáticas", "Se requiere calculadora científica.", "Profesor Matemático" },
                    { new Guid("d014dff9-ac13-44ec-a65c-73970a00de12"), "Departamento de Economía", "Curso de Economía Moderna", "En progreso", "Grupo F", "Clases virtuales y análisis económico", "En línea", "Intermedio", "Economía", "Abordaremos temas financieros actuales.", "Profesor Economista" },
                    { new Guid("d5ebc561-e015-4f51-bba1-2bee977d142e"), "Departamento de Historia", "Curso de Historia Mundial", "Inscripciones abiertas", "Grupo B", "Conferencias y debates", "Presencial", "Intermedio", "Historia", "Recomendado para estudiantes de Historia.", "Profesor Historiador" },
                    { new Guid("ea3d2dbd-6f5a-49cb-8af3-ef8092f08f5a"), "Departamento de Literatura", "Curso de Literatura Universal", "Inscripciones abiertas", "Grupo D", "Lecturas y discusiones literarias", "Presencial", "Intermedio", "Literatura", "Apto para amantes de la lectura.", "Profesor Literario" },
                    { new Guid("f656069e-d3c0-4d64-b160-800f5d38bcdc"), "Departamento de Física", "Curso de Física Avanzada", "Completo", "Grupo E", "Experimentos y clases teóricas", "Presencial", "Avanzado", "Física", "Requiere conocimientos previos de física.", "Profesor de Física" }
                });

            migrationBuilder.InsertData(
                table: "Matricula",
                columns: new[] { "MatriculaId", "CategoriaMatricula", "Comentarios", "EstadoMatricula", "FechaMatricula", "InformacionPlanEstudios", "PeriodoAcademico", "RegistroCambios", "TipoMatricula" },
                values: new object[,]
                {
                    { new Guid("1f05c8f3-ff1f-401a-8f59-943ce466af10"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 1", "Activa", new DateTime(2023, 10, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(5019), "Plan de estudios 2023", 2023, "Registro de cambios 1", "Matrícula Regular" },
                    { new Guid("6dd49244-7f2c-4061-9017-78eecc43d576"), "Estudiante Internacional", "Comentario sobre la matrícula 3", "Cancelada", new DateTime(2023, 12, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(5026), "Plan de estudios 2023", 2023, "Registro de cambios 3", "Matrícula Regular" },
                    { new Guid("81c36e55-be49-4269-8a01-25566e6752cc"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 5", "Activa", new DateTime(2024, 2, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(5031), "Plan de estudios 2023", 2023, "Registro de cambios 5", "Matrícula Regular" },
                    { new Guid("9342a551-e09a-438c-bbb1-5e4c820bdea0"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 4", "Activa", new DateTime(2024, 1, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(5028), "Plan de estudios 2023", 2023, "Registro de cambios 4", "Matrícula Regular" },
                    { new Guid("e8536113-87eb-4d14-bee2-baad66626ce4"), "Estudiante de Tiempo Parcial", "Comentario sobre la matrícula 2", "Pendiente", new DateTime(2023, 11, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(5023), "Plan de estudios 2023", 2023, "Registro de cambios 2", "Matrícula Parcial" }
                });

            migrationBuilder.InsertData(
                table: "PreMatricula",
                columns: new[] { "PreMatriculaId", "EstadoPreMatricula", "GradoONivel", "Observaciones", "RequisitosDocumentacion", "Turno" },
                values: new object[,]
                {
                    { new Guid("6fa3cf77-5ddb-48d1-a36f-de6bc10df9d2"), "Pendiente", "Tercero de Primaria", "Estudiante extranjero.", "SiCumplio", "Mañana" },
                    { new Guid("849b84be-a78a-49d9-b2ff-dff7a996c4c2"), "Activa", "Séptimo de Secundaria", "Estudiante de transferencia.", "SiCumplio", "Tarde" },
                    { new Guid("9c69c7a4-4119-46af-9625-442d80275d62"), "Pendiente", "Quinto de Primaria", "Estudiante con requerimientos especiales.", "NoCumplio", "Mañana" },
                    { new Guid("bd4bcec5-e4b6-498a-8abb-bd3fea026847"), "Activa", "Segundo de Primaria", "Estudiante con discapacidad visual.", "SiCumplio", "Mañana" },
                    { new Guid("c96d61a7-5793-4c03-ac45-fd4a6017a209"), "Pendiente", "Octavo de Secundaria", "Estudiante sin observaciones adicionales.", "Si cumplio", "Tarde" },
                    { new Guid("f16c893f-6883-4bb0-812c-6b2bc52fb811"), "Activa", "Cuarto de Secundaria", "Estudiante con beca deportiva.", "SiCumplio", "Tarde" }
                });

            migrationBuilder.InsertData(
                table: "RespuestaCupo",
                columns: new[] { "RespuestaCupoId", "DuracionRespuesta", "EstadoRespuesta", "FechaRespuesta", "FechaVencimiento", "MensajeRespuesta", "Prioridad", "TipoRespuesta", "UsuarioRespuesta" },
                values: new object[,]
                {
                    { new Guid("23a24daa-c0cd-48c0-aeb4-0e7255a791ae"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2023, 10, 4, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4604), new DateTime(2023, 11, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4609), "Respuesta 1", "Alta", "Aceptación", "Usuario1" },
                    { new Guid("5cf91016-1ecc-4dc3-a1d4-15818ce6d6b7"), new TimeSpan(60, 0, 0, 0, 0), "Pendiente", new DateTime(2023, 10, 6, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4619), new DateTime(2024, 1, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4620), "Respuesta 3", "Baja", "Pendiente", "Usuario3" },
                    { new Guid("6608af56-9427-4619-9b53-c82bb458349c"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2023, 10, 5, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4617), new DateTime(2023, 12, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4617), "Respuesta 2", "Media", "Rechazo", "Usuario2" },
                    { new Guid("66eb2827-548a-42ca-acc8-bd284ed76036"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2023, 10, 12, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4635), new DateTime(2024, 7, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4636), "Respuesta 9", "Alta", "Aceptación", "Usuario9" },
                    { new Guid("71858ef0-8c88-45fc-bddb-92f098e40fc4"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2023, 10, 9, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4627), new DateTime(2024, 4, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4627), "Respuesta 6", "Alta", "Aceptación", "Usuario6" },
                    { new Guid("8134c661-4700-4b27-bcfd-d4285658f74b"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2023, 10, 8, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4624), new DateTime(2024, 3, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4625), "Respuesta 5", "Media", "Rechazo", "Usuario5" },
                    { new Guid("8e78c095-1475-4ef3-9c79-50c599564ab1"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2023, 10, 7, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4622), new DateTime(2024, 2, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4622), "Respuesta 4", "Alta", "Aceptación", "Usuario4" },
                    { new Guid("9eac1b0f-5ef3-4723-a545-400f8ce6258f"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2023, 10, 10, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4631), new DateTime(2024, 5, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4631), "Respuesta 7", "Media", "Rechazo", "Usuario7" },
                    { new Guid("f9c0519a-c2d1-4b59-9f2e-d0db5294524d"), new TimeSpan(60, 0, 0, 0, 0), "Pendiente", new DateTime(2023, 10, 11, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4633), new DateTime(2024, 6, 3, 21, 55, 47, 409, DateTimeKind.Local).AddTicks(4634), "Respuesta 8", "Baja", "Pendiente", "Usuario8" }
                });

            migrationBuilder.InsertData(
                table: "TelefonoAcudiente",
                columns: new[] { "TelefonoAcudienteId", "AcudienteId", "Indicativo", "Numero", "Tipo" },
                values: new object[,]
                {
                    { new Guid("00ab4a5c-7afe-4078-a65f-882aece76fa6"), 2, "+1", -1889, "Móvil" },
                    { new Guid("4163e23d-7f0a-4518-bc6a-9050d3d7dba9"), 4, "+1", -4333, "Móvil" },
                    { new Guid("8753de56-d120-43fb-a029-54b3623dbb45"), 1, "+1", -4135, "Móvil" },
                    { new Guid("9479a994-fcbd-4a36-a8f0-a846252b95e2"), 5, "+1", -5555, "Emergencia" },
                    { new Guid("97c5d6ee-bb68-4c8e-95ca-6f1d0720637e"), 5, "+1", 911, "Emergencia" },
                    { new Guid("a61b2473-b7e9-40f7-8c68-3af90fd20142"), 2, "+1", -6975, "Móvil" },
                    { new Guid("b29903f9-c17a-40da-a65d-d118f98178d5"), 3, "+1", -5357, "Fijo" },
                    { new Guid("b763315c-7030-46e5-9ea5-0b7955add187"), 1, "+1", -667, "Móvil" },
                    { new Guid("ba87b87e-4977-499c-a5c9-61daa8eb3aaa"), 3, "+1", -3111, "Fijo" },
                    { new Guid("f4292eba-ffa5-4cf8-8b71-e10c47c737e8"), 4, "+1", -5753, "Móvil" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acudiente");

            migrationBuilder.DropTable(
                name: "Asistencia");

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
                name: "Estadisticas");

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

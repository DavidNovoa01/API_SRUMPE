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
                    Edad = table.Column<int>(type: "int", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelacionConEstudiante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoCivil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ocupacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TipoPersona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroDocumento = table.Column<long>(type: "bigint", nullable: false),
                    NumeroContacto = table.Column<long>(type: "bigint", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdjuntarDocumentos = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "Docentes",
                columns: table => new
                {
                    DocenteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaContratacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CursosAsignados = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HorarioClases = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoLaboral = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroIdentificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComentariosNotas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NivelExperiencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fotografia = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docentes", x => x.DocenteId);
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
                    Tamaño = table.Column<int>(type: "int", nullable: false)
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
                name: "Notas",
                columns: table => new
                {
                    NotaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Materia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Periodo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.NotaId);
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
                columns: new[] { "AcudienteId", "Apellidos", "CorreoElectronico", "Edad", "EstadoCivil", "FechaRegistro", "Nombres", "NumeroIdentificacion", "Ocupacion", "RelacionConEstudiante" },
                values: new object[,]
                {
                    { new Guid("66670767-6c77-4e56-9ed6-d90c7c248de0"), "Díaz", "sofia.diaz@email.com", 12, "Soltera", new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1226), "Sofía", 75319, "Profesora", "Tía" },
                    { new Guid("93c6f6d2-d727-4c9a-8894-d9695729658b"), "Pérez", "maria.perez@email.com", 12, "Casada", new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1217), "María", 12345, "Ingeniera", "Madre" },
                    { new Guid("9fb303c7-f7ff-48cb-af6c-0d68530571c4"), "Martínez", "pedro.martinez@email.com", 12, "Casado", new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1224), "Pedro", 98765, "Profesor", "Padre" },
                    { new Guid("b1e62c6d-4c84-47d3-a8e5-40bae93a30fa"), "López", "ana.lopez@email.com", 12, "Divorciada", new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1222), "Ana", 54321, "Médica", "Tutor Legal" },
                    { new Guid("da44297c-a8dc-4ae4-8291-e9ec6130bea8"), "González", "juan.gonzalez@email.com", 12, "Soltero", new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1220), "Juan", 67890, "Abogado", "Padre" },
                    { new Guid("e9a14465-c076-4099-b05d-75b967a0b66b"), "Luna", "roberto.luna@email.com", 12, "Viudo", new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1228), "Roberto", 10293, "Jubilado", "Abuelo" }
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
                    { new Guid("15a11ed9-7fdf-47c8-ba3d-85a9a995d56e"), 10, "Disponible", "Lunes a Domingo, 09:00 AM - 11:00 PM", "Aula 105", "Área de estudio tranquila", "Ninguno", "Bibliotecario", "Sala de Estudio", "Biblioteca", new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1deeb9fb-c429-40f4-a7c3-c6c7c0a5fc91"), 50, "Disponible", "Lunes a Viernes, 08:00 AM - 06:00 PM", "Aula 101", "Equipada con proyector", "Ninguno", "Profesor Responsable 1", "Salón de Clases", "Edificio Principal", new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7450dd19-8be4-4146-be27-a9839ba95fff"), 40, "En Mantenimiento", "No disponible temporalmente", "Aula 104", "Mantenimiento programado", "Reporte de fugas de agua en el techo", "Personal de Mantenimiento", "Salón de Clases", "Edificio Principal", new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("900fef67-1b98-4657-bf8c-7abb9a69c44a"), 100, "Disponible", "Disponible previa reserva", "Aula 103", "Equipada con proyector y sistema de sonido", "Ninguno", "Personal de Eventos", "Sala de Conferencias", "Edificio de Eventos", new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c070d47f-d957-46e2-b767-d75998a6284e"), 30, "Ocupado", "Lunes a Viernes, 10:00 AM - 05:00 PM", "Aula 102", "Equipado con computadoras de última generación", "Reporte de fallo en una computadora", "Profesor Responsable 2", "Laboratorio de Informática", "Edificio de Ciencias", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CandidatoEstudiantes",
                columns: new[] { "CandidatoEstudianteId", "AdjuntarDocumentos", "Apellido", "Direccion", "FechaNacimiento", "Genero", "Nombre", "NumeroContacto", "NumeroDocumento", "TipoDocumento", "TipoPersona" },
                values: new object[,]
                {
                    { new Guid("1e2dbaaa-1c28-414a-be7b-1a4a08cfe4be"), "Si", "Doe", "123 Main Street", null, "Masculino", "John", 987654321L, 123456789L, "cedula", "Persona" },
                    { new Guid("21170829-6fbf-4f18-97be-f876a9d9d90c"), "Si", "Smith", "456 Oak Avenue", new DateTime(1985, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Jane", 123456789L, 987654321L, "Cedula", "Persona" },
                    { new Guid("618f076c-217a-4171-a1a0-caaa39296bdd"), "Si", "Johnson", "789 Pine Road", new DateTime(1995, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "No binario", "Bob", 555555555L, 456789012L, "Tarjeta de Identidad", "Persona" },
                    { new Guid("986b2a85-eaf6-4fea-8493-68c139c891c0"), "No", "Williams", "101 Cedar Lane", new DateTime(1980, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Alice", 444555666L, 333222111L, "Tarjeta de Identidad", "Persona" },
                    { new Guid("e72f9956-3be4-4257-af90-1c3a3a74cf5d"), "Si", "Brown", "202 Elm Street", new DateTime(1992, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Charlie", 111222333L, 999888777L, "Tarjeta de Identidad", "Persona" }
                });

            migrationBuilder.InsertData(
                table: "Cupo",
                columns: new[] { "CupoId", "CantidadDisponible", "Descripcion", "Duracion", "Estado", "FechaFin", "FechaInicio", "Ubicacion" },
                values: new object[,]
                {
                    { new Guid("07e8adb3-7859-4d5d-b383-567a929dd3aa"), 20, "Cupo para el seminario de marketing", new TimeSpan(0, 4, 0, 0, 0), true, new DateTime(2024, 5, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1932), new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1931), "Aula 102" },
                    { new Guid("54876fe7-f2df-4df5-816a-ee290afdea92"), 10, "Cupo para el evento principal", new TimeSpan(0, 2, 0, 0, 0), true, new DateTime(2024, 3, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1915), new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1913), "Salón principal" },
                    { new Guid("a99f1ceb-bf01-4fb3-a709-9ece71f781f0"), 30, "Cupo para el evento de networking", new TimeSpan(0, 1, 0, 0, 0), true, new DateTime(2024, 7, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1937), new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1936), "Aula 104" },
                    { new Guid("adbc23bb-95a0-495e-afd0-0ae98561aca7"), 15, "Cupo para el curso de diseño gráfico", new TimeSpan(0, 2, 0, 0, 0), true, new DateTime(2024, 6, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1935), new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1934), "Aula 103" },
                    { new Guid("c33d0a6a-2997-4de4-b60c-d7535af5693e"), 5, "Cupo para el taller de programación", new TimeSpan(0, 3, 0, 0, 0), true, new DateTime(2024, 4, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1929), new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1928), "Aula 101" }
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "CursoId", "AulasAsignadas", "Codigo", "DepartamentoAcademico", "Descripcion", "FechaLimiteInscripcion", "MetodosEnsenanza", "Nivel", "ProfesorAsignado" },
                values: new object[,]
                {
                    { new Guid("138e216d-37e0-4fec-a42d-38fbad3a93c3"), "Aula 101, Aula 102", "CS101", "Ciencias de la Computación", "Introducción a la Programación", new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clases magistrales, laboratorios prácticos", "Primer Semestre", "Profesor 1" },
                    { new Guid("4a005da6-a711-469a-af0e-e0237c5dbf4c"), "Math Classroom 301", "MATH301", "Mathematics Department", "Advanced Calculus", new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lectures, problem sets, exams", "Third Semester", "Professor 3" },
                    { new Guid("4ab3bf8c-8fef-4794-861c-f46aff1924b2"), "Classroom 201, Classroom 202", "ENG201", "English Department", "Advanced English Composition", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lectures, writing assignments, group discussions", "Second Semester", "Professor 2" },
                    { new Guid("88475ece-b027-49e5-9e0b-b1d40ae5c6a2"), "Chemistry Lab 201", "CHEM201", "Chemistry Department", "Organic Chemistry", new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lectures, laboratory experiments", "Second Semester", "Professor 4" },
                    { new Guid("f8415ff5-4744-47cd-9057-d0588166f50d"), "History Classroom 101", "HIST101", "History Department", "Introduction to History", new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lectures, discussions, research papers", "First Semester", "Professor 5" }
                });

            migrationBuilder.InsertData(
                table: "DireccionAcudiente",
                columns: new[] { "DireccionAcudienteId", "Calle", "CiudadLocalidad", "CodigoPostal", "ColoniaBarrio", "EstadoProvincia", "Pais" },
                values: new object[,]
                {
                    { new Guid("17e57665-58d7-4ae0-aa6e-1a5a25fe4e6c"), "Carrera 10", "Bogotá", "110321", "La Candelaria", "Bogotá D.C.", "Colombia" },
                    { new Guid("21f36b90-45c4-4838-b263-a0c54ff56799"), "Calle 80", "Bogotá", "110841", "Engativá", "Bogotá D.C.", "Colombia" },
                    { new Guid("2ce722d0-eff1-4afd-9c54-bed114b8fd11"), "Carrera 7", "Bogotá", "110171", "Usaquén", "Bogotá D.C.", "Colombia" },
                    { new Guid("68c657a3-2b01-4a34-98a8-9ad6034bb397"), "Calle 72", "Bogotá", "110231", "Chapinero", "Bogotá D.C.", "Colombia" },
                    { new Guid("7a2f8b7b-ab3d-4908-9b09-649f65990158"), "Calle 72", "Bogotá", "110231", "Chapinero", "Bogotá D.C.", "Colombia" },
                    { new Guid("80dc1703-53c1-4e5a-bebe-d58c6e04d1e5"), "Avenida Boyacá", "Bogotá", "110511", "Fontibón", "Bogotá D.C.", "Colombia" },
                    { new Guid("ad034359-39bf-413f-bbec-ed30d9af5cfc"), "Avenida 68", "Bogotá", "110841", "Kennedy", "Bogotá D.C.", "Colombia" }
                });

            migrationBuilder.InsertData(
                table: "Docentes",
                columns: new[] { "DocenteId", "ComentariosNotas", "CorreoElectronico", "CursosAsignados", "Direccion", "EstadoLaboral", "FechaContratacion", "FechaNacimiento", "Fotografia", "Genero", "HorarioClases", "NivelExperiencia", "Nombre", "NumeroIdentificacion", "NumeroTelefono" },
                values: new object[,]
                {
                    { new Guid("21c57607-1c0c-406b-a23d-ed008a8abe25"), "Brings real-world experience to the classroom.", "carlos.rodriguez@example.com", "Computer Science, Programming", "789 Pine Lane, Villagetown", "Active", new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Male", "Mon-Wed-Fri: 9 am - 3 pm", "Junior", "Carlos Rodriguez", "D555111222", "+1 (555) 876-5432" },
                    { new Guid("7558ac2a-3209-4ef7-bf40-0ff4b7159810"), "Passionate about her subject and dedicated to student success.", "alice.johnson@example.com", "Literature, History", "456 Oak Avenue, Townsville", "Active", new DateTime(2015, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Female", "Tue-Thu: 10 am - 6 pm", "Intermediate", "Alice Johnson", "D987654321", "+1 (555) 987-6543" },
                    { new Guid("8297b37f-0354-4058-8926-83a8a09f8c4f"), "Excellent teacher with great communication skills.", "john.smith@example.com", "Mathematics, Physics", "123 Main Street, Cityville", "Active", new DateTime(2010, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Male", "Mon-Fri: 8 am - 4 pm", "Senior", "John Smith", "D123456789", "+1 (555) 123-4567" },
                    { new Guid("86ebc564-b3eb-4e2a-86e6-834e81846bd6"), "Encourages critical thinking and curiosity in students.", "emily.white@example.com", "Chemistry, Biology", "234 Elm Street, Hamletville", "Active", new DateTime(2018, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Female", "Thu-Fri: 11 am - 5 pm", "Senior", "Emily White", "D333444555", "+1 (555) 234-5678" }
                });

            migrationBuilder.InsertData(
                table: "Estadisticas",
                columns: new[] { "EstadisticaId", "AñoEscolar", "CantidadExamenes", "FechaRegistro", "Materia", "NotaMaxima", "NotaMinima", "NotaPromedio", "PeriodoEscolar" },
                values: new object[,]
                {
                    { 1, 2023, 5, new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(4020), "Matemáticas", 9.0m, 7.5m, 8.5m, "Primer Trimestre" },
                    { 2, 2023, 4, new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(4024), "Ciencias", 8.5m, 6.5m, 7.8m, "Segundo Trimestre" },
                    { 3, 2023, 3, new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(4026), "Historia", 9.5m, 8.5m, 9.2m, "Tercer Trimestre" },
                    { 4, 2023, 5, new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(4028), "Lenguaje", 8.0m, 6.0m, 7.2m, "Primer Semestre" },
                    { 5, 2023, 2, new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(4029), "Arte", 9.0m, 8.0m, 8.7m, "Segundo Semestre" },
                    { 6, 2023, 3, new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(4031), "Educación Física", 10.0m, 9.0m, 9.5m, "Trimestre Extra" }
                });

            migrationBuilder.InsertData(
                table: "EstudianteDocumentos",
                columns: new[] { "EstudianteDocumentosId", "Estado", "FechaActualizacion", "NombreDocumento", "NumeroDocumento", "Observaciones", "Tamaño", "TipoDocumento", "Ubicacion" },
                values: new object[,]
                {
                    { new Guid("10a5e754-1570-4be0-8650-2c53d7cfb4d3"), true, new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1019), "Fotografía del Estudiante", 1111111, "Foto de perfil", 1024, "Identificación", "ruta/al/documento10" },
                    { new Guid("2d54a999-187f-4a8c-99db-d17841e7938c"), true, new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(986), "Diploma", 987654, "Logros académicos", 2048, "Educativo", "ruta/al/documento2" },
                    { new Guid("3e68515e-3a47-4a62-a8c7-9f12242d020e"), false, new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(999), "Certificado de Graduación", 123456, "Graduación universitaria", 1536, "Educativo", "ruta/al/documento3" },
                    { new Guid("4a303cce-8c0e-4ae7-89c1-067d0b7741b6"), true, new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1002), "Certificado de Matrícula", 789012, "Matrícula escolar", 8192, "Educativo", "ruta/al/documento4" },
                    { new Guid("5f78d0e1-579e-4dfc-82a1-92010b4191d3"), true, new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1008), "Cédula de Identidad", 555555, "Documento oficial", 4096, "Identificación", "ruta/al/documento5" },
                    { new Guid("6a30c846-4b9d-4cf5-bb17-051a3e9d1b72"), true, null, "Certificado de Nacimiento", 61464465, "Ninguna", 1024, "Identificación", "ruta/al/documento1" },
                    { new Guid("7e15d9a4-98cb-4d14-9a35-862f8c202725"), true, new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1014), "Boleta de Calificaciones", 9876543, "Registro académico", 5120, "Educativo", "ruta/al/documento7" },
                    { new Guid("8f4a67c2-fd5e-4316-8c50-7249f159d0f1"), true, new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1016), "Pasaporte", 1234567, "Documento de viaje", 4096, "Identificación", "ruta/al/documento8" },
                    { new Guid("9b9d6d8f-72f0-4f0a-8e18-1e75b0182e3f"), true, new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1018), "Certificado Médico", 543210, "Informe médico", 2048, "Salud", "ruta/al/documento9" },
                    { new Guid("f38f6b1a-86e9-4d9d-8a7a-62f17e6f1ba2"), true, new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(1011), "Carné de Estudiante", 7890123, "Carné escolar", 3072, "Identificación", "ruta/al/documento6" }
                });

            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "HorarioId", "DiaSemana", "DuracionClaseMinutos", "EstadoHorario", "FechaFinClases", "FechaInicioClases", "GrupoSeccion", "HoraFin", "HoraInicio", "NotificacionCambioHorario", "PeriodoAcademico", "ProfesorAsistente", "SalaAula" },
                values: new object[,]
                {
                    { new Guid("0ab79944-5869-4d2e-8868-94ace9184283"), "Martes", 120, "Activo", new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupo B", new TimeSpan(0, 16, 0, 0, 0), new TimeSpan(0, 14, 0, 0, 0), "Sí", "Semestre de Primavera", "Profesor Asistente 2", "Aula 203" },
                    { new Guid("32429925-e23e-48df-b230-70fbdb4a9d18"), "Viernes", 120, "Activo", new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupo E", new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), "No", "Semestre de Primavera", "Profesor Asistente 5", "Aula 102" },
                    { new Guid("8a83b060-5eaa-492f-af49-f58f81a9d666"), "Jueves", 120, "Activo", new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupo D", new TimeSpan(0, 18, 30, 0, 0), new TimeSpan(0, 16, 30, 0, 0), "Sí", "Semestre de Invierno", "Profesor Asistente 4", "Aula 401" },
                    { new Guid("96d94194-8f4f-4363-aa34-7c7fc3cc8079"), "Lunes", 120, "Activo", new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupo A", new TimeSpan(0, 11, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), "No", "Semestre de Otoño", "Profesor Asistente 1", "Aula 101" },
                    { new Guid("ed44d190-954e-43c5-8b01-c1a42126e865"), "Miércoles", 120, "Activo", new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupo C", new TimeSpan(0, 13, 30, 0, 0), new TimeSpan(0, 11, 30, 0, 0), "No", "Semestre de Verano", "Profesor Asistente 3", "Aula 305" }
                });

            migrationBuilder.InsertData(
                table: "Materias",
                columns: new[] { "MateriaId", "DepartamentoAcademico", "Descripcion", "Estado", "GrupoSeccionMateria", "MetodosEnsenanza", "ModalidadEnsenanza", "Nivel", "Nombre", "NotasAdicionales", "ProfesorAsignado" },
                values: new object[,]
                {
                    { new Guid("05ef7383-2284-42f3-bbc5-3860aa53b3e9"), "Departamento de Informática", "Curso de Ciencias de la Computación", "En progreso", "Grupo C", "Clases virtuales y proyectos prácticos", "En línea", "Avanzado", "Ciencias de la Computación", "Requiere acceso a una computadora.", "Profesor de Informática" },
                    { new Guid("089abce0-58d6-4cba-9d67-b0768ab1daa6"), "Departamento de Historia", "Curso de Historia Mundial", "Inscripciones abiertas", "Grupo B", "Conferencias y debates", "Presencial", "Intermedio", "Historia", "Recomendado para estudiantes de Historia.", "Profesor Historiador" },
                    { new Guid("67c21d7a-6090-4926-8ef8-e46c5b1a842e"), "Departamento de Arte", "Curso de Arte Contemporáneo", "Inscripciones abiertas", "Grupo G", "Prácticas artísticas y exposiciones", "Presencial", "Intermedio", "Arte", "No se requiere experiencia previa en arte.", "Profesor de Arte" },
                    { new Guid("9e98a33e-0f97-4cc2-81c3-77dfa533d69c"), "Departamento de Economía", "Curso de Economía Moderna", "En progreso", "Grupo F", "Clases virtuales y análisis económico", "En línea", "Intermedio", "Economía", "Abordaremos temas financieros actuales.", "Profesor Economista" },
                    { new Guid("d2cf2feb-691a-4ae5-81a0-dcceb33d96cd"), "Departamento de Literatura", "Curso de Literatura Universal", "Inscripciones abiertas", "Grupo D", "Lecturas y discusiones literarias", "Presencial", "Intermedio", "Literatura", "Apto para amantes de la lectura.", "Profesor Literario" },
                    { new Guid("d57939e5-660a-4580-8fdf-df0effa91c68"), "Departamento de Matemáticas", "Curso de Matemáticas Avanzadas", "En progreso", "Grupo A", "Clases teóricas y prácticas", "Presencial", "Avanzado", "Matemáticas", "Se requiere calculadora científica.", "Profesor Matemático" },
                    { new Guid("ff7231c2-3dde-4cd2-8626-221d61e95ce5"), "Departamento de Física", "Curso de Física Avanzada", "Completo", "Grupo E", "Experimentos y clases teóricas", "Presencial", "Avanzado", "Física", "Requiere conocimientos previos de física.", "Profesor de Física" }
                });

            migrationBuilder.InsertData(
                table: "Matricula",
                columns: new[] { "MatriculaId", "CategoriaMatricula", "Comentarios", "EstadoMatricula", "FechaMatricula", "InformacionPlanEstudios", "PeriodoAcademico", "RegistroCambios", "TipoMatricula" },
                values: new object[,]
                {
                    { new Guid("2daaa313-7543-4eb2-8b04-256e6b7811ec"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 1", "Activa", new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2543), "Plan de estudios 2023", 2024, "Registro de cambios 1", "Matrícula Regular" },
                    { new Guid("4b0f87af-09fe-4323-a040-56fee7542b76"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 4", "Activa", new DateTime(2024, 5, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2556), "Plan de estudios 2023", 2024, "Registro de cambios 4", "Matrícula Regular" },
                    { new Guid("4be17872-8364-4cf1-aa0d-e0263891d79a"), "Estudiante de Tiempo Parcial", "Comentario sobre la matrícula 2", "Pendiente", new DateTime(2024, 3, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2549), "Plan de estudios 2023", 2024, "Registro de cambios 2", "Matrícula Parcial" },
                    { new Guid("787ad770-e8e8-4176-a5a7-1f1e639e7267"), "Estudiante Internacional", "Comentario sobre la matrícula 3", "Cancelada", new DateTime(2024, 4, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2553), "Plan de estudios 2023", 2024, "Registro de cambios 3", "Matrícula Regular" },
                    { new Guid("b4ae983c-6fb7-40f3-b646-b4061b594c71"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 5", "Activa", new DateTime(2024, 6, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2563), "Plan de estudios 2023", 2024, "Registro de cambios 5", "Matrícula Regular" }
                });

            migrationBuilder.InsertData(
                table: "Notas",
                columns: new[] { "NotaId", "FechaCreacion", "Materia", "Periodo", "Titulo", "Valor" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(4441), "Matemáticas", "Primer Semestre", "Examen de Matemáticas", 85 },
                    { 2, new DateTime(2024, 2, 14, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(4443), "Ciencias", "Segundo Semestre", "Proyecto de Ciencias", 92 },
                    { 3, new DateTime(2024, 2, 9, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(4445), "Historia", "Primer Semestre", "Tarea de Historia", 75 },
                    { 4, new DateTime(2024, 2, 17, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(4447), "Español", "Segundo Semestre", "Presentación de Español", 88 },
                    { 5, new DateTime(2024, 2, 12, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(4448), "Inglés", "Primer Semestre", "Prueba de Inglés", 95 }
                });

            migrationBuilder.InsertData(
                table: "PreMatricula",
                columns: new[] { "PreMatriculaId", "EstadoPreMatricula", "GradoONivel", "Observaciones", "RequisitosDocumentacion", "Turno" },
                values: new object[,]
                {
                    { new Guid("2e772d8b-b869-43af-8095-f694ffd7b31b"), "Activa", "Séptimo de Secundaria", "Estudiante de transferencia.", "SiCumplio", "Tarde" },
                    { new Guid("47efefe3-4fc9-4682-a9d0-25aac2e228dc"), "Pendiente", "Tercero de Primaria", "Estudiante extranjero.", "SiCumplio", "Mañana" },
                    { new Guid("6eafd1fc-3379-4c8d-889a-f75f6741dfe5"), "Activa", "Segundo de Primaria", "Estudiante con discapacidad visual.", "SiCumplio", "Mañana" },
                    { new Guid("9e46efb0-0039-4061-a97b-4a4a9361e556"), "Pendiente", "Octavo de Secundaria", "Estudiante sin observaciones adicionales.", "Si cumplio", "Tarde" },
                    { new Guid("d66dcd25-bd61-4aa1-a669-f008f0dbff0a"), "Pendiente", "Quinto de Primaria", "Estudiante con requerimientos especiales.", "NoCumplio", "Mañana" },
                    { new Guid("f4855af5-fb8c-42f3-8dc3-541cedf540c0"), "Activa", "Cuarto de Secundaria", "Estudiante con beca deportiva.", "SiCumplio", "Tarde" }
                });

            migrationBuilder.InsertData(
                table: "RespuestaCupo",
                columns: new[] { "RespuestaCupoId", "DuracionRespuesta", "EstadoRespuesta", "FechaRespuesta", "FechaVencimiento", "MensajeRespuesta", "Prioridad", "TipoRespuesta", "UsuarioRespuesta" },
                values: new object[,]
                {
                    { new Guid("117a885c-6936-4347-9896-221f19d34882"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2024, 2, 23, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2133), new DateTime(2024, 6, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2133), "Respuesta 4", "Alta", "Aceptación", "Usuario4" },
                    { new Guid("328582eb-e621-41cf-a3f4-e6052673160a"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2024, 2, 25, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2137), new DateTime(2024, 8, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2138), "Respuesta 6", "Alta", "Aceptación", "Usuario6" },
                    { new Guid("35f4796d-4573-4e55-a088-4f08b671e981"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2024, 2, 20, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2115), new DateTime(2024, 3, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2121), "Respuesta 1", "Alta", "Aceptación", "Usuario1" },
                    { new Guid("5949b24b-610d-40ae-b2f5-3d2b3bac1f68"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2024, 2, 28, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2144), new DateTime(2024, 11, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2145), "Respuesta 9", "Alta", "Aceptación", "Usuario9" },
                    { new Guid("8800a2c9-a720-4ac3-8bed-33e2d8432d4f"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2024, 2, 24, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2135), new DateTime(2024, 7, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2136), "Respuesta 5", "Media", "Rechazo", "Usuario5" },
                    { new Guid("8bfecef6-d72e-4971-9ac9-22de94ecc2fc"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2024, 2, 26, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2140), new DateTime(2024, 9, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2140), "Respuesta 7", "Media", "Rechazo", "Usuario7" },
                    { new Guid("9418f2fd-3259-4d54-b905-2a82e5d2d215"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2024, 2, 21, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2126), new DateTime(2024, 4, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2126), "Respuesta 2", "Media", "Rechazo", "Usuario2" },
                    { new Guid("ba4f11a7-aec0-4906-afcc-d8a428e272f3"), new TimeSpan(60, 0, 0, 0, 0), "Pendiente", new DateTime(2024, 2, 27, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2142), new DateTime(2024, 10, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2143), "Respuesta 8", "Baja", "Pendiente", "Usuario8" },
                    { new Guid("c7c36963-19ba-42c6-ab8c-7d19f3239512"), new TimeSpan(60, 0, 0, 0, 0), "Pendiente", new DateTime(2024, 2, 22, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2128), new DateTime(2024, 5, 19, 11, 46, 34, 247, DateTimeKind.Local).AddTicks(2129), "Respuesta 3", "Baja", "Pendiente", "Usuario3" }
                });

            migrationBuilder.InsertData(
                table: "TelefonoAcudiente",
                columns: new[] { "TelefonoAcudienteId", "AcudienteId", "Indicativo", "Numero", "Tipo" },
                values: new object[,]
                {
                    { new Guid("0225777c-a72d-4da6-b070-71e5cc689fa2"), 4, "+1", -5753, "Móvil" },
                    { new Guid("034f7c7c-b132-424d-b50e-3eb04fde5341"), 1, "+1", -4135, "Móvil" },
                    { new Guid("045178e8-ba9d-44d2-9f7d-b7ddb264a849"), 1, "+1", -667, "Móvil" },
                    { new Guid("0506f979-ce96-4ce4-9d96-10b92d8002af"), 5, "+1", -5555, "Emergencia" },
                    { new Guid("528a3e67-c4b2-4fc9-9a08-67fcb99e51a9"), 5, "+1", 911, "Emergencia" },
                    { new Guid("54a5821b-db79-4377-80b6-5da1c7e5a240"), 3, "+1", -5357, "Fijo" },
                    { new Guid("716bcb57-1df8-47e1-94ab-ed5fa93c2cc6"), 4, "+1", -4333, "Móvil" },
                    { new Guid("7a49b500-4d1b-4199-9c6c-84597f39c3e5"), 3, "+1", -3111, "Fijo" },
                    { new Guid("a222d6c5-56bc-4638-b8f5-79e5b46812bd"), 2, "+1", -6975, "Móvil" },
                    { new Guid("eb3b8dbd-7396-42fe-9481-8a92bf9f5086"), 2, "+1", -1889, "Móvil" }
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
                name: "Docentes");

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
                name: "Notas");

            migrationBuilder.DropTable(
                name: "PreMatricula");

            migrationBuilder.DropTable(
                name: "RespuestaCupo");

            migrationBuilder.DropTable(
                name: "TelefonoAcudiente");
        }
    }
}

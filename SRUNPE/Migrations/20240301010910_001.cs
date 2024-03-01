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
                name: "Acudientes",
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
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NumeroIdentificacionEstudiante = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acudientes", x => x.AcudienteId);
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
                    RegistrosIncidentesProblemas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocenteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    TipoPersona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroDocumento = table.Column<long>(type: "bigint", nullable: false),
                    NumeroContacto = table.Column<long>(type: "bigint", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdjuntarDocumentos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroIdentificacionAcudiente = table.Column<long>(type: "bigint", nullable: false)
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
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartamentoAcademico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nivel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaLimiteInscripcion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MetodosEnsenanza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CupoMaximo = table.Column<int>(type: "int", nullable: false),
                    CupoActual = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinalizacion = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    NotificacionCambioHorario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocenteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "AcudienteCandidatoEstudiante",
                columns: table => new
                {
                    AcudienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CandidatoEstudianteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcudienteCandidatoEstudiante", x => new { x.AcudienteId, x.CandidatoEstudianteId });
                    table.ForeignKey(
                        name: "FK_AcudienteCandidatoEstudiante_Acudientes_AcudienteId",
                        column: x => x.AcudienteId,
                        principalTable: "Acudientes",
                        principalColumn: "AcudienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcudienteCandidatoEstudiante_CandidatoEstudiantes_CandidatoEstudianteId",
                        column: x => x.CandidatoEstudianteId,
                        principalTable: "CandidatoEstudiantes",
                        principalColumn: "CandidatoEstudianteId",
                        onDelete: ReferentialAction.Cascade);
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
                    HorarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AulaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docentes", x => x.DocenteId);
                    table.ForeignKey(
                        name: "FK_Docentes_Aulas_AulaId",
                        column: x => x.AulaId,
                        principalTable: "Aulas",
                        principalColumn: "AulaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Docentes_Horarios_HorarioId",
                        column: x => x.HorarioId,
                        principalTable: "Horarios",
                        principalColumn: "HorarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CursoDocente",
                columns: table => new
                {
                    CursosCursoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocentesDocenteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursoDocente", x => new { x.CursosCursoId, x.DocentesDocenteId });
                    table.ForeignKey(
                        name: "FK_CursoDocente_Cursos_CursosCursoId",
                        column: x => x.CursosCursoId,
                        principalTable: "Cursos",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursoDocente_Docentes_DocentesDocenteId",
                        column: x => x.DocentesDocenteId,
                        principalTable: "Docentes",
                        principalColumn: "DocenteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocenteMateria",
                columns: table => new
                {
                    DocenteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MateriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocenteMateria", x => new { x.DocenteId, x.MateriaId });
                    table.ForeignKey(
                        name: "FK_DocenteMateria_Docentes_DocenteId",
                        column: x => x.DocenteId,
                        principalTable: "Docentes",
                        principalColumn: "DocenteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocenteMateria_Materias_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materias",
                        principalColumn: "MateriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Acudientes",
                columns: new[] { "AcudienteId", "Apellidos", "CorreoElectronico", "Edad", "EstadoCivil", "FechaRegistro", "Nombres", "NumeroIdentificacion", "NumeroIdentificacionEstudiante", "Ocupacion", "RelacionConEstudiante" },
                values: new object[,]
                {
                    { new Guid("086077a9-adbb-4e30-9199-677c82377ddc"), "Perez", "juan.perez@example.com", 45, "Casado", new DateTime(2024, 2, 29, 20, 9, 10, 786, DateTimeKind.Local).AddTicks(8836), "Juan", 123456789, 987654321L, "Ingeniero", "Padre" },
                    { new Guid("2a971859-2b7e-4970-9a18-2d767541b0f7"), "Lopez", "maria.lopez@example.com", 40, "Casada", new DateTime(2024, 2, 29, 20, 9, 10, 786, DateTimeKind.Local).AddTicks(8850), "Maria", 987654321, 123456789L, "Abogada", "Madre" }
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
                columns: new[] { "AulaId", "Capacidad", "DocenteId", "EstadoAula", "HorarioDisponibilidad", "NombreNumero", "NotasAdicionales", "RegistrosIncidentesProblemas", "TipoAula", "Ubicacion", "UltimaActualizacion" },
                values: new object[,]
                {
                    { new Guid("53c29e9a-f7b8-433b-983f-a85b823c4733"), 30, new Guid("57aa9a84-70b2-4e68-235d-987650f3b246"), "Ocupado", "Lunes a Viernes, 10:00 AM - 05:00 PM", "Aula 102", "Equipado con computadoras de última generación", "Reporte de fallo en una computadora", "Laboratorio de Informática", "Edificio de Ciencias", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd249220-eec2-4bbd-c57e-8619cb666ece"), 50, new Guid("a007fb2e-89c1-433a-609b-81a34b070e20"), "Disponible", "Lunes a Viernes, 08:00 AM - 06:00 PM", "Aula 101", "Equipada con proyector", "Ninguno", "Salón de Clases", "Edificio Principal", new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CandidatoEstudiantes",
                columns: new[] { "CandidatoEstudianteId", "AdjuntarDocumentos", "Apellido", "Direccion", "FechaNacimiento", "Genero", "Nombre", "NumeroContacto", "NumeroDocumento", "NumeroIdentificacionAcudiente", "TipoDocumento", "TipoPersona" },
                values: new object[,]
                {
                    { new Guid("0b8671f5-85b0-4d18-93c5-51dea38c0b98"), "Documentos adjuntos", "Rodriguez", "Carrera 456", new DateTime(1998, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Ana", 654L, 456L, 987654321L, "CC", "Estudiante" },
                    { new Guid("61f278b8-f98a-4d6d-8c19-a00f46ebf94c"), "Documentos adjuntos", "Gomez", "Calle 123", new DateTime(2000, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Pedro", 321L, 123L, 123456789L, "CC", "Estudiante" }
                });

            migrationBuilder.InsertData(
                table: "Cupo",
                columns: new[] { "CupoId", "CantidadDisponible", "Descripcion", "Duracion", "Estado", "FechaFin", "FechaInicio", "Ubicacion" },
                values: new object[,]
                {
                    { new Guid("1390799d-1596-4dcc-993f-0e833c65642c"), 5, "Cupo para el taller de programación", new TimeSpan(0, 3, 0, 0, 0), true, new DateTime(2024, 4, 29, 20, 9, 10, 786, DateTimeKind.Local).AddTicks(9812), new DateTime(2024, 2, 29, 20, 9, 10, 786, DateTimeKind.Local).AddTicks(9812), "Aula 101" },
                    { new Guid("4e63be20-70d1-4979-995b-f1925ee845d7"), 20, "Cupo para el seminario de marketing", new TimeSpan(0, 4, 0, 0, 0), true, new DateTime(2024, 5, 29, 20, 9, 10, 786, DateTimeKind.Local).AddTicks(9815), new DateTime(2024, 2, 29, 20, 9, 10, 786, DateTimeKind.Local).AddTicks(9814), "Aula 102" },
                    { new Guid("7683c24b-11ea-4e06-b004-5380d95ce3aa"), 15, "Cupo para el curso de diseño gráfico", new TimeSpan(0, 2, 0, 0, 0), true, new DateTime(2024, 6, 29, 20, 9, 10, 786, DateTimeKind.Local).AddTicks(9819), new DateTime(2024, 2, 29, 20, 9, 10, 786, DateTimeKind.Local).AddTicks(9819), "Aula 103" },
                    { new Guid("dcd86f9e-ef33-401b-9829-402e7c2e8ae3"), 10, "Cupo para el evento principal", new TimeSpan(0, 2, 0, 0, 0), true, new DateTime(2024, 3, 29, 20, 9, 10, 786, DateTimeKind.Local).AddTicks(9800), new DateTime(2024, 2, 29, 20, 9, 10, 786, DateTimeKind.Local).AddTicks(9799), "Salón principal" },
                    { new Guid("efd7fbf7-867b-41ba-847c-17015afcd019"), 30, "Cupo para el evento de networking", new TimeSpan(0, 1, 0, 0, 0), true, new DateTime(2024, 7, 29, 20, 9, 10, 786, DateTimeKind.Local).AddTicks(9821), new DateTime(2024, 2, 29, 20, 9, 10, 786, DateTimeKind.Local).AddTicks(9821), "Aula 104" }
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "CursoId", "CupoActual", "CupoMaximo", "DepartamentoAcademico", "Descripcion", "Estado", "FechaFinalizacion", "FechaInicio", "FechaLimiteInscripcion", "MetodosEnsenanza", "Modalidad", "Nivel" },
                values: new object[,]
                {
                    { new Guid("1c8bea41-730b-438c-8582-728b36b3292e"), 0, 0, "Mathematics Department", "Advanced Calculus", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lectures, problem sets, exams", null, "Third Semester" },
                    { new Guid("59c33cf4-f631-441e-a194-9ceaf2eaaf79"), 0, 0, "English Department", "Advanced English Composition", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lectures, writing assignments, group discussions", null, "Second Semester" },
                    { new Guid("9d46c651-eec2-45d2-86c5-0a9b70f48802"), 0, 0, "Chemistry Department", "Organic Chemistry", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lectures, laboratory experiments", null, "Second Semester" },
                    { new Guid("f33e1ae6-4359-4801-b84b-7c2e285e7b2c"), 0, 0, "History Department", "Introduction to History", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lectures, discussions, research papers", null, "First Semester" },
                    { new Guid("f37f578c-0492-4968-984c-ccab87281d0a"), 0, 0, "Ciencias de la Computación", "Introducción a la Programación", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clases magistrales, laboratorios prácticos", null, "Primer Semestre" }
                });

            migrationBuilder.InsertData(
                table: "DireccionAcudiente",
                columns: new[] { "DireccionAcudienteId", "Calle", "CiudadLocalidad", "CodigoPostal", "ColoniaBarrio", "EstadoProvincia", "Pais" },
                values: new object[,]
                {
                    { new Guid("29a8fb1e-9c70-4abf-960b-9dd1110f682d"), "Carrera 10", "Bogotá", "110321", "La Candelaria", "Bogotá D.C.", "Colombia" },
                    { new Guid("3814bd59-70ca-42b4-91d2-19d95fd372ef"), "Avenida 68", "Bogotá", "110841", "Kennedy", "Bogotá D.C.", "Colombia" },
                    { new Guid("71bc9f88-4511-44d9-ba03-c61ed8b81381"), "Avenida Boyacá", "Bogotá", "110511", "Fontibón", "Bogotá D.C.", "Colombia" },
                    { new Guid("bf279da9-8ab3-4e7e-a289-638f71be94f0"), "Carrera 7", "Bogotá", "110171", "Usaquén", "Bogotá D.C.", "Colombia" },
                    { new Guid("dc9ad6f9-d8f3-4272-a3ad-c3d212371d1e"), "Calle 80", "Bogotá", "110841", "Engativá", "Bogotá D.C.", "Colombia" },
                    { new Guid("dea761e2-63bc-4645-a519-09a7a0eddfae"), "Calle 72", "Bogotá", "110231", "Chapinero", "Bogotá D.C.", "Colombia" },
                    { new Guid("f995a7c7-2741-4509-b862-418e1d60475c"), "Calle 72", "Bogotá", "110231", "Chapinero", "Bogotá D.C.", "Colombia" }
                });

            migrationBuilder.InsertData(
                table: "Estadisticas",
                columns: new[] { "EstadisticaId", "AñoEscolar", "CantidadExamenes", "FechaRegistro", "Materia", "NotaMaxima", "NotaMinima", "NotaPromedio", "PeriodoEscolar" },
                values: new object[,]
                {
                    { 1, 2023, 5, new DateTime(2024, 2, 29, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(2040), "Matemáticas", 9.0m, 7.5m, 8.5m, "Primer Trimestre" },
                    { 2, 2023, 4, new DateTime(2024, 2, 29, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(2044), "Ciencias", 8.5m, 6.5m, 7.8m, "Segundo Trimestre" },
                    { 3, 2023, 3, new DateTime(2024, 2, 29, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(2046), "Historia", 9.5m, 8.5m, 9.2m, "Tercer Trimestre" },
                    { 4, 2023, 5, new DateTime(2024, 2, 29, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(2048), "Lenguaje", 8.0m, 6.0m, 7.2m, "Primer Semestre" },
                    { 5, 2023, 2, new DateTime(2024, 2, 29, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(2049), "Arte", 9.0m, 8.0m, 8.7m, "Segundo Semestre" },
                    { 6, 2023, 3, new DateTime(2024, 2, 29, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(2051), "Educación Física", 10.0m, 9.0m, 9.5m, "Trimestre Extra" }
                });

            migrationBuilder.InsertData(
                table: "EstudianteDocumentos",
                columns: new[] { "EstudianteDocumentosId", "Estado", "FechaActualizacion", "NombreDocumento", "NumeroDocumento", "Observaciones", "Tamaño", "TipoDocumento", "Ubicacion" },
                values: new object[,]
                {
                    { new Guid("10a5e754-1570-4be0-8650-2c53d7cfb4d3"), true, new DateTime(2024, 2, 29, 20, 9, 10, 786, DateTimeKind.Local).AddTicks(9120), "Fotografía del Estudiante", 1111111, "Foto de perfil", 1024, "Identificación", "ruta/al/documento10" },
                    { new Guid("2d54a999-187f-4a8c-99db-d17841e7938c"), true, new DateTime(2024, 2, 29, 20, 9, 10, 786, DateTimeKind.Local).AddTicks(9060), "Diploma", 987654, "Logros académicos", 2048, "Educativo", "ruta/al/documento2" },
                    { new Guid("3e68515e-3a47-4a62-a8c7-9f12242d020e"), false, new DateTime(2024, 2, 29, 20, 9, 10, 786, DateTimeKind.Local).AddTicks(9063), "Certificado de Graduación", 123456, "Graduación universitaria", 1536, "Educativo", "ruta/al/documento3" },
                    { new Guid("4a303cce-8c0e-4ae7-89c1-067d0b7741b6"), true, new DateTime(2024, 2, 29, 20, 9, 10, 786, DateTimeKind.Local).AddTicks(9100), "Certificado de Matrícula", 789012, "Matrícula escolar", 8192, "Educativo", "ruta/al/documento4" },
                    { new Guid("5f78d0e1-579e-4dfc-82a1-92010b4191d3"), true, new DateTime(2024, 2, 29, 20, 9, 10, 786, DateTimeKind.Local).AddTicks(9103), "Cédula de Identidad", 555555, "Documento oficial", 4096, "Identificación", "ruta/al/documento5" },
                    { new Guid("6a30c846-4b9d-4cf5-bb17-051a3e9d1b72"), true, null, "Certificado de Nacimiento", 61464465, "Ninguna", 1024, "Identificación", "ruta/al/documento1" },
                    { new Guid("7e15d9a4-98cb-4d14-9a35-862f8c202725"), true, new DateTime(2024, 2, 29, 20, 9, 10, 786, DateTimeKind.Local).AddTicks(9109), "Boleta de Calificaciones", 9876543, "Registro académico", 5120, "Educativo", "ruta/al/documento7" },
                    { new Guid("8f4a67c2-fd5e-4316-8c50-7249f159d0f1"), true, new DateTime(2024, 2, 29, 20, 9, 10, 786, DateTimeKind.Local).AddTicks(9114), "Pasaporte", 1234567, "Documento de viaje", 4096, "Identificación", "ruta/al/documento8" },
                    { new Guid("9b9d6d8f-72f0-4f0a-8e18-1e75b0182e3f"), true, new DateTime(2024, 2, 29, 20, 9, 10, 786, DateTimeKind.Local).AddTicks(9117), "Certificado Médico", 543210, "Informe médico", 2048, "Salud", "ruta/al/documento9" },
                    { new Guid("f38f6b1a-86e9-4d9d-8a7a-62f17e6f1ba2"), true, new DateTime(2024, 2, 29, 20, 9, 10, 786, DateTimeKind.Local).AddTicks(9106), "Carné de Estudiante", 7890123, "Carné escolar", 3072, "Identificación", "ruta/al/documento6" }
                });

            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "HorarioId", "DiaSemana", "DocenteId", "DuracionClaseMinutos", "EstadoHorario", "FechaFinClases", "FechaInicioClases", "GrupoSeccion", "HoraFin", "HoraInicio", "NotificacionCambioHorario", "PeriodoAcademico" },
                values: new object[,]
                {
                    { new Guid("17793c65-0075-4b33-f071-f84a0774be25"), "Lunes", new Guid("a007fb2e-89c1-433a-609b-81a34b070e20"), 120, "Activo", new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupo A", new TimeSpan(0, 11, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), "No", "Semestre de Otoño" },
                    { new Guid("75acf5e1-58d1-43e5-2385-76f0a8f0f464"), "Martes", new Guid("57aa9a84-70b2-4e68-235d-987650f3b246"), 120, "Activo", new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupo B", new TimeSpan(0, 16, 0, 0, 0), new TimeSpan(0, 14, 0, 0, 0), "Sí", "Semestre de Primavera" }
                });

            migrationBuilder.InsertData(
                table: "Materias",
                columns: new[] { "MateriaId", "DepartamentoAcademico", "Descripcion", "Estado", "GrupoSeccionMateria", "MetodosEnsenanza", "ModalidadEnsenanza", "Nivel", "Nombre", "NotasAdicionales" },
                values: new object[,]
                {
                    { new Guid("01f0ef83-689c-43bc-8a66-c0e039428375"), "Departamento de Informática", "Curso de Ciencias de la Computación", "En progreso", "Grupo C", "Clases virtuales y proyectos prácticos", "En línea", "Avanzado", "Ciencias de la Computación", "Requiere acceso a una computadora." },
                    { new Guid("77596722-b248-49ea-9914-8d98ba49dc8d"), "Departamento de Economía", "Curso de Economía Moderna", "En progreso", "Grupo F", "Clases virtuales y análisis económico", "En línea", "Intermedio", "Economía", "Abordaremos temas financieros actuales." },
                    { new Guid("a64a2af5-758f-4b9f-9e47-7cbc86842b1d"), "Departamento de Historia", "Curso de Historia Mundial", "Inscripciones abiertas", "Grupo B", "Conferencias y debates", "Presencial", "Intermedio", "Historia", "Recomendado para estudiantes de Historia." },
                    { new Guid("cc64e5d8-d6d3-4d57-8ad5-6e988228417c"), "Departamento de Literatura", "Curso de Literatura Universal", "Inscripciones abiertas", "Grupo D", "Lecturas y discusiones literarias", "Presencial", "Intermedio", "Literatura", "Apto para amantes de la lectura." },
                    { new Guid("e9961937-00de-47d5-86e7-429cc4eb793f"), "Departamento de Matemáticas", "Curso de Matemáticas Avanzadas", "En progreso", "Grupo A", "Clases teóricas y prácticas", "Presencial", "Avanzado", "Matemáticas", "Se requiere calculadora científica." },
                    { new Guid("ed535f81-5ed8-4a82-8ff0-a2766ac501a3"), "Departamento de Arte", "Curso de Arte Contemporáneo", "Inscripciones abiertas", "Grupo G", "Prácticas artísticas y exposiciones", "Presencial", "Intermedio", "Arte", "No se requiere experiencia previa en arte." },
                    { new Guid("fd133c57-71f1-4134-8808-831190e27019"), "Departamento de Física", "Curso de Física Avanzada", "Completo", "Grupo E", "Experimentos y clases teóricas", "Presencial", "Avanzado", "Física", "Requiere conocimientos previos de física." }
                });

            migrationBuilder.InsertData(
                table: "Matricula",
                columns: new[] { "MatriculaId", "CategoriaMatricula", "Comentarios", "EstadoMatricula", "FechaMatricula", "InformacionPlanEstudios", "PeriodoAcademico", "RegistroCambios", "TipoMatricula" },
                values: new object[,]
                {
                    { new Guid("4be06e6b-7969-4b85-88f2-5846e8b0fc7e"), "Estudiante de Tiempo Parcial", "Comentario sobre la matrícula 2", "Pendiente", new DateTime(2024, 3, 29, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(533), "Plan de estudios 2023", 2024, "Registro de cambios 2", "Matrícula Parcial" },
                    { new Guid("bc77b891-31c2-4ffd-a021-10afc910507b"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 5", "Activa", new DateTime(2024, 6, 29, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(541), "Plan de estudios 2023", 2024, "Registro de cambios 5", "Matrícula Regular" },
                    { new Guid("c27da0e6-1439-4ec7-a620-fd84e4a35fd4"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 4", "Activa", new DateTime(2024, 5, 29, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(539), "Plan de estudios 2023", 2024, "Registro de cambios 4", "Matrícula Regular" },
                    { new Guid("d50b5176-ba74-4736-af76-249266fc97f4"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 1", "Activa", new DateTime(2024, 2, 29, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(529), "Plan de estudios 2023", 2024, "Registro de cambios 1", "Matrícula Regular" },
                    { new Guid("fb862056-7cc6-46e5-854b-52d3c1d127c1"), "Estudiante Internacional", "Comentario sobre la matrícula 3", "Cancelada", new DateTime(2024, 4, 29, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(536), "Plan de estudios 2023", 2024, "Registro de cambios 3", "Matrícula Regular" }
                });

            migrationBuilder.InsertData(
                table: "Notas",
                columns: new[] { "NotaId", "FechaCreacion", "Materia", "Periodo", "Titulo", "Valor" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 29, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(2523), "Matemáticas", "Primer Semestre", "Examen de Matemáticas", 85 },
                    { 2, new DateTime(2024, 2, 24, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(2525), "Ciencias", "Segundo Semestre", "Proyecto de Ciencias", 92 },
                    { 3, new DateTime(2024, 2, 19, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(2527), "Historia", "Primer Semestre", "Tarea de Historia", 75 },
                    { 4, new DateTime(2024, 2, 27, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(2528), "Español", "Segundo Semestre", "Presentación de Español", 88 },
                    { 5, new DateTime(2024, 2, 22, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(2529), "Inglés", "Primer Semestre", "Prueba de Inglés", 95 }
                });

            migrationBuilder.InsertData(
                table: "PreMatricula",
                columns: new[] { "PreMatriculaId", "EstadoPreMatricula", "GradoONivel", "Observaciones", "RequisitosDocumentacion", "Turno" },
                values: new object[,]
                {
                    { new Guid("20a535a3-b8c0-42ab-b4f1-a7a200cd135a"), "Activa", "Segundo de Primaria", "Estudiante con discapacidad visual.", "SiCumplio", "Mañana" },
                    { new Guid("4587c986-0a14-4a6f-9e3b-0afdffb2c6c7"), "Pendiente", "Octavo de Secundaria", "Estudiante sin observaciones adicionales.", "Si cumplio", "Tarde" },
                    { new Guid("8d85b4d1-8fb4-4c6a-b52d-2ab316c2b64c"), "Activa", "Cuarto de Secundaria", "Estudiante con beca deportiva.", "SiCumplio", "Tarde" },
                    { new Guid("8ff281ad-d071-4b7b-85d9-96b540684ac8"), "Pendiente", "Tercero de Primaria", "Estudiante extranjero.", "SiCumplio", "Mañana" },
                    { new Guid("ac95f7eb-58f3-4c1b-9077-5a8f6b1ec349"), "Pendiente", "Quinto de Primaria", "Estudiante con requerimientos especiales.", "NoCumplio", "Mañana" },
                    { new Guid("f3c01516-883b-49be-b41a-e3b64b2ab12d"), "Activa", "Séptimo de Secundaria", "Estudiante de transferencia.", "SiCumplio", "Tarde" }
                });

            migrationBuilder.InsertData(
                table: "RespuestaCupo",
                columns: new[] { "RespuestaCupoId", "DuracionRespuesta", "EstadoRespuesta", "FechaRespuesta", "FechaVencimiento", "MensajeRespuesta", "Prioridad", "TipoRespuesta", "UsuarioRespuesta" },
                values: new object[,]
                {
                    { new Guid("0cb903f6-169e-47a5-9e03-9cae6dde80ba"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2024, 3, 2, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(32), new DateTime(2024, 4, 29, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(33), "Respuesta 2", "Media", "Rechazo", "Usuario2" },
                    { new Guid("1d199d93-e497-484a-adc4-361f02ebdf99"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2024, 3, 5, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(40), new DateTime(2024, 7, 29, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(41), "Respuesta 5", "Media", "Rechazo", "Usuario5" },
                    { new Guid("365e2f16-97b2-420a-a6ff-12c56018d86a"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2024, 3, 7, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(47), new DateTime(2024, 9, 29, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(47), "Respuesta 7", "Media", "Rechazo", "Usuario7" },
                    { new Guid("66b6d300-40f3-4d57-981d-e39fa58d18d8"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2024, 3, 6, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(42), new DateTime(2024, 8, 29, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(43), "Respuesta 6", "Alta", "Aceptación", "Usuario6" },
                    { new Guid("9223b088-23c9-4763-8f1f-751d7e11759c"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2024, 3, 4, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(38), new DateTime(2024, 6, 29, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(38), "Respuesta 4", "Alta", "Aceptación", "Usuario4" },
                    { new Guid("95089577-a53e-423e-abc5-065b8ebe5b82"), new TimeSpan(60, 0, 0, 0, 0), "Pendiente", new DateTime(2024, 3, 8, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(49), new DateTime(2024, 10, 29, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(50), "Respuesta 8", "Baja", "Pendiente", "Usuario8" },
                    { new Guid("9fd27120-7133-4ac4-8a22-701361d8d110"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2024, 3, 1, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(20), new DateTime(2024, 3, 29, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(27), "Respuesta 1", "Alta", "Aceptación", "Usuario1" },
                    { new Guid("aff7f50a-44f6-4e7e-9526-2f37f4736528"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2024, 3, 9, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(52), new DateTime(2024, 11, 29, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(52), "Respuesta 9", "Alta", "Aceptación", "Usuario9" },
                    { new Guid("b9babd0d-f21c-4bd6-9d54-7f7cc7464cee"), new TimeSpan(60, 0, 0, 0, 0), "Pendiente", new DateTime(2024, 3, 3, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(35), new DateTime(2024, 5, 29, 20, 9, 10, 787, DateTimeKind.Local).AddTicks(36), "Respuesta 3", "Baja", "Pendiente", "Usuario3" }
                });

            migrationBuilder.InsertData(
                table: "TelefonoAcudiente",
                columns: new[] { "TelefonoAcudienteId", "AcudienteId", "Indicativo", "Numero", "Tipo" },
                values: new object[,]
                {
                    { new Guid("04eb3375-fb7c-498d-970c-2b5c9484a78c"), 3, "+1", -5357, "Fijo" },
                    { new Guid("12129549-c00c-4e56-afff-4419349f34ec"), 5, "+1", -5555, "Emergencia" },
                    { new Guid("1e81f2cb-bb02-464b-a23b-1355ab323b0c"), 4, "+1", -5753, "Móvil" },
                    { new Guid("535e6d4d-49c4-42dc-aa06-e2b907e1216a"), 2, "+1", -6975, "Móvil" },
                    { new Guid("6c0a90b3-895c-4413-96ca-beff48fafbed"), 4, "+1", -4333, "Móvil" },
                    { new Guid("cb5b6f57-7061-413e-9a2a-d3237eac7c03"), 1, "+1", -667, "Móvil" },
                    { new Guid("db4f49ad-b811-4522-b502-64ca9c6d629b"), 2, "+1", -1889, "Móvil" },
                    { new Guid("f429c2a7-39ea-4fff-b1a4-7d2cc8633e28"), 3, "+1", -3111, "Fijo" },
                    { new Guid("f78d8c36-d22c-4f6d-90ac-3d3fcb4e8bb0"), 1, "+1", -4135, "Móvil" },
                    { new Guid("f9e50c99-987e-4d61-be9a-57dc6bbbd3ea"), 5, "+1", 911, "Emergencia" }
                });

            migrationBuilder.InsertData(
                table: "Docentes",
                columns: new[] { "DocenteId", "AulaId", "ComentariosNotas", "CorreoElectronico", "CursosAsignados", "Direccion", "EstadoLaboral", "FechaContratacion", "FechaNacimiento", "Genero", "HorarioClases", "HorarioId", "NivelExperiencia", "Nombre", "NumeroIdentificacion", "NumeroTelefono" },
                values: new object[,]
                {
                    { new Guid("57aa9a84-70b2-4e68-235d-987650f3b246"), new Guid("53c29e9a-f7b8-433b-983f-a85b823c4733"), "Passionate about her subject and dedicated to student success.", "alice.johnson@example.com", "Literature, History", "456 Oak Avenue, Townsville", "Active", new DateTime(2015, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female", "Tue-Thu: 10 am - 6 pm", new Guid("75acf5e1-58d1-43e5-2385-76f0a8f0f464"), "Intermediate", "Alice Johnson", "D987654321", "+1 (555) 987-6543" },
                    { new Guid("a007fb2e-89c1-433a-609b-81a34b070e20"), new Guid("bd249220-eec2-4bbd-c57e-8619cb666ece"), "Excellent teacher with great communication skills.", "john.smith@example.com", "Mathematics, Physics", "123 Main Street, Cityville", "Active", new DateTime(2010, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", "Mon-Fri: 8 am - 4 pm", new Guid("17793c65-0075-4b33-f071-f84a0774be25"), "Senior", "John Smith", "D123456789", "+1 (555) 123-4567" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcudienteCandidatoEstudiante_CandidatoEstudianteId",
                table: "AcudienteCandidatoEstudiante",
                column: "CandidatoEstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_CursoDocente_DocentesDocenteId",
                table: "CursoDocente",
                column: "DocentesDocenteId");

            migrationBuilder.CreateIndex(
                name: "IX_DocenteMateria_MateriaId",
                table: "DocenteMateria",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Docentes_AulaId",
                table: "Docentes",
                column: "AulaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Docentes_HorarioId",
                table: "Docentes",
                column: "HorarioId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcudienteCandidatoEstudiante");

            migrationBuilder.DropTable(
                name: "Asistencia");

            migrationBuilder.DropTable(
                name: "Cupo");

            migrationBuilder.DropTable(
                name: "CursoDocente");

            migrationBuilder.DropTable(
                name: "DireccionAcudiente");

            migrationBuilder.DropTable(
                name: "DocenteMateria");

            migrationBuilder.DropTable(
                name: "Estadisticas");

            migrationBuilder.DropTable(
                name: "EstudianteDocumentos");

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

            migrationBuilder.DropTable(
                name: "Acudientes");

            migrationBuilder.DropTable(
                name: "CandidatoEstudiantes");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Docentes");

            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropTable(
                name: "Aulas");

            migrationBuilder.DropTable(
                name: "Horarios");
        }
    }
}

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
                    CodigoCurso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartamentoAcademico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nivel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetodosEnsenanza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Año = table.Column<int>(type: "int", nullable: false),
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
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartamentoAcademico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nivel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creditos = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotasAdicionales = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetodosEnsenanza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HorasTeoricas = table.Column<int>(type: "int", nullable: false),
                    HorasPracticas = table.Column<int>(type: "int", nullable: false)
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
                    Estudiante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Curso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PeriodoAcademico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Materia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorNota = table.Column<int>(type: "int", nullable: false),
                    TipoNota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescripcionNota = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContrasenaHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ContrasenaSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
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
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcudienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DireccionAcudiente", x => x.DireccionAcudienteId);
                    table.ForeignKey(
                        name: "FK_DireccionAcudiente_Acudientes_AcudienteId",
                        column: x => x.AcudienteId,
                        principalTable: "Acudientes",
                        principalColumn: "AcudienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TelefonoAcudiente",
                columns: table => new
                {
                    TelefonoAcudienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Indicativo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcudienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelefonoAcudiente", x => x.TelefonoAcudienteId);
                    table.ForeignKey(
                        name: "FK_TelefonoAcudiente_Acudientes_AcudienteId",
                        column: x => x.AcudienteId,
                        principalTable: "Acudientes",
                        principalColumn: "AcudienteId",
                        onDelete: ReferentialAction.Cascade);
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
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TituloAcademico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaContratacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstadoLaboral = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroIdentificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComentariosNotas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NivelExperiencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HorarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AulaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docentes", x => x.DocenteId);
                    table.ForeignKey(
                        name: "FK_Docentes_Aulas_AulaId",
                        column: x => x.AulaId,
                        principalTable: "Aulas",
                        principalColumn: "AulaId");
                    table.ForeignKey(
                        name: "FK_Docentes_Horarios_HorarioId",
                        column: x => x.HorarioId,
                        principalTable: "Horarios",
                        principalColumn: "HorarioId");
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
                    { new Guid("40672d8b-a179-4552-884f-9a2f123b9097"), "Perez", "juan.perez@example.com", 45, "Casado", new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(3602), "Juan", 123456789, 0L, "Ingeniero", "Padre" },
                    { new Guid("aa7dc992-de29-47da-a68c-72f54e8209f7"), "Lopez", "maria.lopez@example.com", 40, "Casada", new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(3620), "Maria", 987654321, 0L, "Abogada", "Madre" }
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
                    { new Guid("53c29e9a-f7b8-433b-983f-a85b823c4733"), 30, new Guid("00000000-0000-0000-0000-000000000000"), "Ocupado", "Lunes a Viernes, 10:00 AM - 05:00 PM", "Aula 102", "Equipado con computadoras de última generación", "Reporte de fallo en una computadora", "Laboratorio de Informática", "Edificio de Ciencias", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd249220-eec2-4bbd-c57e-8619cb666ece"), 50, new Guid("00000000-0000-0000-0000-000000000000"), "Disponible", "Lunes a Viernes, 08:00 AM - 06:00 PM", "Aula 101", "Equipada con proyector", "Ninguno", "Salón de Clases", "Edificio Principal", new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CandidatoEstudiantes",
                columns: new[] { "CandidatoEstudianteId", "AdjuntarDocumentos", "Apellido", "Direccion", "FechaNacimiento", "Genero", "Nombre", "NumeroContacto", "NumeroDocumento", "NumeroIdentificacionAcudiente", "TipoDocumento", "TipoPersona" },
                values: new object[,]
                {
                    { new Guid("601cfb17-25ee-46c8-a6cd-0f95b4b35762"), "Documentos adjuntos", "Rodriguez", "Carrera 456", new DateTime(1998, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Ana", 654L, 456L, 0L, "CC", "Estudiante" },
                    { new Guid("8630bae4-7cb6-4ea6-8b5a-bfc867c05a1e"), "Documentos adjuntos", "Gomez", "Calle 123", new DateTime(2000, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Pedro", 321L, 123L, 0L, "CC", "Estudiante" }
                });

            migrationBuilder.InsertData(
                table: "Cupo",
                columns: new[] { "CupoId", "CantidadDisponible", "Descripcion", "Duracion", "Estado", "FechaFin", "FechaInicio", "Ubicacion" },
                values: new object[,]
                {
                    { new Guid("12c68beb-873e-4667-97dd-281aa661e823"), 10, "Cupo para el evento principal", new TimeSpan(0, 2, 0, 0, 0), true, new DateTime(2024, 4, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4538), new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4537), "Salón principal" },
                    { new Guid("23d24438-857a-4c34-8724-6c902496b494"), 30, "Cupo para el evento de networking", new TimeSpan(0, 1, 0, 0, 0), true, new DateTime(2024, 8, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4558), new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4558), "Aula 104" },
                    { new Guid("296e59d1-0387-44b9-9acb-ae9fd7aa77ad"), 5, "Cupo para el taller de programación", new TimeSpan(0, 3, 0, 0, 0), true, new DateTime(2024, 5, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4551), new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4550), "Aula 101" },
                    { new Guid("34935ca6-1496-49a0-b3f4-52889949a616"), 20, "Cupo para el seminario de marketing", new TimeSpan(0, 4, 0, 0, 0), true, new DateTime(2024, 6, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4553), new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4553), "Aula 102" },
                    { new Guid("7fd78cd1-19c5-4cae-9f78-6ca2ef33a6ee"), 15, "Cupo para el curso de diseño gráfico", new TimeSpan(0, 2, 0, 0, 0), true, new DateTime(2024, 7, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4556), new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4555), "Aula 103" }
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "CursoId", "Año", "CodigoCurso", "CupoActual", "CupoMaximo", "DepartamentoAcademico", "Descripcion", "Estado", "FechaFinalizacion", "FechaInicio", "MetodosEnsenanza", "Modalidad", "Nivel" },
                values: new object[,]
                {
                    { new Guid("b88d3311-8514-4c1d-a393-6124029bfaa2"), 2024, "QUI105", 30, 35, "Química", "Química Orgánica", "Activo", new DateTime(2024, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virtual", "En línea", "Intermedio" },
                    { new Guid("c4f4d494-8327-49f8-8541-3a18597bcfa1"), 2024, "LIT104", 18, 20, "Literatura", "Literatura Española", "Activo", new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Presencial", "Presencial", "Básico" },
                    { new Guid("d16955ad-426f-4da4-8958-aa04cefce3bc"), 2024, "FIS102", 35, 40, "Ciencias Físicas", "Física General", "Activo", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virtual", "En línea", "Intermedio" },
                    { new Guid("d4240970-16fe-43ab-b685-f8c0b57f373f"), 2024, "MAT101", 25, 30, "Matemáticas", "Introducción a las Matemáticas", "Activo", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Presencial", "Presencial", "Básico" },
                    { new Guid("de40f284-8a87-4623-9144-43773111f52f"), 2024, "HIS103", 20, 25, "Historia", "Historia del Mundo Contemporáneo", "Activo", new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Híbrido", "Híbrido", "Avanzado" }
                });

            migrationBuilder.InsertData(
                table: "DireccionAcudiente",
                columns: new[] { "DireccionAcudienteId", "AcudienteId", "Calle", "CiudadLocalidad", "CodigoPostal", "ColoniaBarrio", "EstadoProvincia", "Pais" },
                values: new object[,]
                {
                    { new Guid("5cb9a67f-0b90-4e3a-a3a7-14c2296aaf20"), new Guid("40672d8b-a179-4552-884f-9a2f123b9097"), "Carrera 50", "Bogotá", "110221", "Sur", "Bogotá", "Colombia" },
                    { new Guid("740f2f8e-930e-43f2-8843-d597c2718053"), new Guid("aa7dc992-de29-47da-a68c-72f54e8209f7"), "Calle 100", "Bogotá", "110111", "Norte", "Bogotá", "Colombia" }
                });

            migrationBuilder.InsertData(
                table: "Docentes",
                columns: new[] { "DocenteId", "Apellidos", "AulaId", "ComentariosNotas", "CorreoElectronico", "Direccion", "EstadoLaboral", "FechaContratacion", "FechaNacimiento", "Genero", "HorarioId", "NivelExperiencia", "Nombres", "NumeroIdentificacion", "NumeroTelefono", "TituloAcademico" },
                values: new object[,]
                {
                    { new Guid("118625db-d405-4bbc-9a19-8bcf87a0fbaa"), "Pérez", null, "Excelente capacidad de enseñanza", "juan.perez@email.com", "Calle Falsa 123", "Activo", new DateTime(2010, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", null, "Alto", "Juan", "12345678", "555-1234", "Licenciado en Matemáticas" },
                    { new Guid("2d2a9c09-1973-4128-b220-530aad0b09ea"), "Rodríguez", null, "Especialista en biología marina", "laura.rodriguez@email.com", "Callejón de los Milagros 101", "Activo", new DateTime(2015, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", null, "Bajo", "Laura", "44332211", "555-1213", "Licenciada en Biología" },
                    { new Guid("cf374423-8e6f-4afe-81a6-06511f16e548"), "González", null, "Experta en historia antigua", "maria.gonzalez@email.com", "Avenida Principal 456", "Activo", new DateTime(2012, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", null, "Medio", "María", "87654321", "555-5678", "Doctora en Historia" },
                    { new Guid("fb1b69b1-86d5-4e3c-9de5-4aa445b60299"), "Martínez", null, "Gran habilidad en experimentos prácticos", "carlos.martinez@email.com", "Boulevard del Río 789", "Inactivo", new DateTime(2008, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", null, "Alto", "Carlos", "11223344", "555-9101", "Magíster en Física" }
                });

            migrationBuilder.InsertData(
                table: "Estadisticas",
                columns: new[] { "EstadisticaId", "AñoEscolar", "CantidadExamenes", "FechaRegistro", "Materia", "NotaMaxima", "NotaMinima", "NotaPromedio", "PeriodoEscolar" },
                values: new object[,]
                {
                    { 1, 2023, 5, new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(6644), "Matemáticas", 9.0m, 7.5m, 8.5m, "Primer Trimestre" },
                    { 2, 2023, 4, new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(6647), "Ciencias", 8.5m, 6.5m, 7.8m, "Segundo Trimestre" },
                    { 3, 2023, 3, new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(6649), "Historia", 9.5m, 8.5m, 9.2m, "Tercer Trimestre" },
                    { 4, 2023, 5, new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(6651), "Lenguaje", 8.0m, 6.0m, 7.2m, "Primer Semestre" },
                    { 5, 2023, 2, new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(6652), "Arte", 9.0m, 8.0m, 8.7m, "Segundo Semestre" },
                    { 6, 2023, 3, new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(6654), "Educación Física", 10.0m, 9.0m, 9.5m, "Trimestre Extra" }
                });

            migrationBuilder.InsertData(
                table: "EstudianteDocumentos",
                columns: new[] { "EstudianteDocumentosId", "Estado", "FechaActualizacion", "NombreDocumento", "NumeroDocumento", "Observaciones", "Tamaño", "TipoDocumento", "Ubicacion" },
                values: new object[,]
                {
                    { new Guid("10a5e754-1570-4be0-8650-2c53d7cfb4d3"), true, new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(3858), "Fotografía del Estudiante", 1111111, "Foto de perfil", 1024, "Identificación", "ruta/al/documento10" },
                    { new Guid("2d54a999-187f-4a8c-99db-d17841e7938c"), true, new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(3838), "Diploma", 987654, "Logros académicos", 2048, "Educativo", "ruta/al/documento2" },
                    { new Guid("3e68515e-3a47-4a62-a8c7-9f12242d020e"), false, new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(3841), "Certificado de Graduación", 123456, "Graduación universitaria", 1536, "Educativo", "ruta/al/documento3" },
                    { new Guid("4a303cce-8c0e-4ae7-89c1-067d0b7741b6"), true, new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(3843), "Certificado de Matrícula", 789012, "Matrícula escolar", 8192, "Educativo", "ruta/al/documento4" },
                    { new Guid("5f78d0e1-579e-4dfc-82a1-92010b4191d3"), true, new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(3845), "Cédula de Identidad", 555555, "Documento oficial", 4096, "Identificación", "ruta/al/documento5" },
                    { new Guid("6a30c846-4b9d-4cf5-bb17-051a3e9d1b72"), true, null, "Certificado de Nacimiento", 61464465, "Ninguna", 1024, "Identificación", "ruta/al/documento1" },
                    { new Guid("7e15d9a4-98cb-4d14-9a35-862f8c202725"), true, new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(3852), "Boleta de Calificaciones", 9876543, "Registro académico", 5120, "Educativo", "ruta/al/documento7" },
                    { new Guid("8f4a67c2-fd5e-4316-8c50-7249f159d0f1"), true, new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(3854), "Pasaporte", 1234567, "Documento de viaje", 4096, "Identificación", "ruta/al/documento8" },
                    { new Guid("9b9d6d8f-72f0-4f0a-8e18-1e75b0182e3f"), true, new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(3856), "Certificado Médico", 543210, "Informe médico", 2048, "Salud", "ruta/al/documento9" },
                    { new Guid("f38f6b1a-86e9-4d9d-8a7a-62f17e6f1ba2"), true, new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(3850), "Carné de Estudiante", 7890123, "Carné escolar", 3072, "Identificación", "ruta/al/documento6" }
                });

            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "HorarioId", "DiaSemana", "DocenteId", "DuracionClaseMinutos", "EstadoHorario", "FechaFinClases", "FechaInicioClases", "GrupoSeccion", "HoraFin", "HoraInicio", "NotificacionCambioHorario", "PeriodoAcademico" },
                values: new object[,]
                {
                    { new Guid("17793c65-0075-4b33-f071-f84a0774be25"), "Lunes", new Guid("00000000-0000-0000-0000-000000000000"), 120, "Activo", new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupo A", new TimeSpan(0, 11, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), "No", "Semestre de Otoño" },
                    { new Guid("75acf5e1-58d1-43e5-2385-76f0a8f0f464"), "Martes", new Guid("00000000-0000-0000-0000-000000000000"), 120, "Activo", new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupo B", new TimeSpan(0, 16, 0, 0, 0), new TimeSpan(0, 14, 0, 0, 0), "Sí", "Semestre de Primavera" }
                });

            migrationBuilder.InsertData(
                table: "Materias",
                columns: new[] { "MateriaId", "Creditos", "DepartamentoAcademico", "Descripcion", "Estado", "HorasPracticas", "HorasTeoricas", "MetodosEnsenanza", "Nivel", "Nombre", "NotasAdicionales" },
                values: new object[,]
                {
                    { new Guid("68bf59c8-5b00-42e8-9bcd-848cac7cb8a1"), 6, "Biología", "Análisis profundo de la biología celular", "Activa", 4, 4, "Clases teóricas, laboratorios, proyectos de investigación", "Universitaria", "Biología Avanzada", "Requiere conocimientos previos de biología básica" },
                    { new Guid("72ce35b1-2cd7-4cfa-9de6-6f47d36e2a84"), 4, "Matemáticas", "Fundamentos de aritmética y álgebra", "Activa", 2, 3, "Clases teóricas y ejercicios prácticos", "Secundaria", "Matemáticas Básicas", "Ninguna" },
                    { new Guid("82c12189-2801-449c-b795-5907da34f92e"), 5, "Física", "Introducción a la mecánica, termodinámica y ondas", "Activa", 3, 4, "Clases teóricas, laboratorios", "Universitaria", "Física General", "Requiere calculadora científica" },
                    { new Guid("b51e96b8-a8a9-48eb-89be-9ce88570472b"), 3, "Humanidades", "Estudio de obras literarias españolas clásicas", "Inactiva", 1, 3, "Clases teóricas, discusiones en grupo", "Secundaria", "Literatura Española", "Incluye lecturas obligatorias" },
                    { new Guid("f98e0125-31e8-4e41-a59f-826e27d4d5e2"), 3, "Historia", "Exploración de eventos históricos globales", "Activa", 0, 3, "Clases teóricas, análisis de documentos históricos", "Secundaria", "Historia Mundial", "Se recomienda visitar museos y sitios históricos" }
                });

            migrationBuilder.InsertData(
                table: "Matricula",
                columns: new[] { "MatriculaId", "CategoriaMatricula", "Comentarios", "EstadoMatricula", "FechaMatricula", "InformacionPlanEstudios", "PeriodoAcademico", "RegistroCambios", "TipoMatricula" },
                values: new object[,]
                {
                    { new Guid("42875351-c453-4faf-98f7-64d4b6665021"), "Estudiante Internacional", "Comentario sobre la matrícula 3", "Cancelada", new DateTime(2024, 5, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(5153), "Plan de estudios 2023", 2024, "Registro de cambios 3", "Matrícula Regular" },
                    { new Guid("81d8bdcf-3a84-4fb6-b0f1-b271b704b044"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 4", "Activa", new DateTime(2024, 6, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(5157), "Plan de estudios 2023", 2024, "Registro de cambios 4", "Matrícula Regular" },
                    { new Guid("915a03f8-a2b6-4c8d-88f6-e10f47b66adf"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 1", "Activa", new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(5145), "Plan de estudios 2023", 2024, "Registro de cambios 1", "Matrícula Regular" },
                    { new Guid("a050bd4f-8ed1-46df-b4b1-69ca98505b29"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 5", "Activa", new DateTime(2024, 7, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(5159), "Plan de estudios 2023", 2024, "Registro de cambios 5", "Matrícula Regular" },
                    { new Guid("a5f50b3b-4a89-4347-9b6a-9676db9c5a7e"), "Estudiante de Tiempo Parcial", "Comentario sobre la matrícula 2", "Pendiente", new DateTime(2024, 4, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(5149), "Plan de estudios 2023", 2024, "Registro de cambios 2", "Matrícula Parcial" }
                });

            migrationBuilder.InsertData(
                table: "Notas",
                columns: new[] { "NotaId", "Curso", "DescripcionNota", "Estudiante", "FechaCreacion", "Materia", "PeriodoAcademico", "TipoNota", "ValorNota" },
                values: new object[,]
                {
                    { 1, "Matemáticas", "Examen de mitad de periodo", "Juan Pérez", new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(7019), "Álgebra", "Cuarto Periodo", "Examen", 85 },
                    { 2, "Ciencias", "Informe de laboratorio", "María López", new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(7022), "Biología", "Primer Periodo", "Trabajo Práctico", 90 },
                    { 3, "Historia", "Exposición sobre la Revolución Francesa", "Carlos Gómez", new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(7024), "Historia Mundial", "Segundo Periodo", "Exposición", 78 },
                    { 4, "Literatura", "Análisis del Quijote", "Lucía Fernández", new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(7025), "Literatura Española", "Segundo Periodo", "Ensayo", 92 },
                    { 5, "Física", "Evaluación final del curso", "Andrés Martínez", new DateTime(2024, 3, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(7027), "Física Cuántica", "Primer Periodo", "Examen Final", 88 }
                });

            migrationBuilder.InsertData(
                table: "PreMatricula",
                columns: new[] { "PreMatriculaId", "EstadoPreMatricula", "GradoONivel", "Observaciones", "RequisitosDocumentacion", "Turno" },
                values: new object[,]
                {
                    { new Guid("5f31d87e-b318-4c9f-8042-481a08276a55"), "Pendiente", "Octavo de Secundaria", "Estudiante sin observaciones adicionales.", "Si cumplio", "Tarde" },
                    { new Guid("6127894e-ff46-4d6e-8d24-071e49585348"), "Activa", "Cuarto de Secundaria", "Estudiante con beca deportiva.", "SiCumplio", "Tarde" },
                    { new Guid("67be7325-4745-4dcc-a78c-2e37d0bb9ef7"), "Pendiente", "Quinto de Primaria", "Estudiante con requerimientos especiales.", "NoCumplio", "Mañana" },
                    { new Guid("689da532-2ee2-4320-825d-b29024e4d9b1"), "Activa", "Séptimo de Secundaria", "Estudiante de transferencia.", "SiCumplio", "Tarde" },
                    { new Guid("6e5bfbd9-7d96-4542-be56-31dc5defa571"), "Activa", "Segundo de Primaria", "Estudiante con discapacidad visual.", "SiCumplio", "Mañana" },
                    { new Guid("f58dc788-4d95-41e1-96a0-3fb20e9bf461"), "Pendiente", "Tercero de Primaria", "Estudiante extranjero.", "SiCumplio", "Mañana" }
                });

            migrationBuilder.InsertData(
                table: "RespuestaCupo",
                columns: new[] { "RespuestaCupoId", "DuracionRespuesta", "EstadoRespuesta", "FechaRespuesta", "FechaVencimiento", "MensajeRespuesta", "Prioridad", "TipoRespuesta", "UsuarioRespuesta" },
                values: new object[,]
                {
                    { new Guid("2552e780-cf05-481f-aeee-412bfcb167b6"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2024, 3, 27, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4780), new DateTime(2024, 12, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4781), "Respuesta 9", "Alta", "Aceptación", "Usuario9" },
                    { new Guid("369b6395-0197-4570-a7a4-01772b3bfe99"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2024, 3, 22, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4767), new DateTime(2024, 7, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4768), "Respuesta 4", "Alta", "Aceptación", "Usuario4" },
                    { new Guid("6b384be4-cc36-4b50-b417-3546ee75a7aa"), new TimeSpan(60, 0, 0, 0, 0), "Pendiente", new DateTime(2024, 3, 21, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4765), new DateTime(2024, 6, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4765), "Respuesta 3", "Baja", "Pendiente", "Usuario3" },
                    { new Guid("87490c51-db87-48e9-9748-9e77b6a772af"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2024, 3, 25, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4775), new DateTime(2024, 10, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4776), "Respuesta 7", "Media", "Rechazo", "Usuario7" },
                    { new Guid("927319ff-2bab-4427-869c-1d72574170c7"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2024, 3, 24, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4773), new DateTime(2024, 9, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4773), "Respuesta 6", "Alta", "Aceptación", "Usuario6" },
                    { new Guid("9bc07516-48f0-4a71-8a0e-0d259782bcff"), new TimeSpan(60, 0, 0, 0, 0), "Pendiente", new DateTime(2024, 3, 26, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4777), new DateTime(2024, 11, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4778), "Respuesta 8", "Baja", "Pendiente", "Usuario8" },
                    { new Guid("b36061b3-14e8-467a-bdf6-5f6685a67ba4"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2024, 3, 20, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4759), new DateTime(2024, 5, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4759), "Respuesta 2", "Media", "Rechazo", "Usuario2" },
                    { new Guid("c510706e-a110-48be-b4bb-84865cb500ed"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2024, 3, 23, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4770), new DateTime(2024, 8, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4771), "Respuesta 5", "Media", "Rechazo", "Usuario5" },
                    { new Guid("f4ff0ae2-a316-446f-8fa4-c64392f40e21"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2024, 3, 19, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4748), new DateTime(2024, 4, 18, 21, 39, 34, 169, DateTimeKind.Local).AddTicks(4753), "Respuesta 1", "Alta", "Aceptación", "Usuario1" }
                });

            migrationBuilder.InsertData(
                table: "TelefonoAcudiente",
                columns: new[] { "TelefonoAcudienteId", "AcudienteId", "Indicativo", "Numero", "Tipo" },
                values: new object[,]
                {
                    { new Guid("80a8a4c6-d493-4faf-acdf-5ff7d3502ac2"), new Guid("40672d8b-a179-4552-884f-9a2f123b9097"), "+1", -4135, "Móvil" },
                    { new Guid("e541362c-dd5f-4feb-891f-e7cd40b35b47"), new Guid("aa7dc992-de29-47da-a68c-72f54e8209f7"), "+1", -6975, "Móvil" }
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
                name: "IX_DireccionAcudiente_AcudienteId",
                table: "DireccionAcudiente",
                column: "AcudienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DocenteMateria_MateriaId",
                table: "DocenteMateria",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Docentes_AulaId",
                table: "Docentes",
                column: "AulaId",
                unique: true,
                filter: "[AulaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Docentes_HorarioId",
                table: "Docentes",
                column: "HorarioId",
                unique: true,
                filter: "[HorarioId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TelefonoAcudiente_AcudienteId",
                table: "TelefonoAcudiente",
                column: "AcudienteId");
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
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "CandidatoEstudiantes");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Docentes");

            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropTable(
                name: "Acudientes");

            migrationBuilder.DropTable(
                name: "Aulas");

            migrationBuilder.DropTable(
                name: "Horarios");
        }
    }
}

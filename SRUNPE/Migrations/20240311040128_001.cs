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
                    { new Guid("96dd3f1c-630c-4c91-a42f-64c5e1360abe"), "Perez", "juan.perez@example.com", 45, "Casado", new DateTime(2024, 3, 10, 23, 1, 28, 261, DateTimeKind.Local).AddTicks(9351), "Juan", 123456789, 0L, "Ingeniero", "Padre" },
                    { new Guid("ddf52652-f343-4c6d-bf2e-018667977851"), "Lopez", "maria.lopez@example.com", 40, "Casada", new DateTime(2024, 3, 10, 23, 1, 28, 261, DateTimeKind.Local).AddTicks(9370), "Maria", 987654321, 0L, "Abogada", "Madre" }
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
                    { new Guid("54d723ea-ab40-423f-8469-9f1c4ef25167"), "Documentos adjuntos", "Gomez", "Calle 123", new DateTime(2000, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Pedro", 321L, 123L, 0L, "CC", "Estudiante" },
                    { new Guid("c6e2569a-3501-4886-b8b8-8af773ba0a74"), "Documentos adjuntos", "Rodriguez", "Carrera 456", new DateTime(1998, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Ana", 654L, 456L, 0L, "CC", "Estudiante" }
                });

            migrationBuilder.InsertData(
                table: "Cupo",
                columns: new[] { "CupoId", "CantidadDisponible", "Descripcion", "Duracion", "Estado", "FechaFin", "FechaInicio", "Ubicacion" },
                values: new object[,]
                {
                    { new Guid("571ea925-8a2e-4bb6-9dd3-2e63fb770694"), 5, "Cupo para el taller de programación", new TimeSpan(0, 3, 0, 0, 0), true, new DateTime(2024, 5, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(534), new DateTime(2024, 3, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(533), "Aula 101" },
                    { new Guid("9b75d348-f37a-4734-b413-6a7a7374dd4d"), 10, "Cupo para el evento principal", new TimeSpan(0, 2, 0, 0, 0), true, new DateTime(2024, 4, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(506), new DateTime(2024, 3, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(505), "Salón principal" },
                    { new Guid("e87be529-fd4b-48eb-8312-8fe37a3c707d"), 20, "Cupo para el seminario de marketing", new TimeSpan(0, 4, 0, 0, 0), true, new DateTime(2024, 6, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(538), new DateTime(2024, 3, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(537), "Aula 102" },
                    { new Guid("f39b6dfa-2a9f-4a4b-bb0b-ce076b9eefcf"), 30, "Cupo para el evento de networking", new TimeSpan(0, 1, 0, 0, 0), true, new DateTime(2024, 8, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(544), new DateTime(2024, 3, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(544), "Aula 104" },
                    { new Guid("fe8be4b0-f064-42bd-881a-e51688900ae8"), 15, "Cupo para el curso de diseño gráfico", new TimeSpan(0, 2, 0, 0, 0), true, new DateTime(2024, 7, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(541), new DateTime(2024, 3, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(541), "Aula 103" }
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "CursoId", "CupoActual", "CupoMaximo", "DepartamentoAcademico", "Descripcion", "Estado", "FechaFinalizacion", "FechaInicio", "FechaLimiteInscripcion", "MetodosEnsenanza", "Modalidad", "Nivel" },
                values: new object[,]
                {
                    { new Guid("0d964583-1ccc-4c1f-9de8-59b465d61dc6"), 0, 0, "Ciencias de la Computación", "Introducción a la Programación", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clases magistrales, laboratorios prácticos", null, "Primer Semestre" },
                    { new Guid("1b94f078-5dd5-4c25-a7cd-9264a7ac26b9"), 0, 0, "History Department", "Introduction to History", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lectures, discussions, research papers", null, "First Semester" },
                    { new Guid("2b3b5afc-c493-461f-bf9a-5e618b80d218"), 0, 0, "English Department", "Advanced English Composition", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lectures, writing assignments, group discussions", null, "Second Semester" },
                    { new Guid("65472f4b-d9e9-40dd-9e6d-918c68eac3f1"), 0, 0, "Mathematics Department", "Advanced Calculus", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lectures, problem sets, exams", null, "Third Semester" },
                    { new Guid("c8619f9f-32f7-4fb2-bf58-2717edfcd38b"), 0, 0, "Chemistry Department", "Organic Chemistry", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lectures, laboratory experiments", null, "Second Semester" }
                });

            migrationBuilder.InsertData(
                table: "DireccionAcudiente",
                columns: new[] { "DireccionAcudienteId", "AcudienteId", "Calle", "CiudadLocalidad", "CodigoPostal", "ColoniaBarrio", "EstadoProvincia", "Pais" },
                values: new object[,]
                {
                    { new Guid("6a0ea38f-4e68-4490-aa74-863a4758614c"), new Guid("96dd3f1c-630c-4c91-a42f-64c5e1360abe"), "Carrera 50", "Bogotá", "110221", "Sur", "Bogotá", "Colombia" },
                    { new Guid("ba1d1d93-984c-4d22-9070-39b61e9b25f9"), new Guid("ddf52652-f343-4c6d-bf2e-018667977851"), "Calle 100", "Bogotá", "110111", "Norte", "Bogotá", "Colombia" }
                });

            migrationBuilder.InsertData(
                table: "Estadisticas",
                columns: new[] { "EstadisticaId", "AñoEscolar", "CantidadExamenes", "FechaRegistro", "Materia", "NotaMaxima", "NotaMinima", "NotaPromedio", "PeriodoEscolar" },
                values: new object[,]
                {
                    { 1, 2023, 5, new DateTime(2024, 3, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(2748), "Matemáticas", 9.0m, 7.5m, 8.5m, "Primer Trimestre" },
                    { 2, 2023, 4, new DateTime(2024, 3, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(2751), "Ciencias", 8.5m, 6.5m, 7.8m, "Segundo Trimestre" },
                    { 3, 2023, 3, new DateTime(2024, 3, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(2753), "Historia", 9.5m, 8.5m, 9.2m, "Tercer Trimestre" },
                    { 4, 2023, 5, new DateTime(2024, 3, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(2755), "Lenguaje", 8.0m, 6.0m, 7.2m, "Primer Semestre" },
                    { 5, 2023, 2, new DateTime(2024, 3, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(2757), "Arte", 9.0m, 8.0m, 8.7m, "Segundo Semestre" },
                    { 6, 2023, 3, new DateTime(2024, 3, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(2758), "Educación Física", 10.0m, 9.0m, 9.5m, "Trimestre Extra" }
                });

            migrationBuilder.InsertData(
                table: "EstudianteDocumentos",
                columns: new[] { "EstudianteDocumentosId", "Estado", "FechaActualizacion", "NombreDocumento", "NumeroDocumento", "Observaciones", "Tamaño", "TipoDocumento", "Ubicacion" },
                values: new object[,]
                {
                    { new Guid("10a5e754-1570-4be0-8650-2c53d7cfb4d3"), true, new DateTime(2024, 3, 10, 23, 1, 28, 261, DateTimeKind.Local).AddTicks(9783), "Fotografía del Estudiante", 1111111, "Foto de perfil", 1024, "Identificación", "ruta/al/documento10" },
                    { new Guid("2d54a999-187f-4a8c-99db-d17841e7938c"), true, new DateTime(2024, 3, 10, 23, 1, 28, 261, DateTimeKind.Local).AddTicks(9754), "Diploma", 987654, "Logros académicos", 2048, "Educativo", "ruta/al/documento2" },
                    { new Guid("3e68515e-3a47-4a62-a8c7-9f12242d020e"), false, new DateTime(2024, 3, 10, 23, 1, 28, 261, DateTimeKind.Local).AddTicks(9760), "Certificado de Graduación", 123456, "Graduación universitaria", 1536, "Educativo", "ruta/al/documento3" },
                    { new Guid("4a303cce-8c0e-4ae7-89c1-067d0b7741b6"), true, new DateTime(2024, 3, 10, 23, 1, 28, 261, DateTimeKind.Local).AddTicks(9765), "Certificado de Matrícula", 789012, "Matrícula escolar", 8192, "Educativo", "ruta/al/documento4" },
                    { new Guid("5f78d0e1-579e-4dfc-82a1-92010b4191d3"), true, new DateTime(2024, 3, 10, 23, 1, 28, 261, DateTimeKind.Local).AddTicks(9768), "Cédula de Identidad", 555555, "Documento oficial", 4096, "Identificación", "ruta/al/documento5" },
                    { new Guid("6a30c846-4b9d-4cf5-bb17-051a3e9d1b72"), true, null, "Certificado de Nacimiento", 61464465, "Ninguna", 1024, "Identificación", "ruta/al/documento1" },
                    { new Guid("7e15d9a4-98cb-4d14-9a35-862f8c202725"), true, new DateTime(2024, 3, 10, 23, 1, 28, 261, DateTimeKind.Local).AddTicks(9777), "Boleta de Calificaciones", 9876543, "Registro académico", 5120, "Educativo", "ruta/al/documento7" },
                    { new Guid("8f4a67c2-fd5e-4316-8c50-7249f159d0f1"), true, new DateTime(2024, 3, 10, 23, 1, 28, 261, DateTimeKind.Local).AddTicks(9779), "Pasaporte", 1234567, "Documento de viaje", 4096, "Identificación", "ruta/al/documento8" },
                    { new Guid("9b9d6d8f-72f0-4f0a-8e18-1e75b0182e3f"), true, new DateTime(2024, 3, 10, 23, 1, 28, 261, DateTimeKind.Local).AddTicks(9781), "Certificado Médico", 543210, "Informe médico", 2048, "Salud", "ruta/al/documento9" },
                    { new Guid("f38f6b1a-86e9-4d9d-8a7a-62f17e6f1ba2"), true, new DateTime(2024, 3, 10, 23, 1, 28, 261, DateTimeKind.Local).AddTicks(9774), "Carné de Estudiante", 7890123, "Carné escolar", 3072, "Identificación", "ruta/al/documento6" }
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
                    { new Guid("2f591e2d-77b7-4213-8ff3-58c30cabbeb9"), "Departamento de Arte", "Curso de Arte Contemporáneo", "Inscripciones abiertas", "Grupo G", "Prácticas artísticas y exposiciones", "Presencial", "Intermedio", "Arte", "No se requiere experiencia previa en arte." },
                    { new Guid("31f9d6fb-2b04-4b64-83f3-5aaa03459515"), "Departamento de Física", "Curso de Física Avanzada", "Completo", "Grupo E", "Experimentos y clases teóricas", "Presencial", "Avanzado", "Física", "Requiere conocimientos previos de física." },
                    { new Guid("5ab6ab43-9ee0-4afd-a372-632b684a1d49"), "Departamento de Literatura", "Curso de Literatura Universal", "Inscripciones abiertas", "Grupo D", "Lecturas y discusiones literarias", "Presencial", "Intermedio", "Literatura", "Apto para amantes de la lectura." },
                    { new Guid("5d3ebda8-3305-4806-a1a5-5e9b2286c41f"), "Departamento de Matemáticas", "Curso de Matemáticas Avanzadas", "En progreso", "Grupo A", "Clases teóricas y prácticas", "Presencial", "Avanzado", "Matemáticas", "Se requiere calculadora científica." },
                    { new Guid("8782be17-4871-4470-9072-9eb7a4827432"), "Departamento de Economía", "Curso de Economía Moderna", "En progreso", "Grupo F", "Clases virtuales y análisis económico", "En línea", "Intermedio", "Economía", "Abordaremos temas financieros actuales." },
                    { new Guid("ab05923e-8291-4910-a1ed-5c33aec33987"), "Departamento de Historia", "Curso de Historia Mundial", "Inscripciones abiertas", "Grupo B", "Conferencias y debates", "Presencial", "Intermedio", "Historia", "Recomendado para estudiantes de Historia." },
                    { new Guid("f47610da-0a76-4439-83cb-f58a97b35593"), "Departamento de Informática", "Curso de Ciencias de la Computación", "En progreso", "Grupo C", "Clases virtuales y proyectos prácticos", "En línea", "Avanzado", "Ciencias de la Computación", "Requiere acceso a una computadora." }
                });

            migrationBuilder.InsertData(
                table: "Matricula",
                columns: new[] { "MatriculaId", "CategoriaMatricula", "Comentarios", "EstadoMatricula", "FechaMatricula", "InformacionPlanEstudios", "PeriodoAcademico", "RegistroCambios", "TipoMatricula" },
                values: new object[,]
                {
                    { new Guid("6187f385-2810-4409-be59-e04ce9f6e736"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 1", "Activa", new DateTime(2024, 3, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(1325), "Plan de estudios 2023", 2024, "Registro de cambios 1", "Matrícula Regular" },
                    { new Guid("770082ef-7010-4bb9-bc6b-d18cd8a16122"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 4", "Activa", new DateTime(2024, 6, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(1335), "Plan de estudios 2023", 2024, "Registro de cambios 4", "Matrícula Regular" },
                    { new Guid("848eb7c5-1d81-40fc-a3fd-ae2faf6e7eed"), "Estudiante Internacional", "Comentario sobre la matrícula 3", "Cancelada", new DateTime(2024, 5, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(1332), "Plan de estudios 2023", 2024, "Registro de cambios 3", "Matrícula Regular" },
                    { new Guid("ac3cf46d-0935-4c56-83cd-e34105da31ed"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 5", "Activa", new DateTime(2024, 7, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(1337), "Plan de estudios 2023", 2024, "Registro de cambios 5", "Matrícula Regular" },
                    { new Guid("d2550785-e0a4-40d7-88b5-0785e2d449cc"), "Estudiante de Tiempo Parcial", "Comentario sobre la matrícula 2", "Pendiente", new DateTime(2024, 4, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(1330), "Plan de estudios 2023", 2024, "Registro de cambios 2", "Matrícula Parcial" }
                });

            migrationBuilder.InsertData(
                table: "Notas",
                columns: new[] { "NotaId", "FechaCreacion", "Materia", "Periodo", "Titulo", "Valor" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(3246), "Matemáticas", "Primer Semestre", "Examen de Matemáticas", 85 },
                    { 2, new DateTime(2024, 3, 5, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(3249), "Ciencias", "Segundo Semestre", "Proyecto de Ciencias", 92 },
                    { 3, new DateTime(2024, 2, 29, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(3252), "Historia", "Primer Semestre", "Tarea de Historia", 75 },
                    { 4, new DateTime(2024, 3, 8, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(3255), "Español", "Segundo Semestre", "Presentación de Español", 88 },
                    { 5, new DateTime(2024, 3, 3, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(3257), "Inglés", "Primer Semestre", "Prueba de Inglés", 95 }
                });

            migrationBuilder.InsertData(
                table: "PreMatricula",
                columns: new[] { "PreMatriculaId", "EstadoPreMatricula", "GradoONivel", "Observaciones", "RequisitosDocumentacion", "Turno" },
                values: new object[,]
                {
                    { new Guid("39b48ba3-9fb5-4895-9c97-13ba98a8cc24"), "Activa", "Cuarto de Secundaria", "Estudiante con beca deportiva.", "SiCumplio", "Tarde" },
                    { new Guid("59dbde7a-9f84-4405-8014-a6de4c667523"), "Pendiente", "Quinto de Primaria", "Estudiante con requerimientos especiales.", "NoCumplio", "Mañana" },
                    { new Guid("9d52087e-fd56-4eb6-9394-d6a52a27f7c2"), "Activa", "Séptimo de Secundaria", "Estudiante de transferencia.", "SiCumplio", "Tarde" },
                    { new Guid("a594d116-f927-4089-a750-7924f045e8f4"), "Activa", "Segundo de Primaria", "Estudiante con discapacidad visual.", "SiCumplio", "Mañana" },
                    { new Guid("ba981089-27f7-49e5-9822-1cab0e3b94fc"), "Pendiente", "Tercero de Primaria", "Estudiante extranjero.", "SiCumplio", "Mañana" },
                    { new Guid("c4a8cb55-349e-4c0e-b806-ad9a4987de3c"), "Pendiente", "Octavo de Secundaria", "Estudiante sin observaciones adicionales.", "Si cumplio", "Tarde" }
                });

            migrationBuilder.InsertData(
                table: "RespuestaCupo",
                columns: new[] { "RespuestaCupoId", "DuracionRespuesta", "EstadoRespuesta", "FechaRespuesta", "FechaVencimiento", "MensajeRespuesta", "Prioridad", "TipoRespuesta", "UsuarioRespuesta" },
                values: new object[,]
                {
                    { new Guid("147ca901-ef7d-45f0-b7db-7549f304b83b"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2024, 3, 12, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(899), new DateTime(2024, 5, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(900), "Respuesta 2", "Media", "Rechazo", "Usuario2" },
                    { new Guid("22415d68-ee41-4719-8090-d6b38a107e3b"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2024, 3, 19, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(920), new DateTime(2024, 12, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(921), "Respuesta 9", "Alta", "Aceptación", "Usuario9" },
                    { new Guid("336c5984-cc55-4add-b00a-e5ab0a5a4569"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2024, 3, 17, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(916), new DateTime(2024, 10, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(916), "Respuesta 7", "Media", "Rechazo", "Usuario7" },
                    { new Guid("638bc303-ed5c-417f-a98e-597832ff6f6b"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2024, 3, 16, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(913), new DateTime(2024, 9, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(914), "Respuesta 6", "Alta", "Aceptación", "Usuario6" },
                    { new Guid("83e62310-e653-45ce-bbd5-e75523398089"), new TimeSpan(60, 0, 0, 0, 0), "Pendiente", new DateTime(2024, 3, 18, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(918), new DateTime(2024, 11, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(919), "Respuesta 8", "Baja", "Pendiente", "Usuario8" },
                    { new Guid("8a8ee4e6-0f83-4031-9ca2-04166abdccb6"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2024, 3, 14, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(905), new DateTime(2024, 7, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(906), "Respuesta 4", "Alta", "Aceptación", "Usuario4" },
                    { new Guid("a9276b77-0e54-4982-b9a1-f64d95e88b3f"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2024, 3, 11, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(884), new DateTime(2024, 4, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(892), "Respuesta 1", "Alta", "Aceptación", "Usuario1" },
                    { new Guid("a9bb89ee-5b98-478a-b9b3-1a238ef31598"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2024, 3, 15, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(911), new DateTime(2024, 8, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(911), "Respuesta 5", "Media", "Rechazo", "Usuario5" },
                    { new Guid("bdb8dbab-f495-4f1d-b293-00d7f07422e0"), new TimeSpan(60, 0, 0, 0, 0), "Pendiente", new DateTime(2024, 3, 13, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(902), new DateTime(2024, 6, 10, 23, 1, 28, 262, DateTimeKind.Local).AddTicks(903), "Respuesta 3", "Baja", "Pendiente", "Usuario3" }
                });

            migrationBuilder.InsertData(
                table: "TelefonoAcudiente",
                columns: new[] { "TelefonoAcudienteId", "AcudienteId", "Indicativo", "Numero", "Tipo" },
                values: new object[,]
                {
                    { new Guid("14128ee8-d9ef-4c46-8057-7d36136b1c80"), new Guid("96dd3f1c-630c-4c91-a42f-64c5e1360abe"), "+1", -6975, "Móvil" },
                    { new Guid("1e66f895-ac42-42ed-9f61-035e3598ea1e"), new Guid("ddf52652-f343-4c6d-bf2e-018667977851"), "+1", -4135, "Móvil" }
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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Docentes_HorarioId",
                table: "Docentes",
                column: "HorarioId",
                unique: true);

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

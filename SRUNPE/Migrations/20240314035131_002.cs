using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SRUNPE.Migrations
{
    /// <inheritdoc />
    public partial class _002 : Migration
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
                    { new Guid("18c5b92b-de36-41cb-b1e9-b1748633871a"), "Lopez", "maria.lopez@example.com", 40, "Casada", new DateTime(2024, 3, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(8615), "Maria", 987654321, 0L, "Abogada", "Madre" },
                    { new Guid("eb36d9a9-02a6-4cd8-a727-f8ea90aefe3e"), "Perez", "juan.perez@example.com", 45, "Casado", new DateTime(2024, 3, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(8602), "Juan", 123456789, 0L, "Ingeniero", "Padre" }
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
                    { new Guid("62793240-c29d-4de0-9fee-d2bba2f98ba0"), "Documentos adjuntos", "Gomez", "Calle 123", new DateTime(2000, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Pedro", 321L, 123L, 0L, "CC", "Estudiante" },
                    { new Guid("b01f8a25-cddb-449a-9da6-33588d3dcc57"), "Documentos adjuntos", "Rodriguez", "Carrera 456", new DateTime(1998, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Ana", 654L, 456L, 0L, "CC", "Estudiante" }
                });

            migrationBuilder.InsertData(
                table: "Cupo",
                columns: new[] { "CupoId", "CantidadDisponible", "Descripcion", "Duracion", "Estado", "FechaFin", "FechaInicio", "Ubicacion" },
                values: new object[,]
                {
                    { new Guid("170cca42-b031-4ab9-a4dd-7b54a1648071"), 20, "Cupo para el seminario de marketing", new TimeSpan(0, 4, 0, 0, 0), true, new DateTime(2024, 6, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9486), new DateTime(2024, 3, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9485), "Aula 102" },
                    { new Guid("63e6bfad-d8c2-4a5e-be42-5448f9e4baf5"), 5, "Cupo para el taller de programación", new TimeSpan(0, 3, 0, 0, 0), true, new DateTime(2024, 5, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9483), new DateTime(2024, 3, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9483), "Aula 101" },
                    { new Guid("85e42172-5ba1-4591-9bfb-a25a507458d9"), 30, "Cupo para el evento de networking", new TimeSpan(0, 1, 0, 0, 0), true, new DateTime(2024, 8, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9490), new DateTime(2024, 3, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9490), "Aula 104" },
                    { new Guid("a436c56c-b27f-46fb-853f-5aeac7f0152e"), 10, "Cupo para el evento principal", new TimeSpan(0, 2, 0, 0, 0), true, new DateTime(2024, 4, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9471), new DateTime(2024, 3, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9470), "Salón principal" },
                    { new Guid("b0082adb-6674-45e8-8004-bee6179d633d"), 15, "Cupo para el curso de diseño gráfico", new TimeSpan(0, 2, 0, 0, 0), true, new DateTime(2024, 7, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9488), new DateTime(2024, 3, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9488), "Aula 103" }
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "CursoId", "Año", "CodigoCurso", "CupoActual", "CupoMaximo", "DepartamentoAcademico", "Descripcion", "Estado", "FechaFinalizacion", "FechaInicio", "MetodosEnsenanza", "Modalidad", "Nivel" },
                values: new object[,]
                {
                    { new Guid("2cc44dd6-b42b-4c46-bfd0-e59f0d622afa"), 2024, "QUI105", 30, 35, "Química", "Química Orgánica", "Activo", new DateTime(2024, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virtual", "En línea", "Intermedio" },
                    { new Guid("2ede4ad2-4e82-4b75-b46d-c7397d3120a6"), 2024, "FIS102", 35, 40, "Ciencias Físicas", "Física General", "Activo", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virtual", "En línea", "Intermedio" },
                    { new Guid("50ab6e24-c070-454e-87c6-5e385a779ba9"), 2024, "LIT104", 18, 20, "Literatura", "Literatura Española", "Activo", new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Presencial", "Presencial", "Básico" },
                    { new Guid("cd056857-0e8d-457d-a4d2-6d77c8cf56ea"), 2024, "MAT101", 25, 30, "Matemáticas", "Introducción a las Matemáticas", "Activo", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Presencial", "Presencial", "Básico" },
                    { new Guid("f1d93bfa-3e70-4d5e-8930-89b644b04477"), 2024, "HIS103", 20, 25, "Historia", "Historia del Mundo Contemporáneo", "Activo", new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Híbrido", "Híbrido", "Avanzado" }
                });

            migrationBuilder.InsertData(
                table: "DireccionAcudiente",
                columns: new[] { "DireccionAcudienteId", "AcudienteId", "Calle", "CiudadLocalidad", "CodigoPostal", "ColoniaBarrio", "EstadoProvincia", "Pais" },
                values: new object[,]
                {
                    { new Guid("418a8084-f146-4a10-923f-282c2d6290ca"), new Guid("18c5b92b-de36-41cb-b1e9-b1748633871a"), "Carrera 50", "Bogotá", "110221", "Sur", "Bogotá", "Colombia" },
                    { new Guid("ff77fc50-c0be-424f-8709-7330ab14936a"), new Guid("eb36d9a9-02a6-4cd8-a727-f8ea90aefe3e\r\n"), "Calle 100", "Bogotá", "110111", "Norte", "Bogotá", "Colombia" }
                });

            migrationBuilder.InsertData(
                table: "Docentes",
                columns: new[] { "DocenteId", "Apellidos", "AulaId", "ComentariosNotas", "CorreoElectronico", "Direccion", "EstadoLaboral", "FechaContratacion", "FechaNacimiento", "Genero", "HorarioId", "NivelExperiencia", "Nombres", "NumeroIdentificacion", "NumeroTelefono", "TituloAcademico" },
                values: new object[,]
                {
                    { new Guid("3e332a31-3763-4b54-996c-8afd231fd518"), "González", null, "Experta en historia antigua", "maria.gonzalez@email.com", "Avenida Principal 456", "Activo", new DateTime(2012, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", null, "Medio", "María", "87654321", "555-5678", "Doctora en Historia" },
                    { new Guid("438fe643-9ec7-4da9-816b-b302613b48c1"), "Pérez", null, "Excelente capacidad de enseñanza", "juan.perez@email.com", "Calle Falsa 123", "Activo", new DateTime(2010, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", null, "Alto", "Juan", "12345678", "555-1234", "Licenciado en Matemáticas" },
                    { new Guid("df85ec49-e45d-46ac-8067-d3d2253d186c"), "Martínez", null, "Gran habilidad en experimentos prácticos", "carlos.martinez@email.com", "Boulevard del Río 789", "Inactivo", new DateTime(2008, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", null, "Alto", "Carlos", "11223344", "555-9101", "Magíster en Física" },
                    { new Guid("ebdccc35-c761-4548-aeee-836ef6cc5173"), "Rodríguez", null, "Especialista en biología marina", "laura.rodriguez@email.com", "Callejón de los Milagros 101", "Activo", new DateTime(2015, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", null, "Bajo", "Laura", "44332211", "555-1213", "Licenciada en Biología" }
                });

            migrationBuilder.InsertData(
                table: "Estadisticas",
                columns: new[] { "EstadisticaId", "AñoEscolar", "CantidadExamenes", "FechaRegistro", "Materia", "NotaMaxima", "NotaMinima", "NotaPromedio", "PeriodoEscolar" },
                values: new object[,]
                {
                    { 1, 2023, 5, new DateTime(2024, 3, 13, 22, 51, 31, 409, DateTimeKind.Local).AddTicks(1458), "Matemáticas", 9.0m, 7.5m, 8.5m, "Primer Trimestre" },
                    { 2, 2023, 4, new DateTime(2024, 3, 13, 22, 51, 31, 409, DateTimeKind.Local).AddTicks(1462), "Ciencias", 8.5m, 6.5m, 7.8m, "Segundo Trimestre" },
                    { 3, 2023, 3, new DateTime(2024, 3, 13, 22, 51, 31, 409, DateTimeKind.Local).AddTicks(1463), "Historia", 9.5m, 8.5m, 9.2m, "Tercer Trimestre" },
                    { 4, 2023, 5, new DateTime(2024, 3, 13, 22, 51, 31, 409, DateTimeKind.Local).AddTicks(1465), "Lenguaje", 8.0m, 6.0m, 7.2m, "Primer Semestre" },
                    { 5, 2023, 2, new DateTime(2024, 3, 13, 22, 51, 31, 409, DateTimeKind.Local).AddTicks(1467), "Arte", 9.0m, 8.0m, 8.7m, "Segundo Semestre" },
                    { 6, 2023, 3, new DateTime(2024, 3, 13, 22, 51, 31, 409, DateTimeKind.Local).AddTicks(1469), "Educación Física", 10.0m, 9.0m, 9.5m, "Trimestre Extra" }
                });

            migrationBuilder.InsertData(
                table: "EstudianteDocumentos",
                columns: new[] { "EstudianteDocumentosId", "Estado", "FechaActualizacion", "NombreDocumento", "NumeroDocumento", "Observaciones", "Tamaño", "TipoDocumento", "Ubicacion" },
                values: new object[,]
                {
                    { new Guid("10a5e754-1570-4be0-8650-2c53d7cfb4d3"), true, new DateTime(2024, 3, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(8864), "Fotografía del Estudiante", 1111111, "Foto de perfil", 1024, "Identificación", "ruta/al/documento10" },
                    { new Guid("2d54a999-187f-4a8c-99db-d17841e7938c"), true, new DateTime(2024, 3, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(8845), "Diploma", 987654, "Logros académicos", 2048, "Educativo", "ruta/al/documento2" },
                    { new Guid("3e68515e-3a47-4a62-a8c7-9f12242d020e"), false, new DateTime(2024, 3, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(8848), "Certificado de Graduación", 123456, "Graduación universitaria", 1536, "Educativo", "ruta/al/documento3" },
                    { new Guid("4a303cce-8c0e-4ae7-89c1-067d0b7741b6"), true, new DateTime(2024, 3, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(8849), "Certificado de Matrícula", 789012, "Matrícula escolar", 8192, "Educativo", "ruta/al/documento4" },
                    { new Guid("5f78d0e1-579e-4dfc-82a1-92010b4191d3"), true, new DateTime(2024, 3, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(8851), "Cédula de Identidad", 555555, "Documento oficial", 4096, "Identificación", "ruta/al/documento5" },
                    { new Guid("6a30c846-4b9d-4cf5-bb17-051a3e9d1b72"), true, null, "Certificado de Nacimiento", 61464465, "Ninguna", 1024, "Identificación", "ruta/al/documento1" },
                    { new Guid("7e15d9a4-98cb-4d14-9a35-862f8c202725"), true, new DateTime(2024, 3, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(8855), "Boleta de Calificaciones", 9876543, "Registro académico", 5120, "Educativo", "ruta/al/documento7" },
                    { new Guid("8f4a67c2-fd5e-4316-8c50-7249f159d0f1"), true, new DateTime(2024, 3, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(8858), "Pasaporte", 1234567, "Documento de viaje", 4096, "Identificación", "ruta/al/documento8" },
                    { new Guid("9b9d6d8f-72f0-4f0a-8e18-1e75b0182e3f"), true, new DateTime(2024, 3, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(8862), "Certificado Médico", 543210, "Informe médico", 2048, "Salud", "ruta/al/documento9" },
                    { new Guid("f38f6b1a-86e9-4d9d-8a7a-62f17e6f1ba2"), true, new DateTime(2024, 3, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(8853), "Carné de Estudiante", 7890123, "Carné escolar", 3072, "Identificación", "ruta/al/documento6" }
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
                columns: new[] { "MateriaId", "Creditos", "DepartamentoAcademico", "Descripcion", "Estado", "HorasPracticas", "HorasTeoricas", "MetodosEnsenanza", "Nivel", "Nombre", "NotasAdicionales" },
                values: new object[,]
                {
                    { new Guid("1a66763d-e4ea-4ebe-a3b8-2e794a359b82"), 4, "Matemáticas", "Fundamentos de aritmética y álgebra", "Activa", 2, 3, "Clases teóricas y ejercicios prácticos", "Secundaria", "Matemáticas Básicas", "Ninguna" },
                    { new Guid("2638268b-4ae9-48bd-a539-8b7565e0badc"), 3, "Historia", "Exploración de eventos históricos globales", "Activa", 0, 3, "Clases teóricas, análisis de documentos históricos", "Secundaria", "Historia Mundial", "Se recomienda visitar museos y sitios históricos" },
                    { new Guid("9a6fb2c2-ee53-445d-a722-f1eb7a1cb500"), 5, "Física", "Introducción a la mecánica, termodinámica y ondas", "Activa", 3, 4, "Clases teóricas, laboratorios", "Universitaria", "Física General", "Requiere calculadora científica" },
                    { new Guid("9a876aff-6e66-4a89-99cf-2c225eebf06a"), 6, "Biología", "Análisis profundo de la biología celular", "Activa", 4, 4, "Clases teóricas, laboratorios, proyectos de investigación", "Universitaria", "Biología Avanzada", "Requiere conocimientos previos de biología básica" },
                    { new Guid("bc7a91f7-cfcf-4739-99fe-b3cfb6b99081"), 3, "Humanidades", "Estudio de obras literarias españolas clásicas", "Inactiva", 1, 3, "Clases teóricas, discusiones en grupo", "Secundaria", "Literatura Española", "Incluye lecturas obligatorias" }
                });

            migrationBuilder.InsertData(
                table: "Matricula",
                columns: new[] { "MatriculaId", "CategoriaMatricula", "Comentarios", "EstadoMatricula", "FechaMatricula", "InformacionPlanEstudios", "PeriodoAcademico", "RegistroCambios", "TipoMatricula" },
                values: new object[,]
                {
                    { new Guid("083dc610-1401-4e41-9c08-18692853766b"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 5", "Activa", new DateTime(2024, 7, 13, 22, 51, 31, 409, DateTimeKind.Local).AddTicks(112), "Plan de estudios 2023", 2024, "Registro de cambios 5", "Matrícula Regular" },
                    { new Guid("148c5caf-86c9-4f35-9a92-39d619099972"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 4", "Activa", new DateTime(2024, 6, 13, 22, 51, 31, 409, DateTimeKind.Local).AddTicks(110), "Plan de estudios 2023", 2024, "Registro de cambios 4", "Matrícula Regular" },
                    { new Guid("2ecbd697-cebb-4c31-a58d-2cca2145eef5"), "Estudiante de Tiempo Completo", "Comentario sobre la matrícula 1", "Activa", new DateTime(2024, 3, 13, 22, 51, 31, 409, DateTimeKind.Local).AddTicks(98), "Plan de estudios 2023", 2024, "Registro de cambios 1", "Matrícula Regular" },
                    { new Guid("9cb071c5-4d27-4af8-9f65-728ee061d0f9"), "Estudiante de Tiempo Parcial", "Comentario sobre la matrícula 2", "Pendiente", new DateTime(2024, 4, 13, 22, 51, 31, 409, DateTimeKind.Local).AddTicks(102), "Plan de estudios 2023", 2024, "Registro de cambios 2", "Matrícula Parcial" },
                    { new Guid("a48ed6e3-d696-4c22-8213-cf5b4fe362c7"), "Estudiante Internacional", "Comentario sobre la matrícula 3", "Cancelada", new DateTime(2024, 5, 13, 22, 51, 31, 409, DateTimeKind.Local).AddTicks(106), "Plan de estudios 2023", 2024, "Registro de cambios 3", "Matrícula Regular" }
                });

            migrationBuilder.InsertData(
                table: "Notas",
                columns: new[] { "NotaId", "FechaCreacion", "Materia", "Periodo", "Titulo", "Valor" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 13, 22, 51, 31, 409, DateTimeKind.Local).AddTicks(1859), "Matemáticas", "Primer Semestre", "Examen de Matemáticas", 85 },
                    { 2, new DateTime(2024, 3, 8, 22, 51, 31, 409, DateTimeKind.Local).AddTicks(1861), "Ciencias", "Segundo Semestre", "Proyecto de Ciencias", 92 },
                    { 3, new DateTime(2024, 3, 3, 22, 51, 31, 409, DateTimeKind.Local).AddTicks(1864), "Historia", "Primer Semestre", "Tarea de Historia", 75 },
                    { 4, new DateTime(2024, 3, 11, 22, 51, 31, 409, DateTimeKind.Local).AddTicks(1865), "Español", "Segundo Semestre", "Presentación de Español", 88 },
                    { 5, new DateTime(2024, 3, 6, 22, 51, 31, 409, DateTimeKind.Local).AddTicks(1866), "Inglés", "Primer Semestre", "Prueba de Inglés", 95 }
                });

            migrationBuilder.InsertData(
                table: "PreMatricula",
                columns: new[] { "PreMatriculaId", "EstadoPreMatricula", "GradoONivel", "Observaciones", "RequisitosDocumentacion", "Turno" },
                values: new object[,]
                {
                    { new Guid("1fa47842-4860-4528-aff9-cfc6ce6af508"), "Pendiente", "Quinto de Primaria", "Estudiante con requerimientos especiales.", "NoCumplio", "Mañana" },
                    { new Guid("26642c19-18dd-415d-8cc2-14de560431dd"), "Pendiente", "Tercero de Primaria", "Estudiante extranjero.", "SiCumplio", "Mañana" },
                    { new Guid("a3653d1f-3930-4155-b5a3-f22964682011"), "Activa", "Segundo de Primaria", "Estudiante con discapacidad visual.", "SiCumplio", "Mañana" },
                    { new Guid("cc576451-7108-422a-bc2e-54a6d31411a3"), "Activa", "Séptimo de Secundaria", "Estudiante de transferencia.", "SiCumplio", "Tarde" },
                    { new Guid("d9b1d52d-fa44-411b-b5cb-160c690d6648"), "Activa", "Cuarto de Secundaria", "Estudiante con beca deportiva.", "SiCumplio", "Tarde" },
                    { new Guid("dba80af0-8f99-4017-8f05-069658ccca26"), "Pendiente", "Octavo de Secundaria", "Estudiante sin observaciones adicionales.", "Si cumplio", "Tarde" }
                });

            migrationBuilder.InsertData(
                table: "RespuestaCupo",
                columns: new[] { "RespuestaCupoId", "DuracionRespuesta", "EstadoRespuesta", "FechaRespuesta", "FechaVencimiento", "MensajeRespuesta", "Prioridad", "TipoRespuesta", "UsuarioRespuesta" },
                values: new object[,]
                {
                    { new Guid("43b86753-85d7-4b64-9f68-f6d1faa2e7e3"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2024, 3, 17, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9691), new DateTime(2024, 7, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9692), "Respuesta 4", "Alta", "Aceptación", "Usuario4" },
                    { new Guid("506c67e5-2a19-4350-aaa3-7b55e1f55fc7"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2024, 3, 14, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9672), new DateTime(2024, 4, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9677), "Respuesta 1", "Alta", "Aceptación", "Usuario1" },
                    { new Guid("51bbf26b-7678-49cf-a351-677578853fb8"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2024, 3, 18, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9693), new DateTime(2024, 8, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9694), "Respuesta 5", "Media", "Rechazo", "Usuario5" },
                    { new Guid("a0a57bab-8939-4a22-bb3c-b3bdf83a9fe2"), new TimeSpan(60, 0, 0, 0, 0), "Pendiente", new DateTime(2024, 3, 16, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9688), new DateTime(2024, 6, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9689), "Respuesta 3", "Baja", "Pendiente", "Usuario3" },
                    { new Guid("bb597efa-00ce-4085-a9fb-b5db313d564a"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2024, 3, 20, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9698), new DateTime(2024, 10, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9699), "Respuesta 7", "Media", "Rechazo", "Usuario7" },
                    { new Guid("bcadd5e0-c3db-4718-9b7c-3a2836c79e2c"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2024, 3, 19, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9696), new DateTime(2024, 9, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9696), "Respuesta 6", "Alta", "Aceptación", "Usuario6" },
                    { new Guid("e388ae95-d2ae-4cf6-8d02-8b533c6a91d1"), new TimeSpan(60, 0, 0, 0, 0), "Pendiente", new DateTime(2024, 3, 21, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9701), new DateTime(2024, 11, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9701), "Respuesta 8", "Baja", "Pendiente", "Usuario8" },
                    { new Guid("edcbaddb-7d09-4721-a6fe-2f7d44ca35dc"), new TimeSpan(45, 0, 0, 0, 0), "Rechazada", new DateTime(2024, 3, 15, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9682), new DateTime(2024, 5, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9683), "Respuesta 2", "Media", "Rechazo", "Usuario2" },
                    { new Guid("f4c49057-b095-414b-9821-7c108408a712"), new TimeSpan(30, 0, 0, 0, 0), "Aceptada", new DateTime(2024, 3, 22, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9703), new DateTime(2024, 12, 13, 22, 51, 31, 408, DateTimeKind.Local).AddTicks(9703), "Respuesta 9", "Alta", "Aceptación", "Usuario9" }
                });

            migrationBuilder.InsertData(
                table: "TelefonoAcudiente",
                columns: new[] { "TelefonoAcudienteId", "AcudienteId", "Indicativo", "Numero", "Tipo" },
                values: new object[,]
                {
                    { new Guid("d77ce6a4-3cbb-49c5-8170-a2ae242f44f7"), new Guid("18c5b92b-de36-41cb-b1e9-b1748633871a"), "+1", -4135, "Móvil" },
                    { new Guid("e9ea7058-2620-40cc-a908-9f88f74b6482"), new Guid("eb36d9a9-02a6-4cd8-a727-f8ea90aefe3e"), "+1", -6975, "Móvil" }
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

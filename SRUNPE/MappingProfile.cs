using AutoMapper;
using Entities.Models;
using Entities.Models.D_Acudiente;
using Entities.Models.D_Estudiante;
using Shared.DataTransferObjects;

namespace CompanyEmployees;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CandidatoEstudianteForUpdateDto, CandidatoEstudiante>();
        CreateMap<CandidatoEstudiante, CandidatoEstudianteDto>()
            .ForMember(dest => dest.CandidatoEstudianteId, opt => opt.MapFrom(src => src.CandidatoEstudianteId))
            .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
            .ForMember(dest => dest.Apellido, opt => opt.MapFrom(src => src.Apellido))
            .ForMember(dest => dest.FechaNacimiento, opt => opt.MapFrom(src => src.FechaNacimiento))
            .ForMember(dest => dest.TipoPersona, opt => opt.MapFrom(src => src.TipoPersona));

        CreateMap<EstudianteDocumentosForUpdateDto, EstudianteDocumentos>();
        CreateMap<EstudianteDocumentos, EstudianteDocumentosDto>()
            .ForMember(dest => dest.EstudianteDocumentosId, opt => opt.MapFrom(src => src.EstudianteDocumentosId))
            .ForMember(dest => dest.NombreDocumento, opt => opt.MapFrom(src => src.NombreDocumento))
            .ForMember(dest => dest.TipoDocumento, opt => opt.MapFrom(src => src.TipoDocumento))
            .ForMember(dest => dest.NumeroDocumento, opt => opt.MapFrom(src => src.NumeroDocumento))
            .ForMember(dest => dest.Estado, opt => opt.MapFrom(src => src.Estado))
            .ForMember(dest => dest.Observaciones, opt => opt.MapFrom(src => src.Observaciones))
            .ForMember(dest => dest.FechaActualizacion, opt => opt.MapFrom(src => src.FechaActualizacion))
            .ForMember(dest => dest.Ubicacion, opt => opt.MapFrom(src => src.Ubicacion))
            .ForMember(dest => dest.Tamaño, opt => opt.MapFrom(src => src.Tamaño));

        CreateMap<AcudienteForUpdateDto, Acudiente>();
        CreateMap<Acudiente, AcudienteDto>()
            .ForMember(dest => dest.AcudienteId, opt => opt.MapFrom(src => src.AcudienteId))
            .ForMember(dest => dest.Nombres, opt => opt.MapFrom(src => src.Nombres))
            .ForMember(dest => dest.Apellidos, opt => opt.MapFrom(src => src.Apellidos))
            .ForMember(dest => dest.NumeroIdentificacion, opt => opt.MapFrom(src => src.NumeroIdentificacion))
            .ForMember(dest => dest.Genero, opt => opt.MapFrom(src => src.Genero))
            .ForMember(dest => dest.FechaNacimiento, opt => opt.MapFrom(src => src.FechaNacimiento))
            .ForMember(dest => dest.CorreoElectronico, opt => opt.MapFrom(src => src.CorreoElectronico))
            .ForMember(dest => dest.RelacionConEstudiante, opt => opt.MapFrom(src => src.RelacionConEstudiante))
            .ForMember(dest => dest.EstadoCivil, opt => opt.MapFrom(src => src.EstadoCivil))
            .ForMember(dest => dest.Ocupacion, opt => opt.MapFrom(src => src.Ocupacion))
            .ForMember(dest => dest.Estado, opt => opt.MapFrom(src => src.Estado))
            .ForMember(dest => dest.FechaRegistro, opt => opt.MapFrom(src => src.FechaRegistro));

        CreateMap<TelefonoAcudienteForUpdateDto, TelefonoAcudiente>();
        CreateMap<TelefonoAcudiente, TelefonoAcudienteDto>()
            .ForMember(dest => dest.TelefonoAcudienteId, opt => opt.MapFrom(src => src.TelefonoAcudienteId))
            .ForMember(dest => dest.Numero, opt => opt.MapFrom(src => src.Numero))
            .ForMember(dest => dest.Tipo, opt => opt.MapFrom(src => src.Tipo))
            .ForMember(dest => dest.Indicativo, opt => opt.MapFrom(src => src.Indicativo));

        CreateMap<DireccionAcudienteForUpdateDto, DireccionAcudiente>();
        CreateMap<DireccionAcudiente, DireccionAcudienteDto>()
            .ForMember(dest => dest.DireccionAcudienteId, opt => opt.MapFrom(src => src.DireccionAcudienteId))
            .ForMember(dest => dest.AcudienteId, opt => opt.MapFrom(src => src.AcudienteId))
            .ForMember(dest => dest.Calle, opt => opt.MapFrom(src => src.Calle))
            .ForMember(dest => dest.ColoniaBarrio, opt => opt.MapFrom(src => src.ColoniaBarrio))
            .ForMember(dest => dest.CiudadLocalidad, opt => opt.MapFrom(src => src.CiudadLocalidad))
            .ForMember(dest => dest.CodigoPostal, opt => opt.MapFrom(src => src.CodigoPostal))
            .ForMember(dest => dest.EstadoProvincia, opt => opt.MapFrom(src => src.EstadoProvincia))
            .ForMember(dest => dest.Pais, opt => opt.MapFrom(src => src.Pais));

        CreateMap<CupoForUpdateDto, Cupo>();
        CreateMap<Cupo, CupoDto>()
            .ForMember(dest => dest.CupoId, opt => opt.MapFrom(src => src.CupoId))
            .ForMember(dest => dest.CantidadDisponible, opt => opt.MapFrom(src => src.CantidadDisponible))
            .ForMember(dest => dest.FechaInicio, opt => opt.MapFrom(src => src.FechaInicio))
            .ForMember(dest => dest.FechaFin, opt => opt.MapFrom(src => src.FechaFin))
            .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion))
            .ForMember(dest => dest.Ubicacion, opt => opt.MapFrom(src => src.Ubicacion))
            .ForMember(dest => dest.Estado, opt => opt.MapFrom(src => src.Estado))
            .ForMember(dest => dest.Duracion, opt => opt.MapFrom(src => src.Duracion));
            //.ForMember(dest => dest.CandidatoEstudianteId, opt => opt.MapFrom(src => src.CandidatoEstudianteId))
            //.ForMember(dest => dest.Comentarios, opt => opt.MapFrom(src => src.Comentarios));

        CreateMap<RespuestaCupoForUpdateDto, RespuestaCupo>();
        CreateMap<RespuestaCupo, RespuestaCupoDto>()
            .ForMember(dest => dest.RespuestaCupoId, opt => opt.MapFrom(src => src.RespuestaCupoId))
            .ForMember(dest => dest.FechaRespuesta, opt => opt.MapFrom(src => src.FechaRespuesta))
            .ForMember(dest => dest.EstadoRespuesta, opt => opt.MapFrom(src => src.EstadoRespuesta))
            .ForMember(dest => dest.MensajeRespuesta, opt => opt.MapFrom(src => src.MensajeRespuesta))
            .ForMember(dest => dest.FechaVencimiento, opt => opt.MapFrom(src => src.FechaVencimiento))
            .ForMember(dest => dest.UsuarioRespuesta, opt => opt.MapFrom(src => src.UsuarioRespuesta))
            .ForMember(dest => dest.TipoRespuesta, opt => opt.MapFrom(src => src.TipoRespuesta))
            .ForMember(dest => dest.DuracionRespuesta, opt => opt.MapFrom(src => src.DuracionRespuesta))
            .ForMember(dest => dest.Prioridad, opt => opt.MapFrom(src => src.Prioridad));

        CreateMap<MatriculaForUpdateDto, Matricula>();
        CreateMap<Matricula, MatriculaDto>()
            .ForMember(dest => dest.MatriculaId, opt => opt.MapFrom(src => src.MatriculaId))
            .ForMember(dest => dest.FechaMatricula, opt => opt.MapFrom(src => src.FechaMatricula))
            .ForMember(dest => dest.EstadoMatricula, opt => opt.MapFrom(src => src.EstadoMatricula))
            .ForMember(dest => dest.TipoMatricula, opt => opt.MapFrom(src => src.TipoMatricula))
            .ForMember(dest => dest.PeriodoAcademico, opt => opt.MapFrom(src => src.PeriodoAcademico))
            .ForMember(dest => dest.Comentarios, opt => opt.MapFrom(src => src.Comentarios))
            .ForMember(dest => dest.CategoriaMatricula, opt => opt.MapFrom(src => src.CategoriaMatricula))
            .ForMember(dest => dest.InformacionPlanEstudios, opt => opt.MapFrom(src => src.InformacionPlanEstudios))
            .ForMember(dest => dest.RegistroCambios, opt => opt.MapFrom(src => src.RegistroCambios));

        CreateMap<PreMatriculaForUpdateDto, PreMatricula>();
        CreateMap<PreMatricula, PreMatriculaDto>()
            .ForMember(dest => dest.PreMatriculaId, opt => opt.MapFrom(src => src.PreMatriculaId))
            .ForMember(dest => dest.GradoONivel, opt => opt.MapFrom(src => src.GradoONivel))
            .ForMember(dest => dest.Turno, opt => opt.MapFrom(src => src.Turno))
            .ForMember(dest => dest.Observaciones, opt => opt.MapFrom(src => src.Observaciones))
            .ForMember(dest => dest.EstadoPreMatricula, opt => opt.MapFrom(src => src.EstadoPreMatricula))
            .ForMember(dest => dest.RequisitosDocumentacion, opt => opt.MapFrom(src => src.RequisitosDocumentacion));



        //MapCreate
        CreateMap<CandidatoEstudianteForCreationDto, CandidatoEstudiante>();
        CreateMap<AcudienteForCreationDto, Acudiente>();
        CreateMap<EstudianteDocumentosForCreationDto, EstudianteDocumentos>();
        CreateMap<TelefonoAcudienteForCreationDto, TelefonoAcudiente>();
        CreateMap<DireccionAcudienteForCreationDto, DireccionAcudiente>();
        CreateMap<CupoForCreationDto, Cupo>();
        CreateMap<RespuestaCupoForCreationDto, RespuestaCupo>();
        CreateMap<PreMatriculaForCreationDto, PreMatricula>();
        CreateMap<MatriculaForCreationDto, Matricula>();

    }
}

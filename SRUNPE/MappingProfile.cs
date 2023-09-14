using AutoMapper;
using Entities.Models;
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

        CreateMap<CupoForUpdateDto, Cupo>();
        CreateMap<Cupo, CupoDto>()
            .ForMember(dest => dest.CupoId, opt => opt.MapFrom(src => src.CupoId))
            .ForMember(dest => dest.CantidadDisponible, opt => opt.MapFrom(src => src.CantidadDisponible))
            .ForMember(dest => dest.FechaInicio, opt => opt.MapFrom(src => src.FechaInicio))
            .ForMember(dest => dest.FechaFin, opt => opt.MapFrom(src => src.FechaFin))
            .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion))
            .ForMember(dest => dest.Ubicacion, opt => opt.MapFrom(src => src.Ubicacion))
            .ForMember(dest => dest.Estado, opt => opt.MapFrom(src => src.Estado))
            .ForMember(dest => dest.Duracion, opt => opt.MapFrom(src => src.Duracion))
            .ForMember(dest => dest.CandidatoEstudianteId, opt => opt.MapFrom(src => src.CandidatoEstudianteId))
            .ForMember(dest => dest.Comentarios, opt => opt.MapFrom(src => src.Comentarios));



        //MapCreate
        CreateMap<CandidatoEstudianteForCreationDto, CandidatoEstudiante>();
        CreateMap<AcudienteForCreationDto, Acudiente>();
        CreateMap<EstudianteDocumentosForCreationDto, EstudianteDocumentos>();
        CreateMap<TelefonoAcudienteForCreationDto, TelefonoAcudiente>();

    }
}
